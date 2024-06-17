using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// DUONG KHANH DIEM - 2021050130
namespace DKDBaiThi2324.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}




