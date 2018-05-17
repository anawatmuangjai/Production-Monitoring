namespace PDR.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PDR.MST_LOSS_GROUP")]
    public partial class MST_LOSS_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MST_LOSS_GROUP()
        {
            PROD_MONITOR = new HashSet<PROD_MONITOR>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_FACTOR { get; set; }

        [Required]
        [StringLength(50)]
        public string TROUBLE_NAME { get; set; }

        [Required]
        [StringLength(30)]
        public string APP_NAME { get; set; }

        [StringLength(50)]
        public string STATUS_NAME { get; set; }

        [StringLength(50)]
        public string OWNER { get; set; }

        [Required]
        [StringLength(50)]
        public string CHARGE { get; set; }

        [StringLength(10)]
        public string B_COLOR { get; set; }

        public bool FLAG_STOP { get; set; }

        public int ORDER_NO { get; set; }

        [StringLength(100)]
        public string NOTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROD_MONITOR> PROD_MONITOR { get; set; }
    }
}
