using Cinema.Contexts;
using Cinema.Entities;


namespace Cinema.Services.Repositories
{
    public class UserRepository : Repository<Users>, IUserRepository
    {
        private readonly MovieContext _context;

        public UserRepository(MovieContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Users> GetUsers()
        {
            return _context.Users
                .Where(u => u.Delete == false || u.Delete == null)
                .ToList();
        }
    }
}
