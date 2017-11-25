using HotelMgr.Models;
using System.Data.Entity;
using System.Data.Linq;

namespace HotelMgr.Data
{
    public class ApplicationDbContext : DataContext
    {
        public DbSet<ClientModel> Client { get; set; }
        public DbSet<OrderModel> Order { get; set; }
        public DbSet<PriceModel> Price { get; set; }
        public DbSet<RecordModel> Record { get; set; }
        public DbSet<RoomModel> Room { get; set; }
        public DbSet<StaffModel> Staff { get; set; }
        public ApplicationDbContext(string fileOrServerOrConnection) 
            : base(fileOrServerOrConnection)
        {
            
        }
    }
}
