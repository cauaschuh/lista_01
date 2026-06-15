Console.Write("Informe o primeiro valor: ");
double valor1 = double.Parse(Console.ReadLine()!);

Console.Write("Informe o segundo valor: ");
double valor2 = double.Parse(Console.ReadLine()!);

Console.Write("Informe o terceiro valor: ");
double valor3 = double.Parse(Console.ReadLine()!);

Console.Write("Informe o quarto valor: ");
double valor4 = double.Parse(Console.ReadLine()!);

Console.Write("Informe o quinto valor: ");
double valor5 = double.Parse(Console.ReadLine()!);

double soma = valor1 + valor2 + valor3 + valor4 + valor5;
double media = soma / 5;

Console.WriteLine("Soma dos valores: " + soma);
Console.WriteLine("Média dos valores: " + media);