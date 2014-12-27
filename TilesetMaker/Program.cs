using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TilesetMaker
{
    static class Program
    {
        public static Version Version = new Version(0, 1);
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
