using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlohaTestAPI.Models.ORM
{
    public class City : BaseModel
    {
        public string Name { get; set; }
        [ForeignKey("CityId")]
        public int? CityId { get; set; }
        public City? Town { get; set; }

        [ForeignKey("CountryId")]
        public int? CountryId { get; set; }
        public virtual Country? Country { get; set; }

        public int AddressId { get; set; }

    }
}