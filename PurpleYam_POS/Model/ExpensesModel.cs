using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Repository;

namespace PurpleYam_POS.Model
{
    public class ExpensesModel
    {
        public int Id { get; set; }
        public int ExpenseId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public bool Deleted { get; set; }
    }
}
