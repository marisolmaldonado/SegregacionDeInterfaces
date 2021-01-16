using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces.Refactorizacion
{
    interface IImpuestos
    {
        double PagoImpuestoRenta(int año);
        double PagoImpuestoPredial(int año, Propiedad propiedad);
        double PagoImpuestoVerde(int año, Vehiculo vehiculo);
    }
}
