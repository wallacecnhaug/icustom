using icustom.api.Models.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace icustom.api.Models
{
    public class LoginModel : BaseModel
    {
        [JsonRequired]
        public string email { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string senha { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string token { get; set; }

        public override bool Valido()
        {
            return (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(senha));
        }
    }
}
