using System.ComponentModel.DataAnnotations;

namespace MoshCourseApp.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [StringLength(24)]
        public string Name { get; set; }
    }
}
