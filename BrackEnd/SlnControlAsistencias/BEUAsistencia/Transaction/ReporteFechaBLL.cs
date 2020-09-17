using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUAsistencia.Transaction
{
    public class ReporteFechaBLL
    {
        public static List<ReporteFechas_Result> Get(DateTime fechaIng, DateTime fechaSal)
        {
            Entities db = new Entities();
            return db.ReporteFechas(fechaIng, fechaSal).ToList();

        }

    }
}

