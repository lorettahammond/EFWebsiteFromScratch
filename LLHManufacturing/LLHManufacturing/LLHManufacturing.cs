namespace LLHManufacturing
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LLHManufacturing : DbContext
    {
        public LLHManufacturing()
            : base("name=LLHManufacturing")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<clientID> clientIDs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<PartLocation> PartLocations { get; set; }
        public virtual DbSet<PartNumber> PartNumbers { get; set; }
        public virtual DbSet<PartsMaterial> PartsMaterials { get; set; }
        public virtual DbSet<SalesPerson> SalesPersons { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Zipcode> Zipcodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.clientID)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.clientName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.clientAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.zipID)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.orderID)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.salesPersonID)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasOptional(e => e.Client1)
                .WithRequired(e => e.Client2);

            modelBuilder.Entity<clientID>()
                .Property(e => e.clientID1)
                .IsUnicode(false);

            modelBuilder.Entity<clientID>()
                .Property(e => e.clientName)
                .IsUnicode(false);

            modelBuilder.Entity<clientID>()
                .Property(e => e.clientAddress)
                .IsUnicode(false);

            modelBuilder.Entity<clientID>()
                .Property(e => e.zipID)
                .IsUnicode(false);

            modelBuilder.Entity<clientID>()
                .Property(e => e.orderID)
                .IsUnicode(false);

            modelBuilder.Entity<clientID>()
                .Property(e => e.salespersonID)
                .IsUnicode(false);

            modelBuilder.Entity<clientID>()
                .HasOptional(e => e.clientID11)
                .WithRequired(e => e.clientID2);

            modelBuilder.Entity<Order>()
                .Property(e => e.orderID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.partID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.statusID)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.clientID)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatu>()
                .Property(e => e.statusID)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatu>()
                .Property(e => e.statusName)
                .IsUnicode(false);

            modelBuilder.Entity<PartLocation>()
                .Property(e => e.locationsID)
                .IsUnicode(false);

            modelBuilder.Entity<PartLocation>()
                .Property(e => e.locationName)
                .IsUnicode(false);

            modelBuilder.Entity<PartNumber>()
                .Property(e => e.partID)
                .IsUnicode(false);

            modelBuilder.Entity<PartNumber>()
                .Property(e => e.partName)
                .IsUnicode(false);

            modelBuilder.Entity<PartNumber>()
                .Property(e => e.locationID)
                .IsUnicode(false);

            modelBuilder.Entity<PartNumber>()
                .Property(e => e.supplierID)
                .IsUnicode(false);

            modelBuilder.Entity<PartNumber>()
                .Property(e => e.materialID)
                .IsUnicode(false);

            modelBuilder.Entity<PartsMaterial>()
                .Property(e => e.materialID)
                .IsUnicode(false);

            modelBuilder.Entity<PartsMaterial>()
                .Property(e => e.materialName)
                .IsUnicode(false);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.salesPersonId)
                .IsUnicode(false);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.salesPersonName)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.supplierID)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.supplierName)
                .IsUnicode(false);

            modelBuilder.Entity<Zipcode>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<Zipcode>()
                .Property(e => e.city)
                .IsUnicode(false);
        }
    }
}
