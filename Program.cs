using System; // Não esquecer de utilizar o ; no final, função System que possibilita utilizar o COnsole
 // git reset no para remover ou desfazer algo
namespace Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu(){
            Console.Clear();

            while(true){
                Console.WriteLine("Qual operação deseja realizar?");
                Console.WriteLine("1 - soma");
                Console.WriteLine("2 - subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");

                Console.WriteLine("------------");
                Console.WriteLine("Selecione uma opção: ");
                short opSelecionada = short.Parse(Console.ReadLine());
            
                if(opSelecionada == 1 ){
                    Soma();
                }
                else if(opSelecionada == 2){
                    Subtracao();
                }
                else if(opSelecionada == 3){
                    Divisao();
                }
                else if(opSelecionada == 4){
                    Multiplicacao();
                }
                else{
                    Console.WriteLine("Opção inexistente");
                }
                Console.WriteLine("Deseja reiniciar o processo?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("0 - Não");
                short reinicio = short.Parse(Console.ReadLine());

                if( reinicio == 0){
                    Console.WriteLine("Encerrando Processo");
                    break;
                }
                else if( reinicio != 1){
                    Console.WriteLine("Opção inválida. Reiniciando...");
                }
            }


            //Console.ReadKey();
        }

        static void Soma(){

            Console.Clear();// Limpar o terminal e possibilitar a o comando "Clear"

            // string v1 = Console.ReadLine(); // Fazendo a leitura dos valores digitados 
            // double pValor = Convert.ToDouble(v1); 
            Console.WriteLine("Selecionado Soma: ");
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
            Console.ReadKey();
        }

        static void Subtracao(){
            Console.Clear();
            
            Console.WriteLine("Selecionado Subtração: ");
            Console.WriteLine("Primeiro valor:");
            double priValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            double secValor = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = priValor - secValor;

            Console.WriteLine($"O resultado da subtraçao é: {resultado}");
            Console.ReadKey(); // pausa a execução do programa até que o usuário pressione uma tecla, espera a interação para tomar a próxima ação.
            // nessa caso serve só para o programa não encerrar automaticamente sozinho
        }

        static void Divisao(){
            Console.Clear();

            Console.WriteLine("Selecionado Divisão: ");
            Console.WriteLine("Primeiro valor:");
            double priValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            double secValor = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = priValor / secValor;

            Console.Write($"O resultado da divisao é: {resultado}");
            Console.ReadKey();
        }

        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Selecionado Multiplicação: ");
            Console.WriteLine("Primeiro valor:");
            double priValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            double secValor = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = priValor * secValor;

            Console.WriteLine($"O resultado da multiplicaçao é: {resultado}");
            Console.ReadKey();
        }
    
    
    }


}