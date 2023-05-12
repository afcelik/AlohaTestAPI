using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlohaTestAPI.Models.ORM
{
    public class Address : BaseModel
    {
        public int? AddressId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Description { get; set; }
        [ForeignKey("CityId")]
        public int? CityId { get; set; }
        public City? City { get; set; }
    }
}