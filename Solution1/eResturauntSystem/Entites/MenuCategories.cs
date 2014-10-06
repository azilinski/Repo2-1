using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eResturauntSystem.Entites
{
    public class MenuCategories
    {
        [Key]
        public Int32 MenuCatrgoryID { get; set; }
        public string Desciption { get; set; }

        //nav
        public virtual ICollection<Items> Items { get; set; }
    }
}
