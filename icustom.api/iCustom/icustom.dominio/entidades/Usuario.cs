using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.dominio.entidades
{
    public class Usuario : BaseEntidade
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
