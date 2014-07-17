namespace LLHManufacturing
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [StringLength(50)]
        public string orderID { get; set; }

        [Required]
        [StringLength(50)]
        public string partID { get; set; }

        [Required]
        [StringLength(50)]
        public string statusID { get; set; }

        public double quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string clientID { get; set; }
    }
}
