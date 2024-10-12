using System.ComponentModel.DataAnnotations;
namespace TermProject.Models
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class Subscribers
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30,ErrorMessage = "Please enter your full name.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Please enter your full name.")]
        public string LastName { get; set; }

        public Gender? GenderIdentity { get; set; }
        [StringLength(50, ErrorMessage = "Please enter a valid address.")]
        public string? Address { get; set; }

        [StringLength(30, ErrorMessage = "Please enter a valid city.")]
        public string? City { get; set; }
        [StringLength(2, ErrorMessage ="Please enter an abbreviated state.")]
        public string? State { get; set; }

        [StringLength(10, ErrorMessage ="Please enter a valid zip code.")]
        public string? Zip {  get; set; }

        public string? email {  get; set; }
        public string? phoneNumber { get; set; }

    }
}
