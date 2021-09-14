using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public interface IBuilderCFDI
    {
        void Reset();
        void SetRfcEmisor(string rfcEmisor);
        void SetRfcReceptor(string rfcReceptor);
        void SetNombreEmisor(string nombreEmisor);
        void SetNombreReceptor(string nombreReceptor);
        void SetFecha(DateTime fecha);

    }
}
