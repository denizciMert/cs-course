using System;

namespace RecapDemo2
{
    public class LogTypes
    {
        public class DatabaseLogM : ILogManager
        {
            public void Log(string message = "Log Created")
            {
                Console.WriteLine("Log Created On Database!");
            }
        }

        public class FileLogM : ILogManager
        {
            public void Log(string message = "Log Created")
            {
                Console.WriteLine("Log Created On File!");
            }
        }

        public class SmsLogM : ILogManager
        {
            public void Log(string message = "Log Created")
            {
                Console.WriteLine("Log Created On SMS!");
            }
        }
    }
}