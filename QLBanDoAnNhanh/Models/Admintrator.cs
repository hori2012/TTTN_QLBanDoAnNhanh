namespace QLBanDoAnNhanh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admintrator")]
    public partial class Admintrator
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Password { get; set; }
    }
}
