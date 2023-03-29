Console.Write($"Digite a primeira nota: ");
float n1 = float.Parse(Console.ReadLine());

Console.Write($"Digite a segunda nota: ");
float n2 = float.Parse(Console.ReadLine());

Console.Write($"Digite a terceira nota: ");
float n3 = float.Parse(Console.ReadLine());

Console.Write($"Digite a quarta nota: ");
float n4 = float.Parse(Console.ReadLine());

Console.Write($"Digite a quinta nota: ");
float n5 = float.Parse(Console.ReadLine());

float media = (n1 + n2 + n3 + n4 + n5) / 5;
Console.WriteLine($"Sua media e {media}");
