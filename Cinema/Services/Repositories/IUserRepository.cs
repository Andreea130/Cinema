using Cinema.Entities;

namespace Cinema.Services.Repositories
{
    public interface IUserRepository : IRepository<Users>
    {
        IEnumerable<Users> GetUsers();
    }
}
