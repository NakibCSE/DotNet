using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Singleton
{
    public class Logger
    {
        private const string FILE_NAME = "";

        private Logger _logger;
        public void WriteLog(string message)
        {
            lock (this)
            {
                File.WriteAllText(FILE_NAME, message); 
            }
        }
    }
}
