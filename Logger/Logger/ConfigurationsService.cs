using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class ConfigurationsService
    {
        public ConfigurationsService(DateTime time, string fileName, string path)
        {
            Time = time;
            FileName = fileName;
            Path = path;
        }

        public DateTime Time { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
    }
}
