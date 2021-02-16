using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.contexto.contratos
{
    public interface IContexto
    {
        DbContext GetContexto();
    }
}
