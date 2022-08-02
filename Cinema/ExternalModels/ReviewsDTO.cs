namespace Cinema.ExternalModels
{
    public class ReviewsDTO
    {
        public Guid ID { get; set; }

        public Guid TitleId { get; set; }

        public string Comment { get; set; }
    }
}
