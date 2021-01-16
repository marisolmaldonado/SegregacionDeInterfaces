using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces
{
    class AdultoMayor : ICiuadano
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

        public string Afiliar(PartidoPolitico partidoPolitico)
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

        public double PagoAgua(DateTime fecha, Propiedad propiedad)
        {
            throw new NotImplementedException();
        }

        public double PagoImpuestoPredial(int año, Propiedad propiedad)
        {
            throw new NotImplementedException();
        }

        public double PagoImpuestoRenta(int año)
        {
            throw new NotImplementedException();
        }

        public double PagoImpuestoVerde(int año, Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public double PagoLuz(DateTime fecha, Propiedad propiedad)
        {
            throw new NotImplementedException();
        }

        public string Postular(Candidatura candidatura)
        {
            throw new NotImplementedException();
        }

        public string sufragar(Votacion votacion)
        {
            throw new NotImplementedException();
        }
    }
}
