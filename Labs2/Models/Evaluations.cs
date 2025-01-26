namespace Labs2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Evaluations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Student { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Exam1 { get; set; }

        public int? ID_Subjects1 { get; set; }

        public int? Evaluations1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Exam2 { get; set; }

        public int? ID_Subjects2 { get; set; }

        public int? Evaluations2 { get; set; }

        public double? Average_Score { get; set; }

        public virtual Students Students { get; set; }

        public virtual Subjects Subjects { get; set; }

        public virtual Subjects Subjects1 { get; set; }
    }
}
