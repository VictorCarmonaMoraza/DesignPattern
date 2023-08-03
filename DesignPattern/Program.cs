using System;

namespace DesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var singleton  =  Singleton.Singleton.Instance;
            var log = Singleton.Log.Log_instance;
            log.Save("hola");
            log.Save("adios");

            var a = Singleton.Log.Log_instance;
            var b = Singleton.Log.Log_instance;

            Console.WriteLine(a == b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
