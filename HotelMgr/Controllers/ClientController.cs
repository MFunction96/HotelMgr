using System;

namespace HotelMgr.Controllers
{
    public class ClientController : AccountController
    {
        public ClientController() : base(false)
        {

        }

        public override void Cancel()
        {
            base.Cancel();
        }

        public override void Edit()
        {
            base.Edit();
        }

        public override void Login(string username, string password)
        {
            var client = Context.Client.Find(username);
            if (client != null) Login(client.Id);
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
            throw new NotImplementedException();
        }
    }
}
