using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AnimalSource.Models;
using AnimalSource.Services;

namespace AnimalSource.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalsController : ControllerBase
    {
        public JsonFileAnimalService AnimalService { get; }

        public AnimalsController(JsonFileAnimalService animalService)
        {
            AnimalService = animalService;
        }
        
        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return AnimalService.GetAnimals();
        }
    }
}