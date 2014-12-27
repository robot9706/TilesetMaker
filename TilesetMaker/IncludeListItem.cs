using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TilesetMaker
{
    class IncludeListItem
    {
        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public IncludeListItem(string path)
        {
            _filePath = path;
        }

        public override string ToString()
        {
            return Path.GetFileName(_filePath);
        }
    }
}
