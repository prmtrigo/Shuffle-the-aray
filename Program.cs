namespace Shuffle_the_aray;
class Program
{
    public int[] Shuffle(int[] vetor, int n) {
            int[] novoVetor = new int[2 * n];
            
            for(int i = 0; i < 2 * n; i++)
            {
                if(i % 2 == 0)
                {
                    novoVetor[i] = vetor[i / 2];
                }
                else
                {
                    novoVetor[i] = vetor[n + (i / 2 - 1) + 1];
                }
            }
            
            for (int i=0; i < novoVetor.Length; i++){
                Console.WriteLine(novoVetor[i]);
            }
            return novoVetor;
        }

    static void Main(string[] args)
    {
        Program programa = new Program();

        int[] numeros = new int[] {1,2,3,4,4,3,2,1};

        Console.Write("Digite a posicao a ser alterada:");
        int posicao = Convert.ToInt32(Console.ReadLine());

        programa.Shuffle(numeros, posicao);

    }
}
