using HotelMgr.Data;
using HotelMgr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using HotelMgr.Serivces;

namespace HotelMgr.Controllers
{
    public class OrderController :ILog
    {
        private ApplicationDbContext Context { get; }

        public OrderController(ref ApplicationDbContext context)
        {
            Context = context;
        }
        public void Order(Guid roomGuid)
        {
            
        }

        public void Lock()
        {
            
        }

        public void Pay(Guid roomGuid, int payment)
        {
            
        }

        public void Cancel()
        {
            Finish();
        }

        public IEnumerable<RoomModel> Query(RoomModel room)
        {
            var tmp = from rooms in Context.Room where rooms.Id == room.Id select rooms;
            return tmp;
        }

        public void Verify(Guid roomGuid)
        {
            
        }

        public void Finish()
        {
            
        }

        public void CreateLog(string operation)
        {
            throw new NotImplementedException();
        }
    }
}
