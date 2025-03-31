double salario;
double FGTS;
Console.WriteLine("Calcule seu FGTS");

Console.Write("Digite o número do seu salário: ");
salario = Convert.ToDouble(Console.ReadLine()!);
Console.Clear();

Console.WriteLine($"Seu salário (R$): {salario}");
FGTS = salario * 8 / 100;
Console.WriteLine($"Valor do FGTS: {FGTS}");