using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TilesetMaker
{
    public partial class MainForm : Form
    {
        private Size _atlasSize;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text += " - v" + Program.Version.Major.ToString() + "." + Program.Version.Minor.ToString();
        }

        private void imageSourceFolderBrowse_Click(object sender, EventArgs e)
        {
            if (imageSourceFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                imageSourceFolder.Text = imageSourceFolderBrowser.SelectedPath;

                if (Directory.Exists(imageSourceFolder.Text))
                    RefreshFiles();
            }
        }

        private void RefreshFiles()
        {
            includedFiles.Items.Clear();
            excludedFiles.Items.Clear();

            Dictionary<Size, List<string>> files = new Dictionary<Size, List<string>>();

            foreach (string s in Directory.GetFiles(imageSourceFolder.Text))
            {
                string ext = Path.GetExtension(s).ToLower();
                if (ext == ".png" || ext == ".bmp" || ext == ".jpg")
                {
                    Size si = ImageHelper.GetDimensions(s);

                    if (!files.ContainsKey(si))
                        files.Add(si, new List<string>());

                    files[si].Add(s);
                }
            }

            List<Size> sizeList = files.Keys.ToList();
            sizeList.Sort(new Comparison<Size>(CompareSize));

            _atlasSize = sizeList[0];

            entryWInfo.Text = String.Format((string)entryWInfo.Tag, _atlasSize.Width);
            entryHInfo.Text = String.Format((string)entryHInfo.Tag, _atlasSize.Height);

            foreach (KeyValuePair<Size, List<string>> pair in files)
            {
                foreach (string file in pair.Value)
                {
                    if (pair.Key == _atlasSize)
                        includedFiles.Items.Add(new IncludeListItem(file));
                    else
                        excludedFiles.Items.Add(Path.GetFileName(file));
                }
            }

            generate.Enabled = (includedFiles.Items.Count > 0);
        }

        int CompareSize(Size a, Size b)
        {
            if (a == b)
                return 0;

            int s1 = a.Width*a.Height;
            int s2 = b.Width*b.Height;
            if (s1 > s2)
                return 1;
            if (s2 > s1)
                return -1;

            return 0;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (saveOutput.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;

                int files = includedFiles.Items.Count;
                int axis = (int)Math.Ceiling(Math.Sqrt(files));

                Bitmap output = new Bitmap(axis * _atlasSize.Width, axis * _atlasSize.Height);
                Graphics draw = Graphics.FromImage(output);

                XElement xmlNode = null;
                if (generateXML.Checked)
                {
                    xmlNode = new XElement("AtlasData");

                    xmlNode.Add("Size", axis);
                }

                for (int x = 0; x < files; x++)
                {
                    int dx = x % axis;
                    int dy = x / axis;

                    IncludeListItem lst = ((IncludeListItem)includedFiles.Items[x]);

                    using (Image i = Image.FromFile(lst.FilePath))
                    {
                        draw.DrawImage(i, new Point(dx * _atlasSize.Width, dy * _atlasSize.Height));
                    }

                    if (generateXML.Checked)
                    {
                        XElement el = new XElement("Element");
                        el.Add(new XElement("X", dx.ToString()));
                        el.Add(new XElement("Y", dy.ToString()));
                        el.Add(new XElement("I", x.ToString()));
                        el.Add(new XElement("N", Path.GetFileNameWithoutExtension(lst.FilePath)));
                        xmlNode.Add(el);
                    }
                }

                draw.Dispose();

                output.Save(saveOutput.FileName);
                output.Dispose();

                if (generateXML.Checked)
                {
                    string xmlFile = Path.Combine(Path.GetDirectoryName(saveOutput.FileName), Path.GetFileNameWithoutExtension(saveOutput.FileName)) + ".xml";

                    XDocument doc = new XDocument();
                    doc.Add(xmlNode);
                    doc.Save(xmlFile);
                }

                Cursor = Cursors.Arrow;
            }
        }
    }
}