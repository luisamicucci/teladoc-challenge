using System.ComponentModel.DataAnnotations;

namespace Teladoc.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
