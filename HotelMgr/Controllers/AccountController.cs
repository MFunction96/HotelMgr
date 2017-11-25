using HotelMgr.Data;
using System;
using HotelMgr.Serivces;

namespace HotelMgr.Controllers
{
    public abstract class AccountController : ILog
    {
        protected Guid Id { get; set; }
        protected bool IsStaff { get; }
        protected OrderController OrderCtrl { get; set; }
        protected ApplicationDbContext Context;

        protected AccountController(bool isStaff)
        {
            IsStaff = isStaff;
            Context = new ApplicationDbContext("");
            OrderCtrl = new OrderController(ref Context);
        }
        protected void Login(Guid id)
        {
            
        }

        public abstract void Login(string username, string password);

        public virtual void Logout()
        {
            
        }

        public virtual void Edit()
        {
            
        }

        public virtual void Cancel()
        {
            
        }

        public virtual void Register()
        {
            
        }

        public abstract void CreateLog(string operation);
    }
}
