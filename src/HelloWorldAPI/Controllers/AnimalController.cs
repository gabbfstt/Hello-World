using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {

        private readonly ILogger<AnimalController> _logger;

        public AnimalController(ILogger<AnimalController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Animal> Get()
        {
            string _arquivoCsv = "./src/Animais.csv";
            List<string> csvLines = new List<string>();
            List<Animal> animais = new List<Animal>();

            using (StreamReader sr = new StreamReader(_arquivoCsv))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    csvLines.Add(line);
                }
            }

            csvLines.ForEach(csvLine =>
            {
                string[] campos = csvLine.Split(",");
                Animal animal = new Animal(campos[0], 
                                            campos[1], 
                                            campos[2], 
                                            campos[3],
                                            campos[4],
                                            campos[5],
                                            campos[6]);

                animais.Add(animal);
            });

            return animais;
        }
    }
}
