using DatingApp.API.Entities;

namespace DatingApp.API.Intefaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}