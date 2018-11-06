using LogAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LogAnalyzer.Services
{
    public class LogListingService
    {
        public Dictionary<string, string> _logsDict = new Dictionary<string, string>();
        public List<string> _names = new List<string>();

        public LogListingService(string path)
        {
            Load(path);
        }

        private void Load(string path)
        {
            string[] dirList = Directory.GetDirectories(path);
            foreach (var directory in dirList)
            {
                string name = Path.GetFileName(directory);
                _names.Add(name);
                _logsDict.Add(name, directory);
            }
        }

        public LogAnalyzerModel LoadModel()
        {
            LogAnalyzerModel model = LogAnalyzerModel.GetModel();
            model.Names = _names;
            model.LogsDict = _logsDict;

            return model;
        }


    }
}