using HotelMgr.Data;
using HotelMgr.Serivces;
using System;
using System.Collections.Generic;

namespace HotelMgr.Controllers
{
    public class PriceController : ILog, IQuery, IAdjust
    {
        private ApplicationDbContext Context { get; }
        private Guid Id { get; }

        public PriceController(ref Guid id, ref ApplicationDbContext context)
        {
            Context = context;
            Id = id;
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

        public void CreateLog(string operation)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> Query(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
