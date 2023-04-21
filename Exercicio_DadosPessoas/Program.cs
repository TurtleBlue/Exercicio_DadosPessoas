namespace Exercicio_DadosPessoas
{
    internal class Program
    {
        /*Tem-se um conjunto de dados contendo a altura e o gênero (M, F) de N pessoas. 
         * Fazer um programa que calcule e escreva a maior e a menor altura do grupo, 
         * a média de altura das mulheres e o número de homens.
         */
        static void Main(string[] args)
        {
            int i = 0, numeroHomens = 0, numeroMulheres = 0;
            double mediaAltura = 0;

            Console.WriteLine("Quantas pessoas deseja cadastrar?");
            i = Convert.ToInt32(Console.ReadLine());

            //Declarando os Arrays conforme a quantidade de inputs que o usuário deseja fazer.
            Char [] genero = new char[i];
            String[] listaGenero = new string[i];
            double[] altura = new double[i];

            //Laço de repetição para os inputs dos gêneros.
            for (i = 0; i < genero.Length; i++)
            {
                while (genero[i] != 'F' && genero[i] != 'f' && genero[i] != 'm' && genero[i] != 'M')
                {
                    Console.WriteLine($"Digite o gênero da {i + 1}º pessoa (M/F):");
                    genero[i] = Convert.ToChar(Console.ReadLine());

                    //Verificação de caracteres inválidos.
                    if (genero[i] != 'F' && genero[i] != 'f' && genero[i] != 'm' && genero[i] != 'M')
                    {
                        Console.WriteLine("\n\nGenero inválido, tente novamente.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } 

                Console.WriteLine($"Digite a altura da {i + 1}º pessoa:");
                altura[i] = Convert.ToDouble(Console.ReadLine());

                //Separando a altura e quantidade de mulheres para fazer a média no relatório final.
                if (genero[i] == 'F' || genero[i] == 'f')
                {
                    mediaAltura = mediaAltura + altura[i];
                    numeroMulheres += 1;
                }
                else
                {
                    numeroHomens += 1;
                }
            }

            //Procedimentos matemáticos e funções para facilitar o resultado.
            mediaAltura = mediaAltura / numeroMulheres;
            Array.Sort(altura);
            double mediaAltura2 = Math.Round(mediaAltura, 2);

            //Relatório final.
            Console.WriteLine($"A maior altura do grupo é: {altura.Last()}, a menor altura do grupo é: {altura.First()}\n" +
                $"A média de altura das mulheres é: {mediaAltura2}, o número de homens é de: {numeroHomens}");
            
        }
    }
}