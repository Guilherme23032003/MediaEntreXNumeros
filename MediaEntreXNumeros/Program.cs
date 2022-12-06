double numero, resultado, soma = 0.0;
int quantidade;

Console.WriteLine("informe a quantia de numeros que participarão do calculo de media");

quantidade = int.Parse(Console.ReadLine());

for (int nmr = 1; nmr <= quantidade;  nmr++)
{
    Console.WriteLine("informe o valor de numero #" + nmr);
    numero= double.Parse(Console.ReadLine());
    // += acrescenta o valor dele (soma) + o valor do numero
    soma += numero;
}
resultado =  soma / quantidade;

Console.WriteLine("\n\n\na media dos numeros fornecidos é igual a: " + resultado);
