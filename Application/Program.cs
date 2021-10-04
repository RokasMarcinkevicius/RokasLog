using System;

namespace RokasLog
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHelper.Log(LogTarget.File, "Hello");
            LogHelper.Log(LogTarget.EventLog, "Hello");
        }
    }
}
