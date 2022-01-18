using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parque_de_estacionamento;


namespace Parque_de_estacionamento

{
    using System;

    public static class Menus
    {

        public static void MenuGeral() //Menu Principal
        {

            
            Console.WriteLine(" ________________________________________________ ");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|____________        Bem Vindo       ____________|");
            Console.WriteLine("|____________  Sistema Parquímetro   ____________|");
            Console.WriteLine("|            Data: "+ DateTime.Now + "           |");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|               1 - Administrador                |");
            Console.WriteLine("|               2 - Cliente                      |");
            Console.WriteLine("|               3 - Sair                         |");
            Console.WriteLine("|________________________________________________|\n");

            Console.WriteLine("Escolha a opção pretendida -> ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                int code = 1234;
                int tentativas = 0;


                for (; ; )
                    if (tentativas < 3 && tentativas != 3)
                    {
                        Console.WriteLine("Introduza o pin com quatro dígitos:");
                        int pin = Convert.ToInt32(Console.ReadLine());

                        if (pin == code)
                        {
                            Console.WriteLine("Código correto");
                            Menus.MenuAdmin();
                            break;
                        }
                        if (tentativas == 3)
                        {
                            Console.WriteLine("Administrador bloqueado");
                            System.Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Código incorreto");
                            tentativas++;
                            Console.WriteLine("Possui " + (3 - tentativas) + " tentativas");
                        }

                    }
            }
            switch (opcao)
            {
                case 2:
                    MenuCliente();
                    break;

                case 3:
                    System.Environment.Exit(3);
                    break;
                default:

                    break;
            }

        }

        public static void MenuAdmin()
        {
            Console.Clear();
            Console.WriteLine(" ________________________________________________ ");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|____________     Administrador      ____________|");
            Console.WriteLine("|____________  Sistema Parquímetro   ____________|");
            Console.WriteLine("|            Data: " + DateTime.Now + "           |");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|               1 - Ver Zonas                    |");
            Console.WriteLine("|               2 - Ver Histórico                |");
            Console.WriteLine("|               3 - Início                       |");
            Console.WriteLine("|               4 - Sair                         |");
            Console.WriteLine("|________________________________________________|\n");

            Console.WriteLine("Escolha a opção pretendida -> ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Zonas.EscolherZonasAdmin();

                    break;
                case 2:
                    Zonas.ZonasHistoricoAdmin();

                    break;
                case 3:
                    Menus.MenuGeral();
                    break;
                case 4:
                    System.Environment.Exit(4);
                    break;
                default:

                    break;
            }
        }

        public static void MenuCliente()
        {
            
            Console.WriteLine(" ________________________________________________ ");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|____________         Cliente        ____________|");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|               1 - Ver zonas para Estacionar    |");
            Console.WriteLine("|               2 - Voltar                       |");
            Console.WriteLine("|               3 - Sair                         |");
            Console.WriteLine("|________________________________________________|\n");

            Console.WriteLine("Escolha a opção pretendida -> ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Zonas.EscolherZonas();
                    break;
                case 2:
                    Menus.MenuGeral();
                    break;
                case 3:
                    System.Environment.Exit(3);
                    break;
                default:

                    break;
            }

        }
    }
}
