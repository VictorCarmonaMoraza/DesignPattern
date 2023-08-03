using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Log
    {
        private readonly static Log _instance = new Log();

        private string _path = "log.txt";

        //Recuperamos la propiedad 
        public static Log Log_instance
        {
            get
            {
                return _instance;
            }
        }

        //Constructor privado
        private Log() { }   

        /// <summary>
        /// Escribimos en un archivo
        /// </summary>
        /// <param name="message">mensaje a escribir</param>
        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
