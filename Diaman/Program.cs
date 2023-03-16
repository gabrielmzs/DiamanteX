namespace Diaman {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o tamanho do diamante: ");
            int n = Convert.ToInt32(Console.ReadLine());

            while(n %2 == 0) {
                Console.Write("O número digitado é PAR! Digite um número ímpar: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i <= n; i += 2) {
                
                for (int j = n; j > i ; j-=2) Console.Write(" ");
                for (int j = 0; j < i; j++) Console.Write("X");
                Console.WriteLine();
            }
            for (int i = (n - 2); i >= 1; i -= 2) {

                for (int j = n; j > i; j -= 2) Console.Write(" ");
                for (int j = 0; j < i; j++)   Console.Write("X");
                Console.WriteLine();

            }
        }
    }
}