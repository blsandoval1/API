using BEUAsistencia;
using BEUAsistencia.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace WebApiEmpleado.Controllers
{

    [AllowAnonymous]
    [RoutePrefix("api")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class Grafico1Controller : ApiController
    {
        [Route("grafico1")]
        [ResponseType(typeof(ReportePromedio1_Result))]
        public IHttpActionResult GetGraficos(int asistencias)
        {
            List<ReportePromedio1_Result> empleado = Grafico1BLL.Get(asistencias);

            return Content(HttpStatusCode.OK, empleado);
        }
    }
}
