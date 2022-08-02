using Cinema.Services.Repositories;

namespace CinemaWebApi.Services.UnitsOfWork
{
    public interface IMovieUnitOfWork : IDisposable
    {
        IMovieRepository Movie { get; }
        IReviewsRepository Reviews { get; }

        int Complete();
    }
}