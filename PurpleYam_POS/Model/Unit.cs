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
    public class Unit : IUnit
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "UnitCode is required")]
        [Duplicate(table = "tbl_unit",column ="UnitCode")]
        public string UnitCode { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Unit description is required")]
        public string UnitDesc { get; set; }

    }
}
