using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogErrores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Log oLog = new Log(@"C:\Users\diore\source\repos\LogErrores\LogErrores\");
            Log oLog = new Log(@"..\\..\\Logs");
            oLog.Add("Hola prueba ruta dinamica");
        }
    }
}
