using System.IO;

namespace ConsoleApp.Writing
{
    class FileWriter : IWriter
    {
        private string _path;
        public FileWriter(string path)
        {
            _path = path;
        }
        public void Write(string str)
        {
            using (StreamWriter streamWriter = new StreamWriter(_path))
            {
                streamWriter.Write(str);
            }
        }
    }
}
