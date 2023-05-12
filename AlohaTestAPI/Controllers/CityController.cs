using Microsoft.AspNetCore.Mvc;
using AlohaTestAPI.Models.ORM;
using Microsoft.EntityFrameworkCore;
using AlohaTestAPI.Models.Dto;


namespace AlohaTestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : ControllerBase
    {

        AlohaContext context;
        public CityController()
        {
            context = new AlohaContext();
        }
        [HttpGet]
        public List<City> GetAll()
        {
            return context.Cities.ToList();
        }
        [HttpGet("{id}")]
        public City Get(int id)
        {
            return context.Cities.Find(id);
        }
        [HttpPost]
        public City Post(CityPostRequestDto model)
        {
            City city = new City();
            city.Name = model.Name.Trim();
            

            context.Cities.Add(city);
            context.SaveChanges();

            return city;
        }
        [HttpDelete]
        public City Delete(int id)
        {
            City city = context.Cities.Find(id);
            context.Cities.Remove(city);
            context.SaveChanges();
            return city;
        }

    }
}

