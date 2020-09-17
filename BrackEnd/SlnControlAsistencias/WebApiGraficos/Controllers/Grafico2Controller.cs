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

namespace WebApiGraficos.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api")]
    [EnableCors(origins: "http://localhost:4201/", headers: "", methods: "")]
    public class Grafico2Controller : ApiController
    {


            [Route("grafico2")]
            [ResponseType(typeof(ReportePromedio2_Result))]
            public IHttpActionResult GetGraficos(int informes)
            {
                List<ReportePromedio2_Result> empleado = Grafico2BLL.Get(informes);

                if (empleado == null)
                {
                    return Content(HttpStatusCode.OK, empleado);
                }
                return Content(HttpStatusCode.OK, empleado);
            }

        

    }
}
