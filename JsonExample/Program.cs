using System.Data;
using System.Reflection.Metadata;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        public class Programuotojas : Darbuotojas
        {
            public string Role { get; set; } = "Programuotojas";
            public string Pareigos { get; set; }

        }
        static void Main(string[] args)
        {
            string failoKelias = "C:\\Users\\krist\\OneDrive\\Desktop\\C#NuGET\\JsonExample\\JsonExample\\DarbuotojuTipai.json";

            string jsonAtsakymas = File.ReadAllText(failoKelias);

            var darbuotojai = JsonConvert.DeserializeObject<List<dynamic>>(jsonAtsakymas);
            List<Adminas> adminai = new List<Adminas>();
            List<Programuotojas> programuotojai = new List<Programuotojas>();

            foreach (var darbuotojas in darbuotojai)
            {
                if (darbuotojas.Role == "Adminas")
                {
                    adminai.Add(new Adminas
                    {
                        Vardas = darbuotojas.Vardas,
                        Amzius = darbuotojas.Amzius,
                        Miestas = darbuotojas.Miestas,
                        Role = darbuotojas.Role,
                        priziuretojas = darbuotojas.priziuretojas
                    });
                }
                else if (darbuotojas.Role == "Programuotojas")
                {
                    programuotojai.Add(new Programuotojas
                    {
                        Vardas = darbuotojas.Vardas,
                        Amzius = darbuotojas.Amzius,
                        Miestas = darbuotojas.Miestas,
                        Role = darbuotojas.Role,
                        Pareigos = darbuotojas.Pareigos
                    });
                }
            }
            foreach (Adminas adminas in adminai)
            {

                Console.WriteLine($"Vardas: {adminas.Vardas}");
                Console.WriteLine($"Amzius: {adminas.Amzius}");
                Console.WriteLine($"Miestas: {adminas.Miestas}");
                Console.WriteLine($"Role: {adminas.Role}");
                Console.WriteLine($"Ar priziuretojas?  {adminas.priziuretojas}");
                Console.WriteLine("-------------------------------");

            }
            foreach (Programuotojas programuotojas in programuotojai)
            {
                Console.WriteLine($"Vardas: {programuotojas.Vardas}");
                Console.WriteLine($"Amzius: {programuotojas.Amzius}");
                Console.WriteLine($"Miestas: {programuotojas.Miestas}");
                Console.WriteLine($"Role: {programuotojas.Role}");
                Console.WriteLine($"Pareigos: {programuotojas.Pareigos}");
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
