using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Basico_Entrada_Dados {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite seu nome completo ");
            string nomCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int QuartosQuantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com preço de produto: ");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("----------Nome completo + Quantidade de quartos + Preço do produto---------");
            Console.WriteLine("\n");

            Console.WriteLine("Seu nome completo : " + nomCompleto);
            Console.WriteLine("Quantidade de quartos na sua residencia: " + QuartosQuantidade);
            Console.WriteLine("Preço do seu Produto:" + Preco.ToString("F3",CultureInfo.InvariantCulture));

            Console.WriteLine("Digite na mesma linha com Sobrenome / Idade / Altura : ");
            string[] Dados = Console.ReadLine().Split(' ');

            string Sobrenome = Dados[0];
            int Idade = int.Parse(Dados[1]);
            double altura = double.Parse(Dados[2],CultureInfo.InvariantCulture);

            Console.WriteLine("---------------Impressão SobreNome + Idade + altura----------------");
            Console.WriteLine("Seu sobrenome: " + Sobrenome);
            Console.WriteLine("Sua idade:" + Idade);
            Console.WriteLine("Sua altura: " + altura.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();
            

        }
    }
}
