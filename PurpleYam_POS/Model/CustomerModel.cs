using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleYam_POS.Model
{
   public class CustomerModel
    {
        public int Id { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string ContactNo { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public byte[] Image { get; set; }

       
        public string Fullname
        {
            get { return $"{Lastname.ToUpper()}, {Firstname.ToUpper()} {Middlename.ToUpper()} "; }
        }

       
    }
}
