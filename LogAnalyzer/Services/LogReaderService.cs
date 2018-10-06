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
            string content = File.ReadAllText(@"C:\__Rafał\REPO\LogAnalyzer\_WORK_FODLER\log.txt");

            return content;
        }
    }
}