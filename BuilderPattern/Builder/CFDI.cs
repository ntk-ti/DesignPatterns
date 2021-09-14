using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public class CFDI
    {
        public string RfcEmisor;
        public string NombreEmisor;
        public string RfcReceptor;
        public string NombreRecpetor;
        public DateTime Fecha;

        public CFDI()
        {

        }

        public void Validar()
        {
            Console.WriteLine("Validando...");
        }

        public void Timbrar()
        {
            Console.WriteLine("Timbrar...");
        }

        public void Conciliar()
        {
            Console.WriteLine("Conciliar...");
        }
    }
}
