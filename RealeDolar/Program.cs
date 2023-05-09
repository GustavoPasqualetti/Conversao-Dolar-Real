using RealeDolar;

string opcao;

do
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($@"
1- Conversao de Dolar para Real
2- Conversao de Real para Dolar
3- Sair do sistema
");
    opcao = Console.ReadLine();
    Console.ResetColor();
    switch (opcao)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Digite o valor em dolar que deseja converter para real");
            float Dolar = float.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine($"");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Valor convertido em: ");
            Console.Write(Conversao.DolarParaReal(Dolar));
            Console.Write($"R$");
            Console.WriteLine($"");
            Console.ResetColor();
            break;
        case "2":
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Digite o valor em Reais que deseja converter para Dolar");
            Console.ResetColor();
            float Real = float.Parse(Console.ReadLine());
            Console.WriteLine($"");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Valor convertido em: ");
            Console.Write(Conversao.RealParaDolar(Real));
            Console.WriteLine($"$");
            Console.WriteLine($"");
            Console.ResetColor();
            break;
        case "3":
            static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
            {
                Console.Write(texto);

                for (var i = 0; i < quantidadePontinhos; i++)
                {
                    Console.Write($".");
                    Thread.Sleep(tempo);
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            BarraCarregamento("Saindo do Sistema", 3,600);
            Console.ResetColor();
            break;
        default:
            Console.WriteLine($"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"opcao invalida");
            Console.ResetColor();
            break;
    }

} while (opcao != "3");