namespace lab6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("city")]
    public partial class city
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public city()
        {
            cinema = new HashSet<cinema>();
        }

        [Key]
        public int id_city { get; set; }

        [Column("city")]
        [Required]
        [StringLength(50)]
        public string city_name { get; set; }

        public int id_country { get; set; }

        public int id_cinema { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cinema> cinema { get; set; }

        public virtual country country { get; set; }
    }
}
