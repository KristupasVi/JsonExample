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

        public class Adminas : Darbuotojas
        {
            public string Role { get; set; } = "Adminas";
            public bool priziuretojas { get; set; } = true;
        }

        public class Programuotojas : Darbuotojas {
            public string Role { get; set; } = "Programuotojas";
            public string pareigos { get; set; }

        }
        static void Main(string[] args)
        {
            string failoKelias = "C:\\Users\\krist\\OneDrive\\Desktop\\C#NuGET\\JsonExample\\JsonExample\\DarbuotojaiJSON.json";

            string jsonAtsakymas = File.ReadAllText(failoKelias);

            List<Darbuotojas> darbuotojai = JsonConvert.DeserializeObject<List<Darbuotojas>>(jsonAtsakymas);

            foreach (var darbuotojas in darbuotojai)
            {
                Console.WriteLine($"Vardas: {darbuotojas.Vardas}, Amzius:{darbuotojas.Amzius}, Miestas: {darbuotojas.Miestas}");
            }
        }
    }
}
