using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questoes
{
    class Program
    {
        // Implemente o método Maior(a, b) que recebe dois números inteiros como parâmetro e retorna qual deles é o maior.
        static int Maior(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // O índice de massa corporal (IMC) é uma medida internacional usada para calcular se uma pessoa está no peso ideal.
        class IMC
        {
            private double peso;
            private double altura;

            public IMC()
            {
                this.peso = 0.0;
                this.altura = 0.0;
            }

            public IMC(double peso, double altura)
            {
                this.peso = peso;
                this.altura = altura;
            }

            public double calcular(double peso, double altura)
            {
                double imc = ((peso) / (altura * altura));
                return imc;
            }

            public string classificar(double IMC)
            {
                if (IMC < 16 && IMC > 0)
                {
                    return "Magreza grave";
                }
                else if (IMC >= 16 && IMC < 17)
                {
                    return "Magreza moderada";
                }
                else if (IMC >= 17 && IMC < 18.5)
                {
                    return "Magreza leve";
                }
                else if (IMC >= 18.5 && IMC < 25)
                {
                    return "Saudável";
                }
                else if (IMC >= 25 && IMC < 30)
                {
                    return "Sobrepeso";
                }
                else if (IMC >= 30 && IMC < 35)
                {
                    return "Obesidade Grau I";
                }
                else if (IMC >= 35 && IMC < 40)
                {
                    return "Obesidade Grau II";
                }
                else if (IMC > 40)
                {
                    return "Obesidade Grau III";
                }
                return "ERRO";
            }

            // Se o resto da divisão de um número inteiro por 2 for zero, então, o número é par, caso contrário, é ímpar.
            static bool Impar(int x)
            {
                if (x % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            static void Main(string[] args)
            {
                // QUESTÃO 01 - Dois números em parâmetro
                Console.Write("\n\tOs números passados como parâmetro foi o 106 e 102. Sendo assim, o maior número é o ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(Maior(106,102));

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n\t———————————————————————————————————————————————————————————————————————————————————————");

                Console.ResetColor();

                // QUESTÃO 02 - IMC
                IMC imc = new IMC();

                Console.WriteLine("\n\tDigite o valor da sua altura utilizando virgula ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\t");
                double altura = double.Parse(Console.ReadLine());

                Console.ResetColor();

                Console.WriteLine("\n\tMe informe o valor do seu peso ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\t");
                double peso = double.Parse(Console.ReadLine());

                Console.ResetColor();

                double seuIMC = imc.calcular(peso, altura);

                Console.Write("\n\tSeu IMC é de ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(seuIMC.ToString("N1"));

                Console.ResetColor();

                Console.Write("\n\tSua classificação é: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(imc.classificar(imc.calcular(peso, altura)));

                Console.Write("\n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n\t———————————————————————————————————————————————————————————————————————————————————————");
                Console.ResetColor();

                // QUESTÃO 03 - Descobrir se é par ou ímpar
                Console.Write("\n\tThe number passed as a parameter is ");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(Impar(10));

                Console.ResetColor();
                Console.ReadKey();

            }
        }
    }
}