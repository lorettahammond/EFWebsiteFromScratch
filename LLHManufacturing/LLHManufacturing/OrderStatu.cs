namespace LLHManufacturing
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderStatu
    {
        [Key]
        [StringLength(50)]
        public string statusID { get; set; }

        [Required]
        [StringLength(50)]
        public string statusName { get; set; }
    }
}
