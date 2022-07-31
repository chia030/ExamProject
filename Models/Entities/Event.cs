using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace cbsStudents.Models.Entities
{
    public class Event
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "Please fill out title")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters")]
        public string Title { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }
        
        [Required]
        [MinLength(10)]
        public string Location { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}