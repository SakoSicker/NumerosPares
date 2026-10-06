namespace NumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Par = new int[10];
            int indice = 0;

            for (int i = 2; i <= 20; i += 2)
            {
                Par[indice] = i;
                Console.WriteLine("Numero par: " + Par[indice]);
                indice++;
            }



        }
    }
}
