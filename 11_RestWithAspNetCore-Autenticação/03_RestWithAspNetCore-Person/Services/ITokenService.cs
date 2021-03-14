using System.Collections.Generic;
using System.Security.Claims;

namespace _03_RestWithAspNetCore_Person.Services
{
    public interface ITokenService
    {
        string GenerateAcessToken(IEnumerable<Claim> claims);

        string GenerateRefreshToken();

        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
