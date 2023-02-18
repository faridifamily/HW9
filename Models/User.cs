using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HW9.Models
{
    public class User
    {
        public int Id { get; set; }


        [Display(Name = "First Name")]
        public string Name { get; set; }


        [Display(Name = "Last Name")]
        public string Family { get; set; }


        [Display(Name = "Email Address")]
        public string Email { get; set; }


        [Display(Name = "Password")]
        public string Password { get; set; }

    }
}
