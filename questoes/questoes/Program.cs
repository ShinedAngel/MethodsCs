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
        static int Maior2(int a, int b)
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
                // QUESTÃO 2 IMC
                IMC imc = new IMC();

                Console.WriteLine("Qual a sua altura? ");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine("\nQual o valor do seu peso? ");
                double peso = double.Parse(Console.ReadLine());

                Double seuIMC = imc.calcular(peso, altura);

                Console.WriteLine("\nSeu IMC é de " + seuIMC.ToString("N3"));
                Console.Write("\nSua classificação é: " + imc.classificar(imc.calcular(peso, altura)));
                Console.WriteLine("\n");

                // QUESTÃO IMPAR/PAR
                Console.Write("The number passed as a parameter is ");
                Console.Write(Impar(10));
                Console.ReadKey();

            }
        }
    }
}