namespace EntityFrameWorkOneToOneToManyExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shirt")]
    public partial class shirt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public shirt()
        {
            outfit_to_shirt = new HashSet<outfit_to_shirt>();
        }

        [Key]
        public int shirt_id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<outfit_to_shirt> outfit_to_shirt { get; set; }
    }
}
