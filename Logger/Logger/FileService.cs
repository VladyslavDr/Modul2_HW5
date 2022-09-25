using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class FileService
    {
        private static int _count = 0;
        private static string _path = "log";

        // private static FileInfo[] _info = new DirectoryInfo(_path).GetFiles("*.txt");
        private static FileInfo[] _info = new FileInfo[3];

        public static void RecordingToFile(string messege)
        {
            DateTime time = DateTime.Now;
            string fileName = " " + time.ToString("hh.mm.ss") + " " + time.ToString("dd.MM.yyyy") + ".txt";

            using (var sw = new StreamWriter(_path + fileName, false))
            {
                sw.WriteLine(messege);

                if (_count == _info.Length)
                {
                    _count = 0;
                }

                if (_info[_count] != null)
                {
                    _info[_count].Delete();
                }

                _info[_count++] = new FileInfo(_path + fileName);
            }
        }
    }
}
