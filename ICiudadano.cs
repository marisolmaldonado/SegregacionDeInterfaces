using System;

namespace SegregacionDeInterfaces
{
    public interface ICiuadano
    {
        string cedula{ set; get; }
        string Nombre { set; get; }
        string Nacionalidad { set; get; }
        string Genero { set; get; }
        string OrientacionSexual { set; get; }
        string IdentidadCultural { set; get; }
        double PagoImpuestoRenta(int año);
        double PagoImpuestoPredial(int año, Propiedad propiedad);
        double PagoImpuestoVerde(int año, Vehiculo vehiculo);
        double PagoLuz(DateTime fecha, Propiedad propiedad);
        double PagoAgua(DateTime fecha, Propiedad propiedad);
        string ExigirDerechos(string derechos);
        string CumplirDerechos(string deber);
        string AcatarLaLey(string ley);
        string ExpresarOpinion(string opinion);
        string sufragar(Votacion votacion);
        string Postular(Candidatura candidatura);
        string Afiliar(PartidoPolitico partidoPolitico);

    }
}
