namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String mensagemDeBoasVindas = "SEJA VEM VINDO!";
            // List<String> listaDeBandas = new List<String> {"U2", "The Neatles", "Calypso" };
            Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
            bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
            bandasRegistradas.Add("The Beatles", new List<int>());

            void ExibirLogo()
            {
                Console.WriteLine();
                Console.WriteLine(mensagemDeBoasVindas);

            }

            void ExibirTituloDaOpcao(string titulo)
            {

                int quantidadeDeLetras = titulo.Length; // Length pega a quantidade de caracteres nesse titulo
                string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
                Console.WriteLine(asteriscos);
                Console.WriteLine(titulo);
                Console.WriteLine(asteriscos);
                Console.WriteLine();
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
                    case 2:
                        Console.WriteLine("Você escolheu a opcão " + opcao);
                        MostrarTodasAsBandasRegistradas();
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu a opcão " + opcao);
                        AvaliarUmaBanda();
                        break;
                    case 4: Console.WriteLine("Você escolheu a opcão " + opcao); break;
                    case 0: Console.WriteLine("Você saiu da aplicação."); break;
                    default: Console.WriteLine("Opcão Inválida!"); break;


                }

            }

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
                ExibirTituloDaOpcao("Registro de banda: ");
                Console.WriteLine("Registro de banda: ");
                Console.Write("Digite o nome da banda: ");
                String nomeDaBanda = Console.ReadLine()!;
                bandasRegistradas.Add(nomeDaBanda, new List<int>());
                //listaDeBandas.Add(nomeDaBanda);
                Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso."); // Interpolação de String
                Thread.Sleep(2000); // Em milisegundos
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            void MostrarTodasAsBandasRegistradas()
            {

                Console.Clear(); // Limpa o console
                ExibirTituloDaOpcao("Exibindo todas as bandas registradas: ");

                //   for(int i = 0; i < listaDeBandas.Count; i++)
                //   {
                //       Console.WriteLine($"Banda: {listaDeBandas[i]}");
                //   }

                foreach (String banda in bandasRegistradas.Keys)
                {
                    Console.WriteLine($"Banda {banda}");
                }

                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            void AvaliarUmaBanda()
            {
                //Banda a ser avalida

                //Se a banda existir no dicionario >> atribuir uma nota

                //Voltar ao menu principal

                Console.Clear();
                ExibirTituloDaOpcao("Avaliar Banda");

                Console.Write("Digite o nome da banda a ser avaliada: ");
                string nomeDaBanda = Console.ReadLine()!;

                if (bandasRegistradas.ContainsKey(nomeDaBanda))
                {  //Alguma chave que contem o nome da banda
                    Console.Write($"Qual a nota que a banda{nomeDaBanda} merece: ");
                    int nota = int.Parse(Console.ReadLine()!);
                    bandasRegistradas[nomeDaBanda].Add(nota);   
                    Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ExibirOpcoesDoMenu();
                }
                else
                {
                    Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada.");
                    Console.WriteLine("Aperte uma tecla para voltar ao menu principal.");
                    Console.ReadKey();
                    ExibirOpcoesDoMenu();
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

