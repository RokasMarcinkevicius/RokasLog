namespace RokasLog
{
    public class LogHelper
    {
        private static LogBase logger = null;
        public void Log(LogTarget target, string message)
        {
            switch(target)
            {
                case LogTarget.File:
                    logger = new FileLogger();
                    logger.Log(message);
                    break;
                case LogTarget.Database:
                    logger = new DBLogger();
                    logger.Log(message);
                    break;
                case LogTarget.EventLog:
                    logger = new EventLogger();
                    logger.Log(message);
                    break;
                case LogTarget.RabbitMq:
                    logger = new RabbitMqLogger();
                    logger.Log(message);
                    break;
                default:
                    return;
            }
        }

        public void Log(string message)
        {
            // Could use a for loop, but that would be slower and use more memory.
            logger = new FileLogger();
            logger.Log(message);
            logger = new DBLogger();
            logger.Log(message);
            logger = new EventLogger();
            logger.Log(message);
            logger = new RabbitMqLogger();
            logger.Log(message);
        }
    }
}
