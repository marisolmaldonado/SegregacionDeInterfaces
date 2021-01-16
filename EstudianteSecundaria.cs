using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionDeInterfaces
{
    class EstudianteSecundaria : Estudiante
    {
        public string Sufragar(Votacion votacion)
        {

            if (DateTime.Now.Subtract(FechaNacimiento).TotalDays < 16 * 365)
            {
                return "No puedo votar";
            }

            return base.sufragar(votacion);
        }

        public new double PagoImpuestoRenta(int año) {
            throw new Exception("Este metodo no puede ejecutarse");

        }


    }
}
