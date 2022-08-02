using AutoMapper;

namespace Cinema.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Entities.Reviews, ExternalModels.ReviewsDTO>();
            CreateMap<ExternalModels.ReviewsDTO, Entities.Reviews>();

            CreateMap<Entities.Movie, ExternalModels.MovieDTO>();
            CreateMap<ExternalModels.MovieDTO, Entities.Movie>();
        }
    }
}