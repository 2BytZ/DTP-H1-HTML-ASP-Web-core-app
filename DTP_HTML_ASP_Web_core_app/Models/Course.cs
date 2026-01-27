using System.ComponentModel.DataAnnotations;

namespace DTP_HTML_ASP_Web_core_app.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Teacher { get; set; }
        [Required]
        [Range(1, 312)]
        public int DurationInWeeks { get; set; }
    }

}
