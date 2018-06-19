//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDMXFromDb
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductGroup()
        {
            this.Products = new HashSet<Product>();
            this.ProductDefinitions = new HashSet<ProductDefinition>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ExternalCode { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public Nullable<int> ExternalId { get; set; }
        public int EntityStatus { get; set; }
        public Nullable<int> DefaultPriceUnitId { get; set; }
        public int ExchangeId { get; set; }
        public int CommodityId { get; set; }
        public string TimeZoneId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDefinition> ProductDefinitions { get; set; }
    }
}
