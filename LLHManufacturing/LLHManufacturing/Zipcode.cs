namespace LLHManufacturing
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zipcode")]
    public partial class Zipcode
    {
        [Key]
        public double zipID { get; set; }

        [Required]
        [StringLength(50)]
        public string state { get; set; }

        [Required]
        [StringLength(50)]
        public string city { get; set; }
    }
}
