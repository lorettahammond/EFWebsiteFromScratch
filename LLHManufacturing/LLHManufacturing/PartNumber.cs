namespace LLHManufacturing
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartNumber")]
    public partial class PartNumber
    {
        [Key]
        [StringLength(50)]
        public string partID { get; set; }

        [Required]
        [StringLength(50)]
        public string partName { get; set; }

        [Required]
        [StringLength(50)]
        public string locationID { get; set; }

        [Required]
        [StringLength(50)]
        public string supplierID { get; set; }

        [Required]
        [StringLength(50)]
        public string materialID { get; set; }
    }
}
