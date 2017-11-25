using HotelMgr.Data;
using HotelMgr.Serivces;
using System;

namespace HotelMgr.Controllers
{
    public class RoomController : ILog
    {
        private ApplicationDbContext Context { get; }

        public RoomController(ref ApplicationDbContext context)
        {
            Context = context;
        }

        public void CreateLog(string operation)
        {
            throw new NotImplementedException();
        }
    }
}
