using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LogAnalyzer.Services
{
    public class LogReaderService
    {
        public string Read(string path)
        {
            var directory = new DirectoryInfo(path);
            var myFile = directory.GetFiles()
             .OrderByDescending(f => f.LastWriteTime)
             .First();
            string content = File.ReadAllText(myFile.FullName);

            return content;
        }
    }
}