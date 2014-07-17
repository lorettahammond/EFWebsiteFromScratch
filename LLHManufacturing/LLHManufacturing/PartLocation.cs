namespace LLHManufacturing
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartLocation")]
    public partial class PartLocation
    {
        [Key]
        [StringLength(50)]
        public string locationsID { get; set; }

        [Required]
        [StringLength(50)]
        public string locationName { get; set; }
    }
}
