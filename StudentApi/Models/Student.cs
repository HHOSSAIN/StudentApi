using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentApi.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        //making thi attribute a required property, specifying the string's type in the db, setting a default val if no val provided
        //since this is a "Required" property
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = "";

        public int ContactNumber { get; set; }

        public int Age { get; set; }
    }
}
