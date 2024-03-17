namespace DataLeyer.MyDbContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDb : DbContext
    {
        public MyDb()
            : base("data source = TOOT\\SQL2014; initial catalog = intern2; integrated security = True; MultipleActiveResultSets=True;App=EntityFramework providerName=System.Data.SqlClient")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
