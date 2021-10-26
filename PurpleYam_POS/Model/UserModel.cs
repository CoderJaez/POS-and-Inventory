using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Repository;
namespace PurpleYam_POS.Model
{
   public class UserModel
    {
        public int Id { get; set; }
        [Required]
        [Duplicate(table = "tbl_user",column ="Username")]
        public string Username { get; set; }
        [Required]
        [MinLength(5,ErrorMessage = "Pasword must at least 5 characters or more.")]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password),ErrorMessage = "Confirm Password does not matched")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string AccessRoles { get; set; }

    }
}
