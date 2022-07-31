using System;

namespace DateTime_kind
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 59, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 59, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 59);
            DateTime d4 = new DateTime(2000, 8, 15, 13, 5, 59);



            //PADRAO ISO 8601
            DateTime d5 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d6 = DateTime.Parse("2000-08-15T13:05:58Z");



            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2.Kind);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to UTC: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3.Kind);
            Console.WriteLine("d3 kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to UTC: " + d3.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d4: " + d4.Kind);
            Console.WriteLine("d4 kind: " + d4.Kind);
            Console.WriteLine("d4 to Local: " + d4.ToLocalTime());
            Console.WriteLine("d4 to UTC: " + d4.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine(d5);
            Console.WriteLine(d6.ToLocalTime()); // Pega a data e hora que esta armazenado e instancia com o horario  local
            Console.WriteLine(d6.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // Garante que a data armazenada esteja no formato UTC e imprime no padrão ISO 8601

        }
    }
}
