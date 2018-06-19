namespace AWModelFromCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductDefinition")]
    public partial class ProductDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductDefinition()
        {
            Products = new HashSet<Product>();
            ProductDefinitionTrees = new HashSet<ProductDefinitionTree>();
        }

        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        public int ProductGroupId { get; set; }

        public int ToLocationId { get; set; }

        public int? FromLocationId { get; set; }

        public int? WeeklyPatternId { get; set; }

        public int PeriodResolution { get; set; }

        public int LotUnitId { get; set; }

        public int MarketSettlementType { get; set; }

        public int DeliveryType { get; set; }

        public int CloseOutType { get; set; }

        public int CascadingType { get; set; }

        public int TradeOrderType { get; set; }

        public bool AutoExerciseOption { get; set; }

        public bool AlwaysAllowCascadingUpdate { get; set; }

        public short NumberOfPriceDecimals { get; set; }

        public short NumberOfLotDecimals { get; set; }

        [StringLength(512)]
        public string Region { get; set; }

        [StringLength(512)]
        public string Sector { get; set; }

        [StringLength(512)]
        public string TimeZoneId { get; set; }

        [StringLength(150)]
        public string DefinitionTypeCode { get; set; }

        public int DefaultPriceUnitId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedTime { get; set; }

        public int? ExternalId { get; set; }

        public int EntityStatus { get; set; }

        public int? IndeliveryPriceModelId { get; set; }

        public decimal LotSize { get; set; }

        public int ExchangeId { get; set; }

        public int MarketSettlementOptionType { get; set; }

        public bool NoUnrealisedInDelivery { get; set; }

        public int ProductCategory { get; set; }

        public int OptionExerciseType { get; set; }

        public bool SupportOption { get; set; }

        public bool IgnoreDst { get; set; }

        public int InstrumentType { get; set; }

        public int CommodityId { get; set; }

        public int? SpreadCommodityId { get; set; }

        public int? SplittingResolution { get; set; }

        public int? PositionTypeId { get; set; }

        public int OptionPremiumType { get; set; }

        public int? ClearingGroupId { get; set; }

        [StringLength(150)]
        public string InternalName { get; set; }

        [StringLength(50)]
        public string LoadType { get; set; }

        public string SpecificationUrl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDefinitionTree> ProductDefinitionTrees { get; set; }
    }
}
