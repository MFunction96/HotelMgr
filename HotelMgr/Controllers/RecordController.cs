using HotelMgr.Data;
using HotelMgr.Serivces;
using System;

namespace HotelMgr.Controllers
{
    public class RecordController :ILog
    {
        private ApplicationDbContext Context { get; }

        public RecordController(ref ApplicationDbContext context)
        {
            Context = context;
        }

        public void CreateLog(string operation)
        {
            throw new NotImplementedException();
        }
    }
}
