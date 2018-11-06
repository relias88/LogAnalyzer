using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogAnalyzer.Models
{
    public class LogAnalyzerModel
    {
        private static  LogAnalyzerModel model;
        private LogAnalyzerModel()
        {
            
        }

        public static LogAnalyzerModel GetModel()
        {
            if (model == null)
            {
                model = new LogAnalyzerModel();
            }
            return model;
        }
        public Dictionary<string, string> LogsDict = new Dictionary<string, string>();
        public List<string> Names = new List<string>();

        public Dictionary<string, string> ContentListDict = new Dictionary<string, string>();
    }
}
