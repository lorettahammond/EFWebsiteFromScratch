namespace LLHManufacturing
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("clientID")]
    public partial class clientID
    {
        [Key]
        [Column("clientID")]
        [StringLength(50)]
        public string clientID1 { get; set; }

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
        public string salespersonID { get; set; }

        public virtual clientID clientID11 { get; set; }

        public virtual clientID clientID2 { get; set; }
    }
}
