using AlohaTestAPI.Models.Dto;
using AlohaTestAPI.Models.ORM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlohaTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        AlohaContext context;
        public CountryController()
        {
            context = new AlohaContext();
        }
        [HttpGet]
        public List<Country> GetAll()
        {
            return context.Countries.ToList();
        }
        [HttpGet("{id}")]
        public Country Get(int id)
        {
            return context.Countries.Find(id);
        }
        [HttpPost]
        public Country Post(CountryPostRequestDto model)
        {
            Country country = new Country();
            country.Name = model.Name.Trim();

            context.Countries.Add(country);
            context.SaveChanges();

            return country;
        }
        [HttpDelete]
        public Country Delete(int id)
        {
            Country country = context.Countries.Find(id);
            context.Countries.Remove(country);
            context.SaveChanges();
            return country;
        }
    }
}
