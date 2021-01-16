using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces.Refactorizacion
{
    interface IElectoral
    {
        string sufragar(Votacion votacion);
        string Postular(Candidatura candidatura);
        string Afiliar(PartidoPolitico partidoPolitico);
    }
}
