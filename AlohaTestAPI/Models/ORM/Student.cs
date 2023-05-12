using System.ComponentModel.DataAnnotations.Schema;

namespace AlohaTestAPI.Models.ORM
{
    public class Student : BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        [ForeignKey("AddressId")]
        public int? AddressId { get; set; }
        public virtual Address? Address { get; set; }
    }
}