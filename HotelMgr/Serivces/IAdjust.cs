using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMgr.Serivces
{
    internal interface IAdjust
    {
        void Add(object obj);
        void Drop(Guid id);
        void Adjust(Guid id, object obj);
    }
}
