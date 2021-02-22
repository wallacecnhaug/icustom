using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.infra.exceptions
{
    public class ExceptionBusiness : Exception
    {
        private string _mensagemErro = "";

        public ExceptionBusiness()
        {

        }

        public ExceptionBusiness(string mensagemErro)
        {
            this._mensagemErro = (!string.IsNullOrEmpty(mensagemErro) ? $"Erro tratado: {mensagemErro} -> Exception.Message: " : "");
        }

        public override string Message
        {
            get
            {
                return $"{this._mensagemErro}{base.Message}";
            }
        }
    }
}
