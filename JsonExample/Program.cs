using Newtonsoft.Json;

namespace JsonExample
{
    internal class Program
    {
        public class Darbuotojas
        {
            public string Vardas { get; set; }
            public int Amzius { get; set; }
            public string Miestas { get; set; }
        }
        static void Main(string[] args)
        {
            string failoKelias = "C:\\Users\\krist\\OneDrive\\Desktop\\C#NuGET\\JsonExample\\JsonExample\\DarbuotojaiJSON.json";

            string jsonAtsakymas = File.ReadAllText(failoKelias);

            Darbuotojas darbuotojas = JsonConvert.DeserializeObject<Darbuotojas>(jsonAtsakymas);

           
            Console.WriteLine($"Vardas: {darbuotojas.Vardas}");
            Console.WriteLine($"Amzius: {darbuotojas.Amzius}");
            Console.WriteLine($"Miestas: {darbuotojas.Miestas}");
        }
    }
}
