using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eResturauntSystem.Entites
{
    public class MenuCategory
    {
        [Key]
        public Int32 MenuCategoryID { get; set; }
        public string Description { get; set; }

        //nav
        public virtual ICollection<Items> Items { get; set; }
    }
}
