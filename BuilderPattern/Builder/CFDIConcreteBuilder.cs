using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public class CFDIConcreteBuilder : IBuilderCFDI
    {
        private CFDI _cfdi;

        public CFDIConcreteBuilder()
        {
            _cfdi = new CFDI();
        }

        public void Reset()
        {
            _cfdi = new CFDI();
        }

        public void SetFecha(DateTime fecha) => _cfdi.Fecha = fecha;

        public void SetNombreEmisor(string nombreEmisor) => _cfdi.NombreEmisor = nombreEmisor;

        public void SetNombreReceptor(string nombreReceptor) => _cfdi.NombreRecpetor = nombreReceptor;

        public void SetRfcEmisor(string rfcEmisor) => _cfdi.RfcEmisor = rfcEmisor;

        public void SetRfcReceptor(string rfcReceptor) => _cfdi.RfcReceptor = rfcReceptor;

        public CFDI GetCFDI() => _cfdi;
    }
}
