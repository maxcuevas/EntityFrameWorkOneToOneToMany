namespace EntityFrameWorkOneToOneToManyExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class outfit_to_shirt
    {
        [Key]
        public int outfit_to_shirt_id { get; set; }

        public int outfit_id { get; set; }

        public int shirt_id { get; set; }

        public virtual outfit outfit { get; set; }

        public virtual shirt shirt { get; set; }
    }
}
