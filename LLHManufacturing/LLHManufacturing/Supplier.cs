namespace LLHManufacturing
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [StringLength(50)]
        public string supplierID { get; set; }

        [Required]
        [StringLength(50)]
        public string supplierName { get; set; }
    }
}
