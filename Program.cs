

internal class Program
{
    private static readonly object consoleLock = new object();


    private static void Main(string[] args)
    {
        Console.Clear();
        // Console.WindowWidth = 180;
        // Console.WindowHeight = 125;
        // Console.WindowWidth = 80;
        // Console.WindowHeight = 25;
        // Console.BufferWidth = 80;
        // Console.BufferHeight = 25;
        Console.SetWindowSize(80, 25);
        Console.BufferWidth = 500;
        Console.BufferHeight = 50;


        Thread.Sleep(2000);
        Task task = Task.Factory.StartNew(() => RunningDuck(0));
        Task task2 = Task.Factory.StartNew(() => RunningDuck(10));

        while (true)
        {

        }


    }
    static void RunningDuck(int position)
    {

        string duck = @"
    __
___( o)>
\ <_. )
 `---'
";
        List<string> s = duck.Split('\n').ToList();

        int start = 0;
        while (true)
        {
            int counter = 0;
            lock (consoleLock)
            {
                try
                {
                    Console.CursorTop = position;
                    foreach (var item in s)
                    {
                        Console.CursorLeft = start;
                        Console.WriteLine(item);

                        // Console.CursorLeft = start - 8;
                        // Console.WriteLine(" ");

                    }
                    Thread.Sleep(1000);

                    start += 8;


                }
                catch (System.Exception)
                {
                    throw;
                }
            }

        }
    }






    // Console.WriteLine("Here am I");
    // Console.WriteLine("Here am I now");
    // Console.CursorLeft += 60;
    // Console.Write("Here am I now");


}

// You can use the Console.SetCursorPosition() method to set the cursor position to a specific row and column in the console buffer.
// You can use the Console.MoveBufferArea() method to move a rectangular region of characters within the console buffer. 
// This will cause the console to be refreshed, and the moved characters will be displayed in the console window.
// You can use the Console.CursorLeft and Console.CursorTop properties to move the cursor to a new location relative to its current position. 
// For example, you can use Console.CursorLeft += 10 to move the cursor 10 columns to the right.

// It's also worth noting that the console window can be refreshed manually using the Console.Clear() method, 
// which will clear the console buffer and reset the cursor position to the top-left corner of the console window.