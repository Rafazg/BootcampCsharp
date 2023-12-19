using System;

class Program
{
    static void Main()
    {
    // Solicita ao usuário os limites inferiores e superiores
    Console.WriteLine("Digite o numero inferior");
    int limiteInferior = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o numero superior");
    int limiteSuperior = int.Parse(Console.ReadLine());

    // Variável para acumular a soma dos números pares
    int somaPares = 0;

    // TODO: Crie um Loop para percorrer os números no intervalo
    for(int i = limiteInferior; i <= limiteSuperior; i++)
    {
      if( i % 2 == 0)
      {
        somaPares += i;
      }
    }
    // Lembre-se: O limiteSuperior deve ser menor ou igual a i;
    
    // TODO: Implemente o if para verificar se o número é par:
        
    
    // TODO: Crie o acumulador para a soma dos números pares:
           
    

    // Exibe o resultado
    Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
    }
}