using System; // Não esquecer de utilizar o ; no final, função System que possibilita utilizar o COnsole
 // git reset no para remover ou desfazer algo
namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();

        }

        static void Soma(){

            Console.Clear();// Limpar o terminal e possibilitar a o comando "Clear"

            // string v1 = Console.ReadLine(); // Fazendo a leitura dos valores digitados 
            // double pValor = Convert.ToDouble(v1); 
            Console.WriteLine("Primeiro valor: ");
            double priValor = double.Parse(Console.ReadLine()); // Outro método para fazer a mesma coisa;

            Console.WriteLine("Segundo valor: ");
            double secValor = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = priValor + secValor;
            //Console.WriteLine("O resultado da soma é: " + resultado); // concatenação na impressão utilizar "+"
            Console.WriteLine($"O resultado da soma é: {resultado}"); // outro método, interpolação de strings
            // Console.WriteLine($"O resultado da soma é: {priValor + secValor}");
            // Console.WriteLine("O resultado da soma é: " + (priValor + secValor));
        }
    }
}