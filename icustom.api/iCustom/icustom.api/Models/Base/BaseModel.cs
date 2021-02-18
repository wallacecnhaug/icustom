using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace icustom.api.Models.Base
{
    public abstract class BaseModel : IBaseModel
    {
        public abstract bool Valido();
    }
}
