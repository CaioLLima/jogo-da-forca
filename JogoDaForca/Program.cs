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

                string dicaDaPalavra = String.Join(" ", letrasEncontradas);
                Console.WriteLine("Jogo da Forca.");
                Console.WriteLine($"A palavra secreta é: {dicaDaPalavra}.");

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0];

                for (int i = 0; i < palavraSecreta.Length; i++)
                {
                    if (palavraSecreta[i] == chute)
                    {
                        letrasEncontradas[i] = chute;
                    }
                    Console.WriteLine(letrasEncontradas[i]);
                }

               
            }
            
        }
    }
}
