using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Singleton
    {
        //Hacemos referencia del constructor privado
        private readonly static Singleton _instance = new Singleton();

        //
        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

        private Singleton() { }
    }
}
