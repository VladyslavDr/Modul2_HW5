using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Logger
{
    public static class FileService
    {
        private static int _count = 0;

        private static FileInfo[] _info = new FileInfo[3];

        public static void RecordingToFile(string messege)
        {
            var time = DateTime.Now;

            var configService = new ConfigurationsService(time, time.ToString("hh.mm.ss") + " " + time.ToString("dd.MM.yyyy") + ".txt", "log");

            var json = JsonConvert.SerializeObject(configService);
            File.WriteAllText("config.json", json);

            var configFile = File.ReadAllText("config.json");
            var config = JsonConvert.DeserializeObject<ConfigurationsService>(configFile);

            string path = config.Path;
            string fileName = config.FileName;

            using (var sw = new StreamWriter(path + fileName, false))
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

                _info[_count++] = new FileInfo(path + fileName);
            }
        }
    }
}
