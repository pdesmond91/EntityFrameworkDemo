namespace AWModelFromCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductDefinitionTree")]
    public partial class ProductDefinitionTree
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductTypeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductCascadingLevel { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductDefinitionId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedTime { get; set; }

        public virtual ProductDefinition ProductDefinition { get; set; }
    }
}
