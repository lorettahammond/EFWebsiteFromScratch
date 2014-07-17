namespace LLHManufacturing
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesPerson")]
    public partial class SalesPerson
    {
        [StringLength(50)]
        public string salesPersonId { get; set; }

        [Required]
        [StringLength(50)]
        public string salesPersonName { get; set; }
    }
}
