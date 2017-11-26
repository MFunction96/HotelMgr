using System;
using System.Collections.Generic;

namespace HotelMgr.Controllers
{
    public class StaffController : AccountController
    {
        public PriceController PriceCtrl { get; }
        public RecordController RecordCtrl { get; }
        public RoomController RoomCtrl { get; }
        public CustomerController CustomerCtrl { get; }

        public StaffController() : base(true)
        {
            PriceCtrl = new PriceController(ref Id, ref Context);
            RecordCtrl = new RecordController(ref Id, ref Context);
            RoomCtrl = new RoomController(ref Id, ref Context);
            CustomerCtrl = new CustomerController();
        }

        public override void Login(string username, string password)
        {
            var staff = Context.Staff.Find(username);
            if (staff != null) Login(staff.Id);
        }

        public override IEnumerable<object> Query(object account)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

    }
}
