namespace LLHManufacturing
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [StringLength(12)]
        public string clientID { get; set; }

        [Required]
        [StringLength(50)]
        public string clientName { get; set; }

        [Required]
        [StringLength(50)]
        public string clientAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string zipID { get; set; }

        [Required]
        [StringLength(50)]
        public string orderID { get; set; }

        [Required]
        [StringLength(50)]
        public string salesPersonID { get; set; }

        public virtual Client Client1 { get; set; }

        public virtual Client Client2 { get; set; }
    }
}
