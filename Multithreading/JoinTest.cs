namespace CSharpTwelve.Multithreading;

public class JoinTest
{
    public JoinTest()
    {
        
    }

    public void Run() {
        Thread t1 = new(WriteX);
        Thread t2 = new(WriteY);
        Thread t3 = new(WriteZ);

        t1.Start();
        t2.Start();
        t3.Start();
        
        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("Main thread completed execution");
    }

    private void WriteX() {
        for(int i = 0;i <500; i++) {
            Console.Write("X");
        }
        Console.WriteLine("Write X completed execution");
    }

    private void WriteY() {
        for(int i = 0;i <500; i++) {
            Console.Write("Y");
        }
        Console.WriteLine("Write Y completed execution");
    }

    private void WriteZ() {
        for(int i = 0;i <500; i++) {
            Console.Write("Z");
        }
        Console.WriteLine("Write Z completed execution");
    }
}