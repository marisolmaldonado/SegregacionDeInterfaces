using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces.Refactorizacion
{
    interface IDatosPersonales
    {
        string cedula { set; get; }
        string Nombre { set; get; }
        string Nacionalidad { set; get; }
        string Genero { set; get; }
        string OrientacionSexual { set; get; }
        string IdentidadCultural { set; get; }
    }
}
