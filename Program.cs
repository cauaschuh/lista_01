Console.Write("Informe o valor total da compra: ");
double valorOriginal = double.Parse(Console.ReadLine()!);

double desconto;
double valorFinal;

if (valorOriginal >= 200)
{
    desconto = valorOriginal * 0.10;
}
else
{
    desconto = 0;
}

valorFinal = valorOriginal - desconto;

Console.WriteLine("Valor original: R$ " + valorOriginal);
Console.WriteLine("Desconto aplicado: R$ " + desconto);
Console.WriteLine("Valor final: R$ " + valorFinal);