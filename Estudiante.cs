using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces.Refactorizacion
{
    class Estudiante : IDatosPersonales, IDerechosDeberes
    {
        public string cedula { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nacionalidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Genero { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OrientacionSexual { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IdentidadCultural { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string AcatarLaLey(string ley)
        {
            throw new NotImplementedException();
        }

        public string CumplirDerechos(string deber)
        {
            throw new NotImplementedException();
        }

        public string ExigirDerechos(string derechos)
        {
            throw new NotImplementedException();
        }

        public string ExpresarOpinion(string opinion)
        {
            throw new NotImplementedException();
        }
    }
}
