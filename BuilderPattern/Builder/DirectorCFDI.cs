using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    class DirectorCFDI
    {
        private IBuilderCFDI _builder;

        public DirectorCFDI(IBuilderCFDI builder)
        {
            _builder = builder;
        }

        public void CrearFactura(CFDIDTO cfdi)
        {
            _builder.Reset();
            _builder.SetRfcEmisor("sadfaa3435");
            _builder.SetRfcReceptor("adfasfdas1");
            _builder.SetNombreEmisor("asdfas");
            _builder.SetNombreReceptor("ddfggdfgd");
        }

        public void CrearRecibo()
        {
            _builder.Reset();
            _builder.SetRfcEmisor("sadfaa3435");
            _builder.SetRfcReceptor("adfasfdas1");
            _builder.SetNombreEmisor("asdfas");
            _builder.SetNombreReceptor("ddfggdfgd");
        }
    }
}
