using System.Collections.Generic;

namespace Geek.Models
{
    public class Courses
    {
        public Courses()
        {
            this.RelatedUsers = new HashSet<ApplicationUser>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int NumberGeeksUser { get; set; }

        public float Price { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ApplicationUser> RelatedUsers { get; set; }
    }
}