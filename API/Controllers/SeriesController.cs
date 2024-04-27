using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class SeriesController : ControllerBase
    {
        public SeriesController()
        {

        }

        [HttpGet]
        public string GetProducts()
        {
            return "this will be a list of series";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "this will be a list of series";
        }
    }
}
