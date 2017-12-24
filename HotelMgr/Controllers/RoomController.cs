using HotelMgr.Data;
using HotelMgr.Models;
using HotelMgr.Serivces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelMgr.Controllers
{
    public class RoomController : ILog, IQuery, IAdjust
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

        public RoomController(ref Guid id, ref ApplicationDbContext context)
        {
            Context = context;
            Id = id;
        }

        public void Lock(Guid roomGuid)
        {

        }

        public void Unlock(Guid roomGuid)
        {

        }

        public void MoveIn()
        {

        }

        public void MoveOut()
        {

        }

        public void CreateLog(string operation)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> Query(object price)
        {
            var model = price as PriceModel;
            var tmp = from rooms in Context.Room where rooms.Id == model.Id select rooms;
            return tmp;
        }

        public void Adjust(Guid id, object obj)
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
    }
}
