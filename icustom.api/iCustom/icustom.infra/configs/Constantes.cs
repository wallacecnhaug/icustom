using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace icustom.infra.configs
{
    public class Constantes
    {
        public static string ChaveAutenticacao { get; set; }
        public static string Issuer { get; set; }
        public static string Audience { get; set; }
        public static byte[] Key
        {
            get
            {
                return Encoding.UTF8.GetBytes(ChaveAutenticacao);
            }
        }
        public static string CaminhoAplicacao = PlatformServices.Default.Application.ApplicationBasePath;
        public static string NomeAplicacao = PlatformServices.Default.Application.ApplicationName;
        public static string CaminhoXmlDoc = Path.Combine(CaminhoAplicacao, $"{NomeAplicacao}.xml");
    }
}
