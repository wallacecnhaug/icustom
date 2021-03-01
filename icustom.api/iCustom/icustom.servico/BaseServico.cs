using icustom.infra.exceptions;
using icustom.servico.contrato;
using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.servico
{
    public abstract class BaseServico : IBaseServico
    {
        public virtual void Dispose()
        {
            
        }

        protected ExceptionBusiness TratarErro(Exception ex)
        {
            return new ExceptionBusiness(ex.Message + ex.InnerException?.Message);
        }
    }
}
