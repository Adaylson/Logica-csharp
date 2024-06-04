using System;

class sinalnumero
{
    static void  Main(string[] args)
    {
        Console.WriteLine("Bem vindo a função dos sinais");
        Console.WriteLine("Digite um valor");

        double numero = Convert.ToInt32(Console.ReadLine());

        if( numero > 0){
            Console.WriteLine(numero + " é um numero positivo");
        }else
        if(numero < 0 ){
            Console.WriteLine(numero + " é um numero negativo");
        }
        else{
            Console.WriteLine("é zero");
        }
    }
}