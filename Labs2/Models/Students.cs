namespace Labs2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Students
    {
        [Key]
        public int ID_Student { get; set; }

        public string FIO { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Of_Birth { get; set; }

        public string Parents { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Pasport_num { get; set; }

        public int? Credit_Card_Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Of_Receipt { get; set; }

        public string Group { get; set; }

        public int? Course { get; set; }

        public int? ID_Specialties { get; set; }

        public bool? Full_Time_Education { get; set; }

        public virtual Evaluations Evaluations { get; set; }

        public virtual Specialties Specialties { get; set; }
    }
}
