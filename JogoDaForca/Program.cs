namespace JogoDaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string palavraSecreta = "MELANCIA";
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
                    Console.WriteLine($"A quantidade de erros é: {qntErros}.");
                    Console.WriteLine($"A palavra secreta é: {String.Join("", letrasEncontradas)}.");

                    Console.Write("Digite uma letra: ");
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
                        Console.Write(letrasEncontradas[i]);
                    }

                    if (letraFoiEncontrada == false)
                    {
                        qntErros++;
                        Console.WriteLine($"\nVocê errou pela {qntErros}ª vez.");
                    }
                    acertou = dicaDaPalavra == palavraSecreta;
                    enforcou = qntErros > 5;

                    if (acertou)
                    {
                        Console.WriteLine("Parabéns, você acertou a palavra secreta!");
                    }
                    else if (enforcou)
                    {
                        Console.WriteLine($"Você foi enforcado! A palavra secreta era {palavraSecreta}");
                    }

                }
                while (acertou == false && enforcou == false);

                Console.ReadLine();






            }

        }
    }
}
