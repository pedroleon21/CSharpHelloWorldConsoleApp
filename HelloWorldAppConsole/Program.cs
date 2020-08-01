using System;

namespace HelloWorldAppConsole
{
    class Program
    {
        static void Main()
        {
            Mundo a = new Mundo("Hello World", 10);
            string g;
            Console.WriteLine($"{a.Valido()} , {a.Num} , {a.Resposta}");
            g = Console.ReadLine();
            Console.WriteLine(g); 
        }
    }
}
