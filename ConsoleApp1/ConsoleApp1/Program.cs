namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void ExibirMensagemDeBoasVindas()
            {
                Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");
            }
            void RegistrarBanda()
            {
                Console.Clear(); // Limpa o console
                Console.WriteLine("Registro de banda: ");
                Console.Write("Digite o nome da banda: ");
                String nomeDaBanda = Console.ReadLine()!;
                Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso."); // Interpolação de String
                Thread.Sleep(2000); // Em milisegundos
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            String mensagemDeBoasVindas = "SEJA VEM VINDO!";

            void ExibirLogo()
            {
                Console.WriteLine();
                Console.WriteLine(mensagemDeBoasVindas);

            }

            void ExibirOpcoesDoMenu()
            {
                ExibirLogo();
                Console.WriteLine("1 - Registrar uma banda.");
                Console.WriteLine("2 - Mostrar todas as bandas.");
                Console.WriteLine("3 - Avaliar uma banda.");
                Console.WriteLine("4 - Exibir a média de uma banda.");
                Console.WriteLine("0 - Sair.");

                Console.Write("Digite uma opção: ");
                int opcao = int.Parse(Console.ReadLine()!); // ! para nao receber valores null

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Você escolheu a opcão " + opcao);
                        RegistrarBanda();

                        break;
                    case 2: Console.WriteLine("Você escolheu a opcão " + opcao); break;
                    case 3: Console.WriteLine("Você escolheu a opcão " + opcao); break;
                    case 4: Console.WriteLine("Você escolheu a opcão " + opcao); break;
                    case 0: Console.WriteLine("Você saiu da aplicação."); break;
                    default: Console.WriteLine("Opcão Inválida!"); break;


                }

            }
            ExibirMensagemDeBoasVindas();
            while (true)
            {
                ExibirOpcoesDoMenu();
            }
        }
    }
}

