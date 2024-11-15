using System;
using System.Threading.Tasks;
using WeatherApiFacade;

namespace WeatherConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var facade = new WeatherFacade();

            Console.WriteLine("Podaj nazwę miasta, aby uzyskać aktualną temperaturę:");
            string city = Console.ReadLine();

            double? temperature = await facade.GetTemperatureByCity(city);

            if (temperature != null)
            {
                Console.WriteLine($"Aktualna temperatura w {city} wynosi: {temperature}°C");
            }
            else
            {
                Console.WriteLine("Nie udało się pobrać temperatury. Upewnij się, że nazwa miasta jest poprawna.");
            }

            // Czekaj na wciśnięcie dowolnego klawisza przed zamknięciem konsoli
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
