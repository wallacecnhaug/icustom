using icustom.infra.configs;
using icustom.servico.contrato;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace icustom.servico
{
    public class AutenticacaoServico : BaseServico, IAutenticacaoServico
    {

        public string GerarToken(string login)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject =
                    new System.Security.Claims.ClaimsIdentity(
                        new Claim[]
                            {
                                new Claim(ClaimTypes.Name, login)
                            }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials =
                    new SigningCredentials(
                        new SymmetricSecurityKey(Constantes.key),
                        SecurityAlgorithms.HmacSha256)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
