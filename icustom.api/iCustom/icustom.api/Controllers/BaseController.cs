using icustom.infra.exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace icustom.app.api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BaseController : ControllerBase
    {
        protected ActionResult TratarErro(Exception ex)
        {
            ActionResult erroTratado = null;

            erroTratado = BadRequest(ex.Message);

            if(ex is NaoEncontradoExceptionBusiness)
                erroTratado = NotFound(ex.Message + ex.InnerException?.Message);

            return erroTratado;
        }
    }
}
