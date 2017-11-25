using HotelMgr.Data;
using HotelMgr.Models;
using HotelMgr.Serivces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelMgr.Controllers
{
    public class PriceController : ILog
    {
        private ApplicationDbContext Context { get; }

        public PriceController(ref ApplicationDbContext context)
        {
            Context = context;
        }

        public IEnumerable<PriceModel> Query(PriceModel price)
        {
            var tmp = from prices in Context.Price where prices.Id == price.Id select prices;
            return tmp;
        }

        public void CreateLog(string operation)
        {
            throw new NotImplementedException();
        }
    }
}
