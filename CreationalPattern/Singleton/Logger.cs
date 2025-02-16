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

        #region Singleton patter: that ensure only one instance can be created at a time
        private static Logger _logger;
        private Logger () { }
        public static Logger GetLogger()
        {
            if (_logger == null)
                _logger = new Logger();
            return _logger;
        }
        #endregion
        public void WriteLog(string message)
        {
            lock (this)
            {
                File.WriteAllText(FILE_NAME, message); 
            }
        }
    }
}
