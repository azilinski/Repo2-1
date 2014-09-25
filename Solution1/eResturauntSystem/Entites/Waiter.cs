using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eResturauntSystem.Entites
{
    public class Waiter
    {
        [Key]
        public int WaiterID { get; set; }
        [Required(ErrorMessage = "First Name is a required Field")]
        [StringLength(25, ErrorMessage = "First Name can be up to 25 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is a required Field")]
        [StringLength(35, ErrorMessage = "First Name can be up to 35 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone is a required Field")]
        [StringLength(15, ErrorMessage = "Phone can be up to 15 characters")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address is a required Field")]
        [StringLength(30, ErrorMessage = "Address can be up to 30 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Hired Date is a required Field")]
        public DateTime HireDate { get; set; }

        public DateTime ReleaseDate { get; set; }

        //TimeSpan
        //DayOfWeek
        //Compound keys [Column(Order=0),Key]
        //              [Column(Order=1),Key]

        //Navigation
        public virtual ICollection<Bill> Bills { get; set; }

    }
}
