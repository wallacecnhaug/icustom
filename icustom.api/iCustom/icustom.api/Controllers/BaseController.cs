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

            string msgErro = $"{ex.Message} {ex.InnerException?.Message}";

            erroTratado = BadRequest(msgErro);

            if(ex is NaoEncontradoExceptionBusiness)
                erroTratado = NotFound(msgErro);

            return erroTratado;
        }
    }
}
