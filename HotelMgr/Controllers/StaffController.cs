namespace HotelMgr.Controllers
{
    public class StaffController : AccountController
    {
        public PriceController PriceCtrl { get;}
        public RecordController RecordCtrl { get;  }
        public RoomController RoomCtrl { get; }
        public ClientController ClientCtrl { get; }

        public StaffController() : base(true)
        {
            PriceCtrl = new PriceController(ref Context);
            RecordCtrl = new RecordController(ref Context);
            RoomCtrl = new RoomController(ref Context);
            ClientCtrl = new ClientController();
        }

        public override void Login(string username, string password)
        {
            var staff = Context.Staff.Find(username);
            if (staff != null) Login(staff.Id);
        }

        public override void Cancel()
        {
            base.Cancel();
        }

        public override void Edit()
        {
            base.Edit();
        }

        public override void Logout()
        {
            base.Logout();
        }

        public override void Register()
        {
            base.Register();
        }

        public override void CreateLog(string operation)
        {
            throw new System.NotImplementedException();
        }

        public void Manage()
        {
            
        }

    }
}
