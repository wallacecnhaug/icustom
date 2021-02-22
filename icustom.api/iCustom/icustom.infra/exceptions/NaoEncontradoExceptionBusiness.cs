using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.infra.exceptions
{
    public class NaoEncontradoExceptionBusiness : ExceptionBusiness
    {
        public NaoEncontradoExceptionBusiness()
        {
        }

        public NaoEncontradoExceptionBusiness(string mensagemErro) : base(mensagemErro)
        {
        }
    }
}
