using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AuxiliarySensors.Models;

namespace AuxiliarySensors.ConfigParser
{
    public class ConfigUtil
    {
        //public string FolderPath { get; set; }
        //public string FileContents { get; set; }

        //public void ReadFile()
        //{
        //    FileContents = File.ReadAllText(FilePath);
        //}



        public static List<MonitorSetupFile> GetFiles(string path)
        {
            var files = Directory.GetFiles(path);
            var filesAsList = new List<MonitorSetupFile>();

            foreach (var file in files)
            {
                filesAsList.Add(new MonitorSetupFile { Name = Path.GetFileName(file), FullName = file, Contents = File.ReadAllText(file) });
            }

            return filesAsList;
        }
    }
}
