namespace Geek.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdCourse { get; set; }
        public int Mark { get; set; }
    }
}