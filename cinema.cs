namespace lab6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cinema")]
    public partial class cinema
    {
        [Key]
        public int id_cinema { get; set; }

        [Column("cinema")]
        [Required]
        [StringLength(50)]
        public string cinema_name { get; set; }

        public int id_city { get; set; }

        public virtual city city { get; set; }
    }
}
