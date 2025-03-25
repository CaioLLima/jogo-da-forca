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
                Console.WriteLine("Jogo da Forca.");
                Console.WriteLine($"A palavra secreta é: {palavraSecreta}.");

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0];
            }
            
        }
    }
}
