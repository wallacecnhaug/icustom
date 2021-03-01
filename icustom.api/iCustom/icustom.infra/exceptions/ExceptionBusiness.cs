using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace icustom.infra.exceptions
{
    public class ExceptionBusiness : Exception
    {
        private string _mensagemErro = "";

        public ExceptionBusiness()
        {

        }

        protected void GerarLog(string mensagem)
        {
            //Utilizar recursos avançados de log - Log4Net - Elastic - etc...
            Debug.WriteLine(mensagem);
        }

        public ExceptionBusiness(string mensagemErro)
        {
            this.GerarLog(mensagemErro);
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
