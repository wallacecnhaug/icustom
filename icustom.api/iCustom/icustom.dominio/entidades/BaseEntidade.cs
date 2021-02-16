using icustom.dominio.contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.dominio.entidades
{
    public abstract class BaseEntidade : IBaseEntidade
    {
        public int Id { get; set; }
    }
}
