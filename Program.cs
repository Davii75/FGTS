decimal salario;
decimal FGTS;
Console.WriteLine("Calcule seu FGTS");

Console.Write("Digite o número do seu salário: ");
salario = Convert.ToDecimal(Console.ReadLine()!);
Console.Clear();

Console.WriteLine($"Seu salário (R$): {salario:C2}");
FGTS = salario * 8 / 100;
Console.WriteLine($"Valor do FGTS: {FGTS:C2}");
