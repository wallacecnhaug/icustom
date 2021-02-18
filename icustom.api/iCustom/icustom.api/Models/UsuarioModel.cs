using icustom.api.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace icustom.api.Models
{
    public class UsuarioModel : BaseModel
    {
        public string login { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }

        public override bool Valido()
        {
            return (!string.IsNullOrEmpty(login));
        }
    }
}
