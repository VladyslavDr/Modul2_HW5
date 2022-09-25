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
        public static void RecordingToFile(string messege)
        {
            DateTime time = DateTime.Now;
            string fileName = time.ToString("hh.mm.ss") + " " + time.ToString("dd.MM.yyyy") + ".txt";

            using (var sw = new StreamWriter(fileName, false))
            {
                sw.WriteLine(messege);
            }
        }
    }
}
