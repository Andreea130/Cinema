using Cinema.Contexts;
using Cinema.Entities;

namespace Cinema.Services.Repositories
{
    public class ReviewsRepository : Repository<Reviews>, IReviewsRepository
    {
        private readonly MovieContext _context;

        public ReviewsRepository(MovieContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}