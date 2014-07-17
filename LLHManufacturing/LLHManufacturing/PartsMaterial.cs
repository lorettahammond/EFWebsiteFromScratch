namespace LLHManufacturing
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartsMaterial")]
    public partial class PartsMaterial
    {
        [Key]
        [StringLength(50)]
        public string materialID { get; set; }

        [Required]
        [StringLength(50)]
        public string materialName { get; set; }
    }
}
