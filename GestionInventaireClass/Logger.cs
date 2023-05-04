using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventaireClass
{
    public class Logger
    {
         
        public enum Level { DEBUG, INFO, WARNING, ERROR };

        #region public methods
        public void writeInLogFile(Level level, String logDirectoryPath, String logFileName, String logMessage)
        {
            StreamWriter strWriter = null;

            if (Directory.Exists(logDirectoryPath))
            {
                try
                {
                    strWriter = File.AppendText(logDirectoryPath + @".\" + logFileName);
                    strWriter.WriteLine(buildLogString(level, logMessage));

                }
                finally
                {
                    strWriter.Close();
                }
            }
        }
        #endregion public methods

        #region private methods
        private string buildLogString(Level level, String logMessage)
        {
            DateTime timeStamp = DateTime.Now;

            return timeStamp.ToString("yyyyMMddHHmmss") + "\t" + level + "\t" + logMessage;
        }
        #endregion private methods
    }
}

