namespace JogoDaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

            while (true)
            {
                Random geradorDeNumeros = new Random();
                int indicePalavraEscolhida = geradorDeNumeros.Next(frutas.Length);
                string palavraSecreta = frutas[indicePalavraEscolhida];
                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int i = 0; i < letrasEncontradas.Length; i++)
                {
                    letrasEncontradas[i] = '_';
                }



                bool acertou = false;
                bool enforcou = false;
                int qntErros = 0;

                do
                {
                    string dicaDaPalavra = String.Join("", letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("Jogo da Forca.");
                    if (qntErros == 0)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (qntErros == 1)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                ");
                        Console.WriteLine(" |         O         ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (qntErros == 2)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                ");
                        Console.WriteLine(" |         O         ");
                        Console.WriteLine(" |         |         ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (qntErros == 3)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                ");
                        Console.WriteLine(" |         O         ");
                        Console.WriteLine(" |        /|\\         ");
                        Console.WriteLine(" |         |         ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }

                    else if (qntErros == 4)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                ");
                        Console.WriteLine(" |         O         ");
                        Console.WriteLine(" |        /|\\         ");
                        Console.WriteLine(" |         |         ");
                        Console.WriteLine(" |        / \\         ");
                        Console.WriteLine(" |                 ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                    }
                    else if (qntErros == 5)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         O         ");
                        Console.WriteLine(" |        /|\\         ");
                        Console.WriteLine(" |         |         ");
                        Console.WriteLine(" |        / \\         ");
                        Console.WriteLine(" |       ______          ");
                        Console.WriteLine(" |      ENFORCADO         ");
                        Console.WriteLine("_|____              ");
                    }

                    Console.WriteLine($"\nA quantidade de erros é: {qntErros}.");
                    Console.WriteLine($"\nPalavra secreta: {String.Join("", letrasEncontradas)}.");

                    Console.Write("\nDigite uma letra: ");
                    char chute = Console.ReadLine()[0];

                    bool letraFoiEncontrada = false;

                    for (int i = 0; i < palavraSecreta.Length; i++)
                    {
                        char letraAtual = palavraSecreta[i];
                        if (chute == letraAtual)
                        {
                            letrasEncontradas[i] = letraAtual;
                            letraFoiEncontrada = true;
                        }


                        dicaDaPalavra = String.Join("", letrasEncontradas);
                        //Console.Write(letrasEncontradas[i]);
                    }

                    if (letraFoiEncontrada == false)
                    {
                        qntErros++;
                        Console.WriteLine($"\nVocê errou pela {qntErros}ª vez.");
                    }
                    acertou = dicaDaPalavra == palavraSecreta;
                    enforcou = qntErros == 5;

                    if (acertou)
                    {
                        Console.WriteLine($"Parabéns, você acertou a palavra secreta! A palavra secreta era {palavraSecreta}");
                    }
                    else if (enforcou)
                    {
                        Console.Clear();
                        Console.WriteLine("Jogo da Forca.");
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         O         ");
                        Console.WriteLine(" |        /|\\         ");
                        Console.WriteLine(" |         |         ");
                        Console.WriteLine(" |        / \\         ");
                        Console.WriteLine(" |       ______          ");
                        Console.WriteLine(" |      ENFORCADO            ");
                        Console.WriteLine("_|____              ");
                        Console.WriteLine($"Você foi enforcado! A palavra secreta era {palavraSecreta}");
                    }

                }
                while (acertou == false && enforcou == false);

                Console.ReadLine();






            }

        }
    }
}
