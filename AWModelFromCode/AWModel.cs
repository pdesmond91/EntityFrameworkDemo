namespace AWModelFromCode
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AWModel : DbContext
    {
        public AWModel()
            : base("name=AWModel")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDefinition> ProductDefinitions { get; set; }
        public virtual DbSet<ProductDefinitionTree> ProductDefinitionTrees { get; set; }
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.LotSize)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Product1)
                .WithOptional(e => e.Product2)
                .HasForeignKey(e => e.ProductParentId);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Product11)
                .WithOptional(e => e.Product3)
                .HasForeignKey(e => e.SecondProductParentId);

            modelBuilder.Entity<ProductDefinition>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductDefinition>()
                .HasMany(e => e.ProductDefinitionTrees)
                .WithRequired(e => e.ProductDefinition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductGroup>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductGroup>()
                .HasMany(e => e.ProductDefinitions)
                .WithRequired(e => e.ProductGroup)
                .WillCascadeOnDelete(false);
        }
    }
}
