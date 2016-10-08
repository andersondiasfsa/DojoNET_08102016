using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDojoNET_08102016
{
    class Program
    {
        static void Main(string[] args)
        {

            Dojo_08102016();
        }
        #region Dojo_08102016

        public enum LetrasFurosEnum
        {
            A = 1,
            B = 2,
            D = 1,
            R = 1
        }

        static void Dojo_08102016()
        {
            //  ************ NÃO FOI MAPEADO TODA AS LETRAS COM FUROS NO ENUM - APENAS: A, B, C, R

            string palavraParaValidacao = "ANDERSON DIAS";

            int totalFuros = ContadorDePlanos(palavraParaValidacao);

            Console.WriteLine(string.Concat("Total de Furos na Palavra: ", totalFuros));

            Console.WriteLine("FIM!");
            Console.ReadKey();
        }

        static int ContadorDePlanos(string palavras)
        {
            int totalFuros = 0;

            // 1. Corre todas as letras da palavra:
            for (int i = 0; i < palavras.Length; i++)
            {
                string letraCorrente = palavras[i].ToString().ToUpper();

                // 2. Valida se a letra foi mapeado como tendo Furos (planos)
                if (Enum.IsDefined(typeof(LetrasFurosEnum), letraCorrente))
                {
                    // 3. Converte a Letra no Enum para Obter o Objeto Enum "LetrasFurosEnum" e obtem o valor (numerico que representa o total de furos):
                    totalFuros += Enum.Parse(typeof(LetrasFurosEnum), letraCorrente).GetHashCode();
                }
            }

            // 4. Caso exista Planos, adicionamos +1 do plano corrente, caso contrario, retorna ele mesmo (valor default: 0):
            totalFuros = (totalFuros > 0 ? totalFuros + 1 : totalFuros);

            return totalFuros;
        }

        #endregion        
    }
}
