using icustom.contexto.contratos;
using icustom.dominio.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace icustom.contexto.repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(iCustomContexto contexto) : base(contexto)
        {

        }
    }
}
