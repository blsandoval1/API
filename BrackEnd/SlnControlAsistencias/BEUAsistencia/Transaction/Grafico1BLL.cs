using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUAsistencia.Transaction
{
    public class Grafico1BLL
    {
        public static List<ReportePromedio1_Result> Get(int? asistencias)
        {
            Entities db = new Entities();
            return db.ReportePromedio1(asistencias).ToList();

        }

    }
}

