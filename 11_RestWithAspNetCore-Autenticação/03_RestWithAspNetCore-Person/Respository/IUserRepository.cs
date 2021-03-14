using _03_RestWithAspNetCore_Person.Data.VO;
using _03_RestWithAspNetCore_Person.Model;

namespace _03_RestWithAspNetCore_Person.Respository
{
    public interface IUserRepository
    {
        User ValidationCredentials(UserVO user);
    }
}
