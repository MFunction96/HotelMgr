using HotelMgr.Data;
using HotelMgr.Serivces;
using System;
using System.Collections.Generic;

namespace HotelMgr.Controllers
{
    public class RecordController : ILog, IQuery, IAdjust
    {
        private ApplicationDbContext Context { get; }
        private Guid Id { get; }

        public RecordController(ref Guid id, ref ApplicationDbContext context)
        {
            Context = context;
            Id = id;
        }

        public void Backup()
        {
            
        }

        public void Recovery()
        {
            
        }

        public void Analyze()
        {
            
        }

        public void Adjust(Guid id, object obj)
        {
            throw new NotImplementedException();
        }

        public void Add(object obj)
        {

        }

        public void Drop(Guid recordGuid)
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
    }
}
