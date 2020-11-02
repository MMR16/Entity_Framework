using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DataAnnotations
{
    public class Employee
    {
        [Key]//key & Identity
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//Set identity to none
        public int SSN { get; set; }
        [Required(ErrorMessage = "FirstName Is Required")]
        [StringLength(10)]//Max
        [Column("First Name")]// column name in database
        public string Fname { get; set; }
        [MinLength(3), MaxLength(10)]//string
        [Column(name: "Last Name")]
        public string Lname { get; set; }
        [DataType(DataType.PhoneNumber)]    //data type
        public int Phone { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        // [EmailAddress]
        [EmailAddress]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please Enter Valid Email")]   //MVC for Display & Editing Because of Error Message 
        public string Email { get; set; }
        [Range(18, 60, ErrorMessage = "Age MustBe From 18 to 60")]//int
        public int? Age { get; set; }
        [Column(TypeName = "money")] // column type in database
        public decimal? Salary { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? Birthday { get; set; }
        public string Adress { get; set; }
        //public int any { get; set; }

        [ForeignKey("Department")]
        public int ADepID { get; set; }
        public virtual Department Department { get; set; }
    }
}
