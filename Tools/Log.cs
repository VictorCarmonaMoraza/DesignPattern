using System;
using System.IO;

namespace Tools
{
    //Para que no podamos heredar utilizamos la palabra sealed
    public sealed class Log
    {
        private static Log _instance = null;

        private string _path;

        private static object _protect = new object();

        public static Log GetInstance(string path)
        {
            //En caso de utilizar hilos protegemos la instancia para que no puedan haber dos al mismo tiempo
            lock (_protect)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }

            return _instance;
        }


        //Constructor privado
        private Log(string path)
        {
            _path = path;
        }

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
