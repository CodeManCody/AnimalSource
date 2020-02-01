using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using AnimalSource.Models;

namespace AnimalSource.Services
{
    public class JsonFileAnimalService
    {
        public JsonFileAnimalService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "AnimalDB.json");

        public IEnumerable<Animal> GetAnimals()
        {
            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Animal[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public void AddDangerLevel(int animalId, int dangerLevel)
        {
            var animals = GetAnimals();
            var query = animals.First(x => x.Id == animalId);

            if (query.DangerLevels == null)
            {
                query.DangerLevels = new int[] { dangerLevel };
            }
            else
            {
                var dangerLevels = query.DangerLevels.ToList();
                dangerLevels.Add(dangerLevel);
                query.DangerLevels = dangerLevels.ToArray();
            }

            using(var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Animal>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }), 
                    animals
                );
            }
        }
    }
}