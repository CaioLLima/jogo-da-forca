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
            string[] animais = {
            "Leão", "Tigre", "Elefante", "Gato", "Cachorro", "Panda", "Urso", "Cobra", "Cavalo", "Tubarão",
            "Águia", "Lobo", "Jacaré", "Golfinho", "Canguru", "Hipopótamo", "Rinoceronte", "Girafa", "Zebra", "Raposa",
            "Galo", "Coruja", "Macaco", "Arraia", "Bicho-preguiça", "Peixe-palhaço", "Pinguim", "Tatu"
            };
            string[] paises = {
            "Brasil", "Argentina", "Estados Unidos", "Canadá", "México", "França", "Alemanha", "Itália", "Espanha", "Portugal",
            "Japão", "China", "Índia", "Rússia", "Austrália", "Nova Zelândia", "Inglaterra", "Escócia", "Irlanda", "África do Sul",
            "Egito", "Turquia", "Coreia do Sul", "Indonésia", "Filipinas", "Chile", "Colômbia", "Peru"
            };

            while (true)
            {
                int[] histChutes = new int[8];
                bool acertou = false;
                bool enforcou = false;
                int qntErros = 0;

                Random geradorDeNumeros = new Random();
                int indicePalavraEscolhida = geradorDeNumeros.Next(frutas.Length);
                string tema = "Frutas";
                string palavraSecreta;
                Console.WriteLine("Bem vindo ao Jogo da Forca.");
                Console.WriteLine("Escolha um tema para jogar!");
                Console.WriteLine("1 - Frutas");
                Console.WriteLine("2 - Animais");
                Console.WriteLine("3 - Países");
                Console.WriteLine();

                int escolhaTema = int.Parse(Console.ReadLine());
                if (escolhaTema == 1)
                {
                    palavraSecreta = frutas[indicePalavraEscolhida].ToUpper();

                }
                else if (escolhaTema == 2)
                {
                    palavraSecreta = animais[indicePalavraEscolhida].ToUpper();
                    tema = "Animais";
                }
                else
                {
                    palavraSecreta = paises[indicePalavraEscolhida].ToUpper();
                    tema = "Paises";
                }


                char[] letrasEncontradas = new char[palavraSecreta.Length];
                string letrasUtilizadas = "";
                char[] letraUtilizada = new char[20];
                char chute = ' ';
                for (int i = 0; i < letrasEncontradas.Length; i++)
                {
                    letrasEncontradas[i] = '_';
                }
                do
                {
                    string dicaDaPalavra = String.Join("", letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("Jogo da Forca. O tema é: " + tema);

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

                    letrasUtilizadas = letrasUtilizadas + string.Join("", chute + " ");
                    Console.WriteLine("\nLista de letras usadas:" + letrasUtilizadas);

                    Console.WriteLine($"\nA quantidade de erros é: {qntErros}.");
                    Console.WriteLine($"\nPalavra secreta: {String.Join("", letrasEncontradas)}.");

                    Console.Write("\nDigite uma letra: ");
                    string chutePalavra = Console.ReadLine().ToUpper();
                    bool letraFoiEncontrada = false;
                    if (chutePalavra.Length == 1)
                    {
                        chute = chutePalavra[0];
                        for (int i = 0; i < palavraSecreta.Length; i++)
                        {
                            char letraAtual = palavraSecreta[i];
                            if (chute == letraAtual)
                            {
                                letrasEncontradas[i] = letraAtual;
                                letraFoiEncontrada = true;
                            }
                            dicaDaPalavra = String.Join("", letrasEncontradas);
                        }

                        if (letraFoiEncontrada == false)
                        {
                            qntErros++;
                        }

                        acertou = dicaDaPalavra == palavraSecreta;
                        enforcou = qntErros == 5;
                    }
                    else
                    {
                        // Usuário digitou MAIS de uma letra: trata como tentativa de palavra inteira
                    }







                    /* for (int j = 0; j < 10; j++)
                     {
                         if (letrasUtilizadas[j] == chute)
                         {
                             Console.WriteLine("Você já utilizou essa letra, tente outra.");
                             Console.ReadLine();
                             return;
                         }
                     }*/


                    /*for (int j = 0; j < 10; j++)
                    {
                        if (letrasUtilizadas[j] == '\0')
                        {
                            letraUtilizada[j] = chute;
                            break;
                        }
                    }*/

                    for (int i = 0; i < palavraSecreta.Length; i++)
                    {
                        char letraAtual = palavraSecreta[i];
                        if (chute == letraAtual)
                        {
                            letrasEncontradas[i] = letraAtual;
                            letraFoiEncontrada = true;
                        }
                        dicaDaPalavra = String.Join("", letrasEncontradas);
                    }

                    if (letraFoiEncontrada == false)
                    {
                        qntErros++;
                    }

                    acertou = dicaDaPalavra == palavraSecreta;
                    enforcou = qntErros == 5;

                    if (acertou)
                    {
                        Console.WriteLine($"\nParabéns, você acertou a palavra secreta! A palavra secreta era {palavraSecreta}");
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
