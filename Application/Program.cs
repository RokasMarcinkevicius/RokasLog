using System;

namespace RokasLog
{
    class Program
    {
        static void Main(string[] args, LogHelper logHelper)
        {
            logHelper.Log(LogTarget.File, "Hello");
            logHelper.Log(LogTarget.EventLog, "Hello");
        }
    }
}
