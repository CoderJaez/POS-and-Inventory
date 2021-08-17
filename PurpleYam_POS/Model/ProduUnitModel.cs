using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PurpleYam_POS.helper;
using Repository;

namespace PurpleYam_POS.Model
{
    public class ProduUnitModel
    {
        public int ProductId { get; set; }
        public int UnitID { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "Unit code is required!")]
        [DuplicateRawmatUnit]
        public string UnitCode { get; set; }
        public bool BaseUnit { get; set; }
        public bool DisplayUnit { get; set; }

        [Range(1,int.MaxValue,ErrorMessage = "The quantity field must not be empty")]
        public decimal Qty { get; set; }
    }
}
