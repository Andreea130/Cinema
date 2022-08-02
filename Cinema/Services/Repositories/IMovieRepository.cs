using Cinema.Entities;

namespace Cinema.Services.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Movie GetMovieDetalis(Guid movieId);
    }
}
