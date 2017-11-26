using System;
using System.Collections.Generic;

namespace HotelMgr.Controllers
{
    public class CustomerController : AccountController
    {
        public CustomerController() : base(false)
        {

        }
        public override void Login(string username, string password)
        {
            var client = Context.Customer.Find(username);
            if (client != null) Login(client.Id);
        }

        public override void Logout()
        {
            base.Logout();
        }

        public override void Add(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Drop(Guid id)
        {
            throw new NotImplementedException();
        }

        public override void Adjust(Guid id, object obj)
        {
            throw new NotImplementedException();
        }

        public override void CreateLog(string operation)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<object> Query(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
