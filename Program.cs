Console.WriteLine("--- Entrada Válida ---");

int numeroDigitado = -1;

while (numeroDigitado < 0 || numeroDigitado > 100)
{
    Console.WriteLine("Digite um número entre 10 e 100 (ou 0 para cancelar)...:");
numeroDigitado = Convert.ToInt32(Console.ReadLine());
}

if (numeroDigitado == 0)
{
Console.WriteLine("\nOperação Cancelada.");
}
else
{
    Console.WriteLine($"\nNúmero Selecionado = {numeroDigitado}");
}

Console.WriteLine("\nVolte Sempre!");

