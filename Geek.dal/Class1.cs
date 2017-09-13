using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek.dal
{
    public enum CourseState
    {
        open,
        close,
        inProcess
    }

    public class GeekCourse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int NumberOfGeekUsers { get; set; }
        public string Image { get; set; }
        public CourseState State { get; set; }

        public ICollection<User> MyProperty { get; set; }
    }
}
