using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eResturauntSystem.Entites
{
    public class Items
    {
        [Key]
        public Int32 ItemID { get; set; }
        public string Description { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal CurrentCost { get; set; }
        public bool Active { get; set; }
        public Int32? Callories { get; set; }
        public string Comments { get; set; }
        public Int32 MenuCategoryID { get; set; }

        //nav
        public virtual MenuCategories MenuCategories { get; set; }
    }
}
