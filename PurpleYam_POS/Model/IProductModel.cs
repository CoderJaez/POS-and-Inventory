using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PurpleYam_POS.Model
{
    interface IProductModel
    {
        int Id { get; set; }
        string Product { get; set; }
        string CreatedAt { get; set; }
        string UpdatedAt { get; set; }
        bool Deleted { get; set; }

    }
}
