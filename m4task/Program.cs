namespace oopint;
using m4task;
class Program
{

    static void Main(string[] args)
    {
    go:
        Console.Write("Enter name:");
        string fn=Console.ReadLine();
        Console.Write("Enter email:");
        string email = Console.ReadLine();
        Console.Write("Enter password:");
        string password = Console.ReadLine();
        
        try
        {
            User u = new User(fn,email,password);
            Console.WriteLine(u.ShowInfo());
        }
        catch (Exception ex)
        {

           Console.WriteLine(ex.Message);
        }
        Console.WriteLine("New? y or n");
        string c=Console.ReadLine().ToLower();

        if (c =="y" )
        {
            goto go;
        }
     


        Console.ReadLine();
    }
}