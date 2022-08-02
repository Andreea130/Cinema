namespace Cinema.ExternalModels
{
    public class MovieDTO
    {
        public Guid ID { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public int Lenght { get; set; }

        public string Genre { get; set; }

        public int Stars { get; set; }

        public int NrRivews { get; set; }

        public Guid ReviewsID { get; set; }

        public ReviewsDTO Reviews { get; set; }


    }
}
