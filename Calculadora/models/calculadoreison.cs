using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Calculadora.models
{
    internal class Calculadoreison
    {
        public static Logger Logger = LogManager.GetCurrentClassLogger();
        public int NumeroUno { get; set; }
        public int NumeroDos { get; set; }
        public double Suma()
        {
            return NumeroUno + NumeroDos;
        }
        public double Resta()
        {
            return NumeroUno - NumeroDos;
        }
        public double Multiplicacion()
        {
            return NumeroUno * NumeroDos;
        }
        public double Divide()
        {
            try
            {
                return NumeroUno / NumeroDos;
            }
            catch(Exception ex) 
            {
                Logger.Error(ex.Message);
            }
            return 0;
        }
        public double cuadrado()
        {
            return Math.Pow(NumeroUno, NumeroDos);
        }
        public double raiz()
        {
            return Math.Sqrt(NumeroUno);
        }
    }
}
