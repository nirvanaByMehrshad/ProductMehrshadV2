namespace DataLeyer.MyDbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ProductID { get; set; }

        public int? CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int Code { get; set; }

        public virtual Category Category { get; set; }
    }
}
