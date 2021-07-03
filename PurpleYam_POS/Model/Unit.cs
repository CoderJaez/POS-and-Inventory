using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PurpleYam_POS.helper;
namespace PurpleYam_POS.model
{
    public class Unit
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "UnitCode is required")]
        [Duplicate(table = "tbl_unit",column ="UnitCode")]
        public string UnitCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Unit description is required")]
        public string UnitDesc { get; set; }

    }
}
