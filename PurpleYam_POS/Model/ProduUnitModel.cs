using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PurpleYam_POS.helper;
namespace PurpleYam_POS.Model
{
    class ProduUnitModel:IProductUnit
    {
        public int Id { get; set; }
        [Duplicate(query = "")]
        public string BaseUnit { get; set; }
        public string DefaultUnit { get; set; }
        public string DisplayUnit { get; set; }
        public decimal Qty { get; set; }
    }
}
