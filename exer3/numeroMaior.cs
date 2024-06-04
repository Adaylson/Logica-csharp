using  System;

class numeroMaior
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem Vindo a função do maior numero");
        
        Console.WriteLine("Digite o valor 1");
        int valor1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor 2");
        int valor2 = Convert.ToInt32(Console.ReadLine());

        if(valor1 > valor2)
        {
            Console.WriteLine(valor1 + " é maior que " + valor2);
        }else
        if(valor1 < valor2)
        {
            Console.WriteLine(valor2 + " é maior que valor " + valor1);
        }
        else
        {
            Console.WriteLine("Os dois possuem o mesmo valor");
        }
    }
}