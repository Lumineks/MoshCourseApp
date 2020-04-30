using MoshCourseApp.Models;
using System.Collections.Generic;

namespace MoshCourseApp.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}
