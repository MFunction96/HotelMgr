using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMgr.Serivces
{
    internal interface IQuery
    {
        IEnumerable<object> Query(object obj);
    }
}
