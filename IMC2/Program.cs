using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu Nome:");
            string nome = (Console.ReadLine());

            Console.WriteLine("Digite a sua Idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o seu Peso: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a sua Altura: ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());            

            float result = peso / (altura * altura);

            if (result < 18.5)
            {
                Console.WriteLine("Você está Abaixo do Peso");
            }
            else if (result >= 18.5 && result < 25)
            {
                Console.WriteLine("Você está com peso Normal");
            }
            else if (result >= 25 && result < 30)
            {
                Console.WriteLine("Você está com Sobrepeso");
            }
            else if (result >= 30)
            {
                Console.WriteLine("Você está com Obesidade");
            }            

            Console.WriteLine("Nome: " + nome + "\r\nSua idade é: " + idade + "\r\nSeu peso é: " + peso + "\r\nSua Altura é: " + altura);
        }
    }
}