using System; // Não esquecer de utilizar o ; no final, função System que possibilita utilizar o COnsole
 
namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Clear();// Limpar o terminal e possibilitar a o comando "Clear"

            Console.WriteLine("Primeiro valor: ");
            // string v1 = Console.ReadLine(); // Fazendo a leitura dos valores digitados 
            // double pValor = Convert.ToDouble(v1); 
            double pValor = float.Parse(Console.ReadLine()); // Outro método para fazer a mesma coisa;
            Console.WriteLine(pValor);

        }
    }
}