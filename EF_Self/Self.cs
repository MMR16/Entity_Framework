namespace EF_Self
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Self")]
    public partial class Self
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FName { get; set; }

        [StringLength(15)]
        public string MName { get; set; }

        [StringLength(10)]
        public string Lname { get; set; }

        public int Age { get; set; }

        public virtual Self Self1 { get; set; }

        public virtual Self Self2 { get; set; }
    }
}
