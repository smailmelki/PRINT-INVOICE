using System.Data.Entity;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
