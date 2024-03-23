using ExtensionMethods;
using DomainExtensions;
using StructExtensions;
using EnumExtensions;
using DefineIMyInterface;
using Extensions;
using ExtensionMethodsDemo;

class Program
{
    static void Main(string[] args)
    {
        string s = "Hello, World!";
        // Use the string extension method directly on a string.
        int words = s.WordCount();
        // Extension Methods are static inoke directly from namespace.
        int d = AppExtensions.WordCount(s);

        Console.WriteLine("Method 1 (Directly from String)  : {0} has {1} words.", s, words);
        Console.WriteLine("Method 2 (Invoke from Namespace) : {0} has {1} words.", s, d);

        //-----------------------

        UserEntity user = new UserEntity {Id = 1, FirstName = "John", LastName = "Doe"};
        Console.WriteLine("User Full Name : {0}", user.FullName());

        //-----------------------
        // Using Extension of predefined types
        int x = 1;

        // Takes x by value leading to the extension method
        // Increment modifying its own copy, leaving x unchanged
        x.Increment();
        Console.WriteLine($"x is now {x}"); // x is now 1

        // Takes x by reference leading to the extension method
        // RefIncrement changing the value of x directly
        x.RefIncrement();
        Console.WriteLine($"x is now {x}"); // x is now 2

        //------------------------

        Account account = new(){
            id = 1,
            balance = 0f
        };

        Console.WriteLine($"I have ${account.balance}"); // I have $100

        account.Deposit(50f);
        Console.WriteLine($"I have ${account.balance}"); // I have $150

        //------------------------------

        int role = (int)Roles.User;
        Roles roleA = Roles.User;
        if (roleA.IsAdmin()){
            Console.WriteLine("Role is Admin");
        } else {
            Console.WriteLine("Role is not Admin");
        }

        //-----------------------------------

        // Declare new instances of classes that inherit from IMyInterface
        A a = new A();
        B b = new B();
        C c = new C();

        a.MethodA(1);       // Uses extension method
        a.MethodA("Hello"); // Uses extension method
        a.MethodB();        // Will use A MethodB instead of the extension (MethodB with same signature is implemente in A)

        b.MethodA(1);       // Will use B MethodA instead of the extension (MethodA with same signature is implemented in B)
        b.MethodA("Hello"); // Uses extension method
        b.MethodB();        // Will use B MethodA instead of the extension (MethodA with same signature is implemented in B)

        c.MethodA(1);       // Will use C MethodA instead of the extension (MethodA with same signature is implemented in C)
        c.MethodA("Hello"); // Will use C MethodA instead of the extension (MethodA with same signature is implemented in C)
        c.MethodB();        // Will use C MethodA instead of the extension (MethodA with same signature is implemented in C)
    }
}
