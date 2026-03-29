namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*using Timer timer = new Timer(new TimerCallback(TimerMethod));
            timer.Change(2000, 500);*/

            //Thread thread = new Thread(ThreadMethodWithParameter);
            //Thread thread = new Thread(() => ThreadMethodWithParameter(42, "Hello"));

            //Thread thread = new Thread(new ParameterizedThreadStart(ThreadMethodWithParameter));
            //Thread thread = new Thread(() => ThreadMethodWithParameter(42, "Hello"));
            Thread thread = new Thread(() => {for (int i = 0;; i++) { Console.WriteLine($"Infinite loop{i}"); }});
            thread.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue ;
                Console.WriteLine($"Main(id = {Thread.CurrentThread.ManagedThreadId}): {i}");
            }
            //Console.ReadKey();
        }
        private static void ThreadMethodWithParameter(int value, string message)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"ThreadMethodWithParameter(id = {Thread.CurrentThread.ManagedThreadId}): {i} - {value}//{message}");
                //Thread.Sleep(1000);
            }
        }
        private static void ThreadMethod()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"ThreadMethod: {i}");
                //Thread.Sleep(1000);
            }
        }
        private static void TimerMethod(object? timer)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("TimerMethod invoked");
        }
    }
}
