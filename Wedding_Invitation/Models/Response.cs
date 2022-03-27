using System.ComponentModel.DataAnnotations;

namespace Wedding_Invitation.Models
{
    public class Response
    {
        [Required(ErrorMessage = "Don't leave name empty !")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Don't leave lastname empty !")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Don't leave email empty !")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Don't leave phone number empty !")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select if you will come to wedding or not !")]
        public bool? WillComeToWedding { get; set; }
    }
}
