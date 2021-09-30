using System;
using System.IO;

namespace RokasLog
{
    public static class SourceReturner
    {
        public static string SourceReturn()
        {
            return "RokasLog reported on @";
        }
    }

    public abstract class LogBase
    {
        public abstract void Log(string message);
    }

    public class FileLogger : LogBase
    {
        public string filePath = "E:/RokasLog.txt";

        public override void Log(string message)
        {
            message = SourceReturner.SourceReturn() + DateTime.Now + " Reported message:" + message;

            using (StreamWriter streamWriter = new StreamWriter(filePath, append: true))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
                       
        }
    }

    public class DBLogger : LogBase
    {
        string connectionString = string.Empty;
        public override void Log(string message)
        {
            //Code to log data to the database
        }
    }

    public class EventLogger: LogBase
    {

        public EventLogger()
        {
        }
        
        public EventLogger(string v)
        {
        }

        public string Source { get; set; }

        public override void Log(string message)
        {
            EventLogger eventLog = new EventLogger("");
            eventLog.Source = SourceReturner.SourceReturn();
            eventLog.WriteEntry(eventLog.Source, message);
        }

        private string WriteEntry(string source, string message)
        {
            message = source + DateTime.Now + " Reported message:" + message;
            Console.WriteLine(message);
            return message;
        }
    }     
}
         