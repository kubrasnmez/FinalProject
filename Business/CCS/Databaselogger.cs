using System;

namespace Business.CCS
{
    public class Databaselogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
