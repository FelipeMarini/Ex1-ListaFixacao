using System;

namespace Ex1_ListaFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Qual o ano atual em que se encontra?\n ");
            int anoatual = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Qual o seu ano de nascimento?\n ");
            int anonascimento = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int idade = anoatual - anonascimento;

            if (idade >= 18) {Console.WriteLine("Você poderá votar este ano, escolha bem!");} 
            
            else {Console.WriteLine("Você não poderá votar este ano por não possuir 18 anos ou mais, aguarde!");}
        }
    }
}
            

            


