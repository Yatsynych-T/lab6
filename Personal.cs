namespace Lab6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personal")]
    public partial class Personal
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Years { get; set; }

        public int? Restaurant_id { get; set; }

        public int? Equipment_id { get; set; }

        public int? Product_id { get; set; }

        public virtual Equipment Equipment { get; set; }

        public virtual Products Products { get; set; }

        public virtual Restaurants Restaurants { get; set; }
    }
}
