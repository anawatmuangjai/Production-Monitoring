namespace PDR.Web.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PDR.PROD_MONITOR")]
    public partial class PROD_MONITOR
    {
        [Key]
        [StringLength(15)]
        public string LINE_NAME { get; set; }

        public int ID_MST_LOSS_GROUP { get; set; }

        public int PLAN_SHOT { get; set; }

        public int ACTUAL_SHOT { get; set; }

        public int NG_QTY { get; set; }

        public int LOSS_TIME { get; set; }

        public int PLAN_DIFF { get; set; }

        public int PLAN_ID { get; set; }

        public bool URGENT_FLAG { get; set; }

        [Required]
        [StringLength(19)]
        public string UPDATE_DATE { get; set; }

        [StringLength(50)]
        public string DISPLAY_GROUP { get; set; }

        public virtual MST_LOSS_GROUP MST_LOSS_GROUP { get; set; }
    }
}
