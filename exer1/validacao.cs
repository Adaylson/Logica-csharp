using System;

class validacao 
{
    static void Main(string[] args)
    {

        Console.WriteLine("Bem Vindo a Função do impar ou par");
        Console.WriteLine("Digite um numero");

         int numero = Convert.ToInt32(Console.ReadLine());
        
        if(numero % 2 == 0)
        {
            Console.WriteLine("É um numero par");
        }
        else
        {
            Console.WriteLine("É um numero inpar");
        }
    }
}