using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace CustomerChat.Models
{
    public class Login {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]        
        [Display(Name = "Name")]
        public string UserNick { get; set; }
    }
}