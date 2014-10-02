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
        #region Special Events
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<SpecialEvent> SpecialEvent_List()
        {
            //interfacing with our Context Class 
            using (eResturauntContext context = new eResturauntContext())
            {
                //using Context DBSet to get Entity Data
                //return context.SpecialEvents.ToList();

                //get a list of instancesfor entity using LINQ
                var results= from item in context.SpecialEvents select item;
                return results.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public SpecialEvent SpecialEventByEventCode(string eventcode)
        {
            using(eResturauntContext context = new eResturauntContext())
            {
                return context.SpecialEvents.Find(eventcode);
            }
        }
        [DataObjectMethod(DataObjectMethodType.Insert,false)]
        public void SpecialEvents_Add(SpecialEvent item)
        {
            using(eResturauntContext context = new eResturauntContext())
            {
            SpecialEvent added = null;
            added = context.SpecialEvents.Add(item);
            // commits the add to the database
            // evaluates the anotations(validations) on your entity
            //[Required],[StringLength],[Range]...
            context.SaveChanges(); 
            }                
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void SpecialEvents_Update(SpecialEvent item)
        { 
            using(eResturauntContext context = new eResturauntContext())
            {
                context.Entry<SpecialEvent>(context.SpecialEvents.Attach(item)).State
                    = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete,false)]
        public void SpecialEvents_Delete(SpecialEvent item)
        {
            using(eResturauntContext context = new eResturauntContext())
            {
                SpecialEvent existing = context.SpecialEvents.Find(item.EventCode);
                context.SpecialEvents.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Reservations
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Reservation> Reservation_List()
        {
            //interfacing with our Context Class 
            using (eResturauntContext context = new eResturauntContext())
            {
                return context.Reservations.ToList();
            }
        }
        
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Reservation> ReservationbyEvent(string eventcode)
        {
            using(eResturauntContext context = new eResturauntContext())
            {
                return context.Reservations.Where(anItem => anItem.EventCode == eventcode).ToList();
            }
        }
        #endregion
        #region Waiter
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Waiter> Waiter_List()
        {
            using(eResturauntContext context= new eResturauntContext())
            {
               return context.Waiters.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public Waiter WaiterByWaiterID(int waiterID)
        {
            using(eResturauntContext context = new eResturauntContext())
            {
                return context.Waiters.Find(waiterID);
            }
        }
        [DataObjectMethod(DataObjectMethodType.Insert,false)]
        public void Waiter_Add(Waiter item)
        {
            using(eResturauntContext context = new eResturauntContext())
            {
                Waiter added = null;
                added = context.Waiters.Add(item);
                context.SaveChanges();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Update,false)]
        public void Waiter_Update(Waiter item)
        {
            using (eResturauntContext context = new eResturauntContext()){
                context.Entry<Waiter>(context.Waiters.Attach(item)).State
                    = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete,false)]
        public void Waiter_Delete(Waiter item)
        {
            using (eResturauntContext context = new eResturauntContext())
            {
                Waiter existing = context.Waiters.Find(item.WaiterID);
                context.Waiters.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
    }
}
