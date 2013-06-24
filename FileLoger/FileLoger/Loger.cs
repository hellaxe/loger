using System.Collections.Generic;
using System.IO;


namespace FileLoger
{
    internal class Loger
    {
        public Loger(string dirpath)
        {
            _path = dirpath;
        }

        public IList<FileInfo> FileList
        {
            get { return _fileList; }
        } 

        public void GetLog()
        {
            var dirInfo = new DirectoryInfo(_path);
            _fileList = dirInfo.GetFiles();
        }


        public void SaveLog()
        {
            using (var file = new StreamWriter(_path + @"\log.txt"))
            {
                foreach (var fileInfo in _fileList)
                {
                    file.Write(fileInfo.Name + "\n");
                }
            }

        }

        private readonly string _path;
        private IList<FileInfo> _fileList = new List<FileInfo>();
    }
}
