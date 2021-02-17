using icustom.infra.configs;
using icustom.servico.contrato;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace icustom.servico
{
    public class AutenticacaoServico : BaseServico, IAutenticacaoServico
    {
        public string GerarToken()
        {
            var securityKey = new SymmetricSecurityKey(Constantes.Key);
            var issuer = Constantes.Issuer;
            var audience = Constantes.Audience;
            var credentials =
                new SigningCredentials(
                    securityKey,
                    SecurityAlgorithms.HmacSha256);

            var token =
                new JwtSecurityToken(
                    issuer: issuer,
                    audience: audience,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials);

            var tokenHandler = new JwtSecurityTokenHandler();
            var stringToken = tokenHandler.WriteToken(token);

            return stringToken;
        }
    }
}
