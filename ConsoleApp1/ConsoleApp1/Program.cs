Console.WriteLine("Vítajte v kalkulačke: ");
Console.WriteLine("Zadajte prvé číslo: ");
string s = Console.ReadLine();
float a = int.Parse(s);
Console.WriteLine("Zadajte druhé číslo");
string z = Console.ReadLine();
float b = int.Parse(z);

float sučetF, rozdielF, podielF, súčinF;
sučetF = a + b;
súčinF = a * b;
rozdielF = a - b;
podielF = a / b;

Console.WriteLine("Súčet: " + sučetF );
Console.WriteLine("Rozdiel: " + rozdielF );
Console.WriteLine("Podiel: " + podielF );
Console.WriteLine("Súčin: " + súčinF );
Console.WriteLine("Ďakujem za použitie kalulačky, aplikaciu ukončite ľubovolnou klávesou.: ");
