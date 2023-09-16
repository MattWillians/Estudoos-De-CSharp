// Screen Sound

internal class Program
{
    private static void Main(string[] args)
    {
        //List<String> bandas = new();
        Dictionary<string, List<int>> bandas = new();

        static void ImprimirTituloScreenSound()
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

        void printTitulo(string titulo)
        {
            Console.WriteLine(string.Empty.PadLeft(titulo.Length, '*'));
            Console.WriteLine(titulo);
            Console.WriteLine(string.Empty.PadLeft(titulo.Length, '*'));
        }

        void exibirBandas()
        {
            foreach (var item in bandas)
            {
                Console.WriteLine($"Banda: {item.Key}");
            }
        }

        void ExibirMenuOpcoes()
        {

            ImprimirTituloScreenSound();

            Console.Write("Digite 1 para registrar uma banda\nDigite 2 para listar as bandas\nDigite 3 para avaliar uma banda\nDigite 4 para exibir a média da banda\nDigite -1 para sair\n\nDigite a Opção desejada: ");
            string opcaoDigitada = Console.ReadLine()!;
            int opcaoInt = int.Parse(opcaoDigitada);

            switch (opcaoInt)
            {
                case 1: RegistrarBanda(); break;

                case 2: ExibirBandas(); break;

                case 3: AvaliarUmaBanda(); break;

                case 4: mediaDaBanda(); break;
                case -1: Console.WriteLine("Opt -1"); break;
                default: Console.WriteLine("Opt não existente"); break;
            }
        }

        void RegistrarBanda()
        {

            Console.Clear();
            printTitulo("Registro de Bandas");

            Console.Write("Digite o nome da banda: ");
            string nomeBanda = Console.ReadLine()!;

            //TODO
            bandas.Add(nomeBanda, new List<int>());

            Console.WriteLine($"A banda {nomeBanda} foi registrada");
            Thread.Sleep(2000);

            Console.Clear();
            ExibirMenuOpcoes();
        }

        void ExibirBandas()
        {
            Console.Clear();
            printTitulo("Lista de Bandas Registradas");

            exibirBandas();

            Thread.Sleep(4000);
            Console.WriteLine("\n");
            Console.Clear();

            ExibirMenuOpcoes();
        }

        void AvaliarUmaBanda()
        {
            Console.Clear();
            printTitulo("Avaliar uma Banda");

            exibirBandas();
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            String bandaAvaliada = Console.ReadLine()!;

            Console.Write($"\nQual a nota de {bandaAvaliada}?: ");
            int notaBanda = int.Parse(Console.ReadLine()!);

            if (bandas.ContainsKey(bandaAvaliada))
            {
                bandas[bandaAvaliada].Add(notaBanda);
            }
            else
            {
                Console.WriteLine("Banda não Encontrada.");
            }

            Thread.Sleep(2000);
            Console.Clear();
            ExibirMenuOpcoes();
        }

        void mediaDaBanda()
        {
            Console.Clear();
            printTitulo("Media de uma banda");

            exibirBandas();
            Console.Write("Digite o nome da banda que deseja ver a média: ");
            String bandaEscolhida = Console.ReadLine()!;

            if (bandas.ContainsKey(bandaEscolhida))
            {
                Console.WriteLine($"A banda {bandaEscolhida} tem uma média de: {bandas[bandaEscolhida].Average().ToString("F")}");
            } else
            {
                Console.WriteLine("Banda não Encontrada");
            }

            Thread.Sleep(2000);
            Console.Clear();
        }

        ExibirMenuOpcoes();
    }
}