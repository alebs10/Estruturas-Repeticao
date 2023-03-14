using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ciclo - While

            /*Uma estrtura de repetição vai executar o seu bloco de comandos
             enquanto a condição avaliada for verdadeira, quando essa condição 
             retornar falso ela vai sair da estrutura.*/

            //int valor = 0;

            //while(valor < 10)
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //}

            //Console.ReadKey();

            #endregion

            #region Ciclo Do - While

            /*Este ciclo é semelhante ao ciclo while, porém ele primeiro
             executa o bloco de comando pelo menos uma vez e em seguida da segunda
            vez em diante ele vai começar avaliar a condição que se não for 
            verdadeira dali para frente, ai sim ele para a execução.
            */

            //int valor = 0;

            //do
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //} while (valor < 10);

            //Console.ReadKey();

            #endregion

            #region Ciclo - For

            /* O ciclo for ele é semelhante aos anteriores, porém
             * ele é mais completo na sua estrutura, dentro de sua
             sintaxe ele é separado por três "sessões" com um ponto e 
            a primeira é a variável de controle (ou variável índice), 
            que serve ára controlar condição, na segunda sessão a cada 
            passagem do ciclo ele vai verificar o desse índice, e nela 
            definimos até quanto é o tamanho, ou seja, enquanto o nosso
            índice for menor que o tamanho definido ele vai executar o 
            comando*/

            //1° - O for vai inicializar uma variável índice que vai receber um valor x.
            //2° - Ele vai executar enquanto o i for menor, maior ou igual a 10 ou outro valor.
            //3° - Logo em seguida temos o incremento da variável de controle.
            //for(int i = 0, j = 10; i < 10;  i++, j--)
            //{
            //    Console.WriteLine("I = " + i + " | " + "J = " + j);
            //}

            //Console.ReadKey();
            #endregion

            #region Ciclo - Foreach

            /*O ciclo foreach ele executa um bloco de comando a cada interação 
             com uma coleção, ou seja, ele é aplicado trabalhando com uma coleção e
            a cada passsagem do ciclo, ele vai retirar um elemento daquela coleção
            e vai executar um bloco de código e assim até chegar no final da coleção.*/

            string[] nomes = { "Ale", "Mary", "Jade", "Foley" };

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }

            Console.ReadKey();

            #endregion
        }
    }
}
