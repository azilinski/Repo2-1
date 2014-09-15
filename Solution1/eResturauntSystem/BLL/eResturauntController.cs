using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region AdditionalNamespaces
using eResturauntSystem.Entites;
using eResturauntSystem.DAL;
using System.ComponentModel;
#endregion

namespace eResturauntSystem.BLL
{
    [DataObject]
    public class eResturauntController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<SpecialEvents> SpecialEvent_List()
        {
            //interfacing with our Context Class 
            using (eResturauntContext context = new eResturauntContext())
            {
                return context.SpecialEvents.ToList();
            }
        }
    }
}
