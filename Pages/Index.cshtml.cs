using System.Collections.Generic;
using AnimalSource.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using AnimalSource.Services;

namespace AnimalSource.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileAnimalService AnimalService;
        public IEnumerable<Animal> Animals { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger, 
            JsonFileAnimalService animalService)
        {
            _logger = logger;
            AnimalService = animalService;
        }

        public void OnGet()
        {
            Animals = AnimalService.GetAnimals();
        }
    }
}