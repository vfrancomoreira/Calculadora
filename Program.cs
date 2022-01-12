using System;

namespace Projeto01_Calc
{
    class Program
    {
        enum Menu {Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) // Enquanto o usuário NÃO(!) ESCOLHER SAIR
            {
            Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções:");
            Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");
            Console.WriteLine("=============================");

            Menu opcao = (Menu)int.Parse(Console.ReadLine());

            /*
            string opcaoTxt = Console.ReadLine();
            int opcaoInt = int.Parse(opcaoTxt);
            Menu opcao = (Menu)opcaoInt;
            OBS: Isso é a mesma coisa que a opção a cima.
            */

            switch (opcao)
            {
                case Menu.Soma:
                    Soma();
                    break;
                
                case Menu.Subtracao:
                    Sub();
                    break;
                
                case Menu.Divisao:
                    Div();
                    break;

                case Menu.Multiplicacao:
                    Mult();
                    break;

                case Menu.Potencia:
                    Pot();
                    break;

                case Menu.Raiz:
                    Raiz();
                    break;
                    
                case Menu.Sair:
                    escolheuSair = true;
                    break;
            }

            Console.WriteLine(opcao);
            Console.Clear();

            }
            // NADA
        }
        static void Soma()
        {
            Console.WriteLine("SOMA DE DOIS NÚMEROS");
            
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine($"A soma dos valores são: {result}");

            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("SUBTRAÇÃO DE DOIS NÚMEROS");
            
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 - num2;
            Console.WriteLine($"A subtração dos valores são: {result}");

            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("DIVISÃO DE DOIS NÚMEROS");
            
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            float result = (float)num1 / (float)num2;
            Console.WriteLine($"A divisão dos valores são: {result}");

            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("MULTIPLICAÇÃO DE DOIS NÚMEROS");
            
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 * num2;
            Console.WriteLine($"A multiplicação dos valores são: {result}");

            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Pot()
        {
            // Potencia =  Numero elevado
            
            Console.WriteLine("POTÊNCIA UM NÚMERO");
            
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o expôente: ");
            int expo = int.Parse(Console.ReadLine());

            int result = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"A potencia do valor {baseNum} é: {result}");

            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
            static void Raiz()
        {
            Console.WriteLine("MULTIPLICAÇÃO DE DOIS NÚMEROS");
            
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            
            double result = Math.Sqrt(num1);
            Console.WriteLine($"A raiz quadreada do valor é: {result}");

            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
    }
}
