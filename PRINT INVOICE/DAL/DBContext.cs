using System.Data.Entity;
using System.Data.Entity.Migrations;
namespace PRINT_INVOICE.DAL
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<Invoice_Det> Invoice_Det { get; set; }
        public virtual DbSet<Invoice_Header> Invoice_Header { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<CustAndVend> CustAndVends { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MyDbInitializer());
        }
    }

    public class MyDbInitializer : CreateDatabaseIfNotExists<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            context.Users.AddOrUpdate(new User { ID = 1, Name = "Admin", Password = "Admin", Username = "Admin", Roles = 0 });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
