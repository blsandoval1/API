using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUAsistencia.Transaction
{
    public class ReporteBLL
    {
        public static List<Reporte_Result> Get(int? asistencias)
        {
            Entities db = new Entities();
            return db.Reporte(asistencias).ToList();

        }

    }
}

