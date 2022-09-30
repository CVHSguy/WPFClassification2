using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextClassification.FileIO
{
    public abstract class FileAdapter
    {
        private string _fileType;
        public FileAdapter(string fileType)
        {
            _fileType = fileType;
        }
        public abstract List<string> GetAllFileNames(string folderName);
        public abstract string GetAllTextFromFileA(string fileName);

        public abstract string GetAllTextFromFileB(string fileName);

        public string GetFileType()
        {
            return _fileType;
        }
    }
}
