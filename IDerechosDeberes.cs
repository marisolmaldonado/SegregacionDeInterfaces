using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces.Refactorizacion
{
    interface IDerechosDeberes
    {
        string ExigirDerechos(string derechos);
        string CumplirDerechos(string deber);
        string AcatarLaLey(string ley);
        string ExpresarOpinion(string opinion);
    }
}
