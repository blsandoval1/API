using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using BEUAsistencia;
using BEUAsistencia.Transaction;


namespace WebApiEmpleado.Controllers
{

    [AllowAnonymous]
    [RoutePrefix("api")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReporteFechaController : ApiController
    {

        [Route("grafico3")]
        [ResponseType(typeof(ReporteFechas_Result))]
        public IHttpActionResult GetGraficos(DateTime fechaIng, DateTime fechaSal)
        {
            List<ReporteFechas_Result> fechas = ReporteFechaBLL.Get(fechaIng, fechaSal);

            return Content(HttpStatusCode.OK, fechas);
        }

    }
}
