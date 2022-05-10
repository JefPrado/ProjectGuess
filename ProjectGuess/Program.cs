using System;

namespace ProjectGuess
{
    class Program
    {
        static void Main(string[] args)
        {

                    Random AcasoNumero = new Random();
                    bool JogarNovamente = true;
                    int min = 1;
                    int max = 100;
                    int acho;
                    int num;
                    int palpites;
                    string reacao;

            while (JogarNovamente)
            {
                    acho = 0;
                    palpites = 0;
                    reacao = "";
                    num = AcasoNumero.Next(min, max + 1);
            

                while (acho != num)
                {
                    Console.WriteLine("Ache o número entre " + min + "  -  " + max + " : ");
                    acho = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Talvez: " + acho);

                    if (acho > num)
                    {
                        Console.WriteLine(acho + " É Alto!");
                    }
                    else if (acho < num)

                    {
                        Console.WriteLine(acho + " É Baixo!");
                       
                    }
                    palpites++;

                }
                Console.WriteLine("num: " + num);
                Console.WriteLine("Você Venceu ! ");
                Console.WriteLine("Palpites: " + palpites);

                Console.WriteLine("Você gostaria de jogar de novo (S/N) ");
                reacao = Console.ReadLine();
                reacao = reacao.ToUpper();

                    if (reacao == "S")
                    {
                        JogarNovamente = true; 
                    
                    }
                    else
                    {

                        JogarNovamente = false; 
                    }


            }
          

            Console.WriteLine("Obrigado por Jogar! .... Eu Achei");


            Console.ReadKey();
        }
    }
}
