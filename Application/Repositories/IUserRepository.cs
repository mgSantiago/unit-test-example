using UnitTestExample.Entities;

namespace UnitTestExample.Repositories
{
    public interface IUserRepository
    {
        Task Add(User user);
        Task Update(User user);
        Task Delete(User user);
        Task<User> FindById(int id);
    }
}
