namespace AWModelFromCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Product1 = new HashSet<Product>();
            Product11 = new HashSet<Product>();
        }

        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        public string PriceTicker { get; set; }

        public int ProductGroupId { get; set; }

        public decimal LotSize { get; set; }

        public int PeriodResolution { get; set; }

        public int ProductDefinitionId { get; set; }

        public int ProductTypeId { get; set; }

        public bool IsBalance { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public DateTime DeliveryFromDate { get; set; }

        public DateTime DeliveryToDate { get; set; }

        public int Year { get; set; }

        public int? WeeklyPatternId { get; set; }

        public int ProductNumber { get; set; }

        public int? ProductParentId { get; set; }

        public int? SecondProductParentId { get; set; }

        public int NumberOfChildProducts { get; set; }

        public int NumberOfGrandChildProducts { get; set; }

        public int ToLocationId { get; set; }

        public int? FromLocationId { get; set; }

        public DateTime CeaseDate { get; set; }

        public DateTime TradingFromDate { get; set; }

        public DateTime TradingToDate { get; set; }

        public DateTime? OptionCeaseDate { get; set; }

        public DateTime? OptionTradingFrom { get; set; }

        public DateTime? OptionTradingTo { get; set; }

        [StringLength(150)]
        public string OptionPriceTicker { get; set; }

        [StringLength(150)]
        public string OptionNameFormat { get; set; }

        [StringLength(10)]
        public string OptionCallName { get; set; }

        [StringLength(10)]
        public string OptionPutName { get; set; }

        [StringLength(150)]
        public string ProductTypeCode { get; set; }

        [StringLength(150)]
        public string IsinCode { get; set; }

        [StringLength(150)]
        public string AiiCode { get; set; }

        public int CascadingLevel { get; set; }

        public long? TreeId { get; set; }

        public int ProductCategory { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedTime { get; set; }

        public int? ExternalId { get; set; }

        public int EntityStatus { get; set; }

        public int ExchangeId { get; set; }

        [StringLength(512)]
        public string TimeZoneId { get; set; }

        public int? NumberOfStrikeDecimals { get; set; }

        [StringLength(150)]
        public string DeliveryCode { get; set; }

        public bool IgnoreDst { get; set; }

        [StringLength(150)]
        public string FriendlyName { get; set; }

        [StringLength(150)]
        public string ExternalName { get; set; }

        [StringLength(150)]
        public string OptionFriendlyName { get; set; }

        [StringLength(150)]
        public string OptionExternalName { get; set; }

        [StringLength(150)]
        public string FamiliyName { get; set; }

        [StringLength(150)]
        public string OptionLogicalCode { get; set; }

        [StringLength(150)]
        public string LogicalCode { get; set; }

        [StringLength(150)]
        public string ClearerCode { get; set; }

        [StringLength(150)]
        public string InternalName { get; set; }

        public int CommodityId { get; set; }

        public int? SpreadCommodityId { get; set; }

        public bool? SoftNumStrikeDecRule { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        [StringLength(150)]
        public string OptionClearerCode { get; set; }

        [StringLength(150)]
        public string OptionIsinCode { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product1 { get; set; }

        public virtual Product Product2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product11 { get; set; }

        public virtual Product Product3 { get; set; }

        public virtual ProductDefinition ProductDefinition { get; set; }
    }
}
