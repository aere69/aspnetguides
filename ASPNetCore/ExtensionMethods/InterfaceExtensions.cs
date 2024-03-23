//Define Interface IMyInterface
namespace DefineIMyInterface
{
    public interface IMyInterface
    {
        //Must be defined by all classed the inherit IMyInterface
        void MethodB();
    }
}

//Define Extension methods for IMyInterface
namespace Extensions
{
    using System;
    using DefineIMyInterface;

    // Methods can be accessed by instances of any class that inherits form IMyInterface
    public static class Extension
    {
        public static void MethodA(this IMyInterface myInterface, int i)
        {
            Console.WriteLine("Extension MethodA(this IMyInterface, int i)");
        }

        public static void MethodA(this IMyInterface myInterface, string s)
        {
            Console.WriteLine("Extension MethodA(this IMyInterface interface, string s)");
        }

        // This method is never called because the classes we define below
        // implements their own MethodB method.
        public static void MethodB(this IMyInterface myInterface)
        {
            Console.WriteLine("Etension MethodB(this IMyInterface interface)");
        }
    }
}

namespace ExtensionMethodsDemo
{
    using System;
    using Extensions;
    using DefineIMyInterface;

    class A : IMyInterface
    {
        public void MethodB() { Console.WriteLine("A.MethodB()"); }
    }

    class B : IMyInterface
    {
        public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
        public void MethodB() { Console.WriteLine("B.MethodB()"); }
    }

    class C : IMyInterface
    {
        public void MethodA(object obj) { Console.WriteLine("C.MethodA(object obj)"); }
        public void MethodB() { Console.WriteLine("C.MethodB()"); }
    }
}