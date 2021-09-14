using BuilderPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new CFDIConcreteBuilder();
            var director = new DirectorCFDI(builder);
            director.CrearFactura(new CFDIDTO());
            
            var cfdi = builder.GetCFDI();
            cfdi.Validar();
            cfdi.Timbrar();
            cfdi.Conciliar();

            director.CrearRecibo();

            cfdi = builder.GetCFDI();
            cfdi.Validar();
            cfdi.Timbrar();
            cfdi.Conciliar();
        }
    }
}
