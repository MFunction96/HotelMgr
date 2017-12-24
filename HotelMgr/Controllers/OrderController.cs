using HotelMgr.Data;
using HotelMgr.Models;
using HotelMgr.Serivces;
using System;
using System.Collections.Generic;

namespace HotelMgr.Controllers
{
    public class OrderController : ILog, IQuery, IAdjust
    {
        private ApplicationDbContext Context { get; }
        private Guid Id { get; }

        public ApplicationDbContext ApplicationDbContext
        {
            get => default(ApplicationDbContext);
            set
            {
            }
        }

        public OrderController(ref Guid id, ref ApplicationDbContext context)
        {
            Context = context;
            Id = id;
        }

        public void Order(Guid roomGuid)
        {

        }

        public void Pay(Guid roomGuid, int payment)
        {

        }

        public void Renew(Guid orderGuid, OrderModel order)
        {

        }

        public void Cancel(Guid roomGuid)
        {
            Finish(roomGuid);
        }

        public void Verify(Guid roomGuid)
        {

        }

        public void Finish(Guid roomGuid)
        {

        }

        public void CreateLog(string operation)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> Query(object obj)
        {
            throw new NotImplementedException();
        }

        public void Add(object obj)
        {
            throw new NotImplementedException();
        }

        public void Drop(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Adjust(Guid id, object obj)
        {
            throw new NotImplementedException();
        }
    }
}
