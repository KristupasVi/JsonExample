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

            Console.WriteLine($"Name: {darbuotojas.Vardas}");
            Console.WriteLine($"Age: {darbuotojas.Amzius}");
            Console.WriteLine($"City: {darbuotojas.Miestas}");
        }
    }
}
