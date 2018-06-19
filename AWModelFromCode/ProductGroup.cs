namespace AWModelFromCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductGroup")]
    public partial class ProductGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductGroup()
        {
            Products = new HashSet<Product>();
            ProductDefinitions = new HashSet<ProductDefinition>();
        }

        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(150)]
        public string ExternalCode { get; set; }

        [StringLength(250)]
        public string Sector { get; set; }

        [StringLength(250)]
        public string Industry { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedTime { get; set; }

        public int? ExternalId { get; set; }

        public int EntityStatus { get; set; }

        public int? DefaultPriceUnitId { get; set; }

        public int ExchangeId { get; set; }

        public int CommodityId { get; set; }

        [StringLength(512)]
        public string TimeZoneId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDefinition> ProductDefinitions { get; set; }
    }
}
