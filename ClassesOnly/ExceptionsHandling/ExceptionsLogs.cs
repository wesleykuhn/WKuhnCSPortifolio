using System;
using System.IO;

namespace ClassesOnly.ExceptionsHandling
{
    public static class ExceptionsLogs
    {
        public static void AppendOnErrorLogFile(Exception ex)
        {
            StreamWriter sw = File.AppendText(Informations.Directories.ExceptionsLogsFile);
            sw.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " -> Mensagem: " + ex.Message + "| Fonte:" + ex.Source);
            sw.Close();
        }

        public static void AppendOnErrorLogFile(string exceptionMessage)
        {
            StreamWriter sw = File.AppendText(Informations.Directories.ExceptionsLogsFile);
            sw.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " -> Mensagem: " + exceptionMessage);
            sw.Close();
        }
    }
}
