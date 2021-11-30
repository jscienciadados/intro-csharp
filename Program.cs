using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // Variaveis
            // tipo da informação (opcional ou substituir por var)
            // o que aquela informação representa

            // Tipos de informações
            // Texto -> String aspas duplas

           // string name = "Joao";
            //string lastName = "Pereira de Souza";
           // Console.WriteLine(name + " " + lastName);

            // formatando uma string
           // Console.WriteLine($"Meu Nome é  {name} {lastName} ");

           // interando com o usuario
           Console.WriteLine("Enter your name:");
           string name = Console.ReadLine();
           Console.WriteLine($"olá, {name}!");

           var nome = "Fabiana";
           var idade = 25;
           var altura = 1.63;
           Console.WriteLine($"Ola, {nome}, voce tem {idade} anos de idade e mede {altura}cm.");

           // operações matematicas
           // Numero -> inteiro - (int, long) -> Float, Double, Decimal 
           /*
           var soma = 10 + 15;
           var subtracao = 30 - 2;
           var multiplicacao = 4 * 4;
           var divisao = 40 / 8.0;

           var valorConta = 52.20;
           Console.WriteLine($"valor da conta foi de R{valorConta:c}");
           */

           // Desafio
           var valorConta = 45.35;
           var taxGarcom = valorConta * 0.10;
           var resultado = valorConta + taxGarcom;
           Console.WriteLine($"valor total da conta: R{resultado:c}.");

           // 
           Console.WriteLine("Digite um numero de 0 a 10");
           var numDigitado = Console.ReadLine();
           var numero = int.Parse(numDigitado);
           Console.WriteLine(numero);










        }
    }
}
