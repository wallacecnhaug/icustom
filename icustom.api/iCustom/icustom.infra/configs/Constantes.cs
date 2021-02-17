using System;
using System.Collections.Generic;
using System.Text;

namespace icustom.infra.configs
{
    public class Constantes
    {
        public static string ChaveAutenticacao { get { return "chave restrita do icustom a ser obtida externamente"; } }
        public static byte[] key
        {
            get
            {
                return Encoding.UTF8.GetBytes(ChaveAutenticacao);
            }
        }
    }
}
