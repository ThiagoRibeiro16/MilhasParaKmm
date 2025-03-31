Console.Clear();
string medida1;
double milha;
double km;

Console.Clear();

Console.Write("Informe a medida em milhas: ");
medida1 = Console.ReadLine()!;

milha = Convert.ToDouble(medida1);
km = milha * 1.609;

Console.WriteLine($"medida em milhas: {milha}");
Console.WriteLine($"medida em quilômetros: {km} km");