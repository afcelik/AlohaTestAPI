using System.ComponentModel.DataAnnotations.Schema;

namespace AlohaTestAPI.Models.ORM
{
    public class University : BaseModel
    {
        public string Name { get; set; }
        public int? CityId { get; set; }
    }
}