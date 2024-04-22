namespace CSharpTwelve.Multithreading;

public class SampleThread
{
    public void Run()
    {
        Thread worker = new(WriteY)
        {
            Name = "Thread-WriteY"
        };
        worker.Start();
        worker.Join();

        // Main Thread
        WriteX();

        Console.WriteLine("Threads execution completed!");
    }

    public void WriteX()
    {
        for (var i = 0; i < 500; i++)
        {
            Console.Write("X");
        }
        Console.WriteLine("Write X execution completed!");
    }

    public void WriteY()
    {
        for (var i = 0; i < 500; i++)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Y");
        }
        Console.WriteLine("Write Y execution completed!");
    }
}