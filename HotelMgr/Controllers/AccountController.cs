using HotelMgr.Data;
using HotelMgr.Serivces;
using System;
using System.Collections.Generic;

namespace HotelMgr.Controllers
{
    public abstract class AccountController : ILog, IQuery, IAdjust
    {
        protected Guid Id;
        protected bool IsStaff { get; }
        protected OrderController OrderCtrl { get; set; }
        protected ApplicationDbContext Context;

        protected AccountController(bool isStaff)
        {
            IsStaff = isStaff;
            Context = new ApplicationDbContext("");
            OrderCtrl = new OrderController(ref Id, ref Context);
        }
        protected void Login(Guid accountId)
        {

        }

        public abstract void Login(string username, string password);

        public virtual void Logout()
        {

        }

        public abstract void Add(object obj);
        public abstract void Drop(Guid id);
        public abstract void Adjust(Guid id, object obj);
        public abstract void CreateLog(string operation);
        public abstract IEnumerable<object> Query(object obj);

        public OrderController OrderController
        {
            get => default(OrderController);
            set
            {
            }
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get => default(ApplicationDbContext);
            set
            {
            }
        }
    }
}
