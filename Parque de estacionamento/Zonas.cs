using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parque_de_estacionamento;

namespace Parque_de_estacionamento
{

public class Zonas
{

    public static Zona[] zonas = new Zona[3];

    public static double lucroTotalAdmin = 0;
    public static double tempEstacionamento;

    public static int estaciOcupado = 0;

    //public static double duracaoMaxima { get; set; }

    public static bool estacionamentoAceite;

    public static DayOfWeek diaAceite;

        public static Zona[] buscarZonas()
        {
            return zonas;
        }


    public static void adicionarZona(Zona zona)
        {
            for (int i = 0; i < zonas.Length; i++)
            {
                if (zonas[i] == null)
                {
                    zonas[i] = zona;
                    return;
                }
            }
        }
     




    //Funções do Admin

    public static void EscolherZonasAdmin()
    {

        Console.Clear();
        Console.WriteLine(" ________________________________________________ ");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|____________     Administrador      ____________|");
        Console.WriteLine("|____________  Zonas a selecionar    ____________|");
        Console.WriteLine("|           Data: " + DateTime.Now + "            |");
        Console.WriteLine("|             Horário dos dias úteis             |");
        Console.WriteLine("|                 9:00h - 20:00h                 |");
        Console.WriteLine("|              Horário dos Sábados               |");
        Console.WriteLine("|                 9:00h - 14:00h                 |");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|__________Escolha a Zona de Parquímetro_________|");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|                 1 - Zona 1                     |");
        Console.WriteLine("|                 2 - Zona 2                     |");
        Console.WriteLine("|                 3 - Zona 3                     |");
        Console.WriteLine("|                 4 - Voltar                     |");
        Console.WriteLine("|                 5 - Sair                       |");
        Console.WriteLine("|________________________________________________|");
        Console.WriteLine();

        Console.WriteLine("Escolha a opção pretendida -> ");
        int opcao = Convert.ToInt32(Console.ReadLine()); //Selecionar Zona

            //Definindo a Zona
            Zona z1 = Zonas.buscarZonas()[0];
            Zona z2 = Zonas.buscarZonas()[1];
            Zona z3 = Zonas.buscarZonas()[2];

            switch (opcao)
        {
            case 1:
                ZonaSelecionadaAdmin(z1);

                break;

            case 2:
                ZonaSelecionadaAdmin(z2);

                break;

            case 3:
                ZonaSelecionadaAdmin(z3);

                break;

            case 4:
                Menus.MenuGeral();
                break;

            case 5:
                System.Environment.Exit(5);
                break;
             default:

                    break;
            }
    }

    public static void ZonaSelecionadaAdmin(Zona zona)
    {

        Console.Clear();
        Console.WriteLine(" ________________________________________________ ");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|____________     Administrador      ____________|");
        Console.WriteLine("|____________  Zonas a selecionar    ____________|");
        Console.WriteLine("|           Data: " + DateTime.Now + "            |");
        Console.WriteLine("|             Horário dos dias úteis             |");
        Console.WriteLine("|                 9:00h - 20:00h                 |");
        Console.WriteLine("|              Horário dos Sábados               |");
        Console.WriteLine("|                 9:00h - 14:00h                 |");
        Console.WriteLine("|                                                |");

       if (zona.numZona == 3)
        {
        Console.WriteLine("|   Zona " + zona.numZona + " tempo ilimitado de estacionamento    |\n| e um custo de " + zona.precoHora + "€ por hora.                  |");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|   Tem neste momento " + zona.EstacionamentosOcupados() + " lugares ocupados.        |");
        Console.WriteLine("|   Neste momento tem um lucro total de " +  zona.lucroTotal() + " €.   |");
        }
        else
        {
        Console.WriteLine("|   Zona " + zona.numZona + " tem uma duração máxima de " + zona.duracaoMaxima + " minutos  |\n| e um custo de " + zona.precoHora + "€ por hora.                  |");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|   Tem neste momento tem " + zona.EstacionamentosOcupados() + " lugares ocupados.    |");
        Console.WriteLine("|   Neste momento tem um lucro total de "+ (decimal)zona.lucroTotal() + " €.   |");
        }
        Console.WriteLine("|                                                |");
        Console.WriteLine("|         1 - Início Menu Administrador          |");
        Console.WriteLine("|         2 - Menu Principal                     |");
        Console.WriteLine("|________________________________________________|\n");

            Console.WriteLine("Escolha a opção pretendida -> ");
        int opcao = Convert.ToInt32(Console.ReadLine()); //Selecionar
            
            switch (opcao)
        {
            case 1:
                Menus.MenuAdmin();
                break;
            case 2:
                Menus.MenuGeral();
                break;
        }

    }
        public static void ZonasHistoricoAdmin()
        {

            double lucroTotalA = Zonas.buscarZonas()[0].lucroTotal() + Zonas.buscarZonas()[1].lucroTotal() + Zonas.buscarZonas()[2].lucroTotal();
            double estacionamentosOcupadosA = Zonas.buscarZonas()[0].EstacionamentosOcupados() + Zonas.buscarZonas()[1].EstacionamentosOcupados() + Zonas.buscarZonas()[2].EstacionamentosOcupados();
            decimal lucroTotalA1 = (decimal)lucroTotalA;

            Console.Clear();
            Console.WriteLine(" ________________________________________________ ");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|____________     Administrador      ____________|");
            Console.WriteLine("|          Histórico diário das Zonas            |");
            Console.WriteLine("|          Data: " + DateTime.Now + "             |");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|  O seu lucro total diário é de " + lucroTotalA1 + "€.          |");
            Console.WriteLine("|  Neste momento tem um total de carros " + estacionamentosOcupadosA + "        |\n| estacionados.                                  |");
            Console.WriteLine("|                                                |");
            Console.WriteLine("|      1 - Início Menu Administrador             |");
            Console.WriteLine("|      2 - Menu Principal                        |");
            Console.WriteLine("|________________________________________________|\n");

            Console.WriteLine("Escolha a opção pretendida -> ");
            int opcao = Convert.ToInt32(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    Menus.MenuAdmin();
                    break;
                case 2:
                    Menus.MenuGeral();
                    break;
            }
        }




        //Funções do Cliente
        public static void EscolherZonas()
    {

        
        Console.WriteLine(" ________________________________________________ ");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|____________         Cliente        ____________|");
        Console.WriteLine("|____________   Zonas a selecionar   ____________|");
        Console.WriteLine("|           Data: " + DateTime.Now + "            |");
        Console.WriteLine("|             Horário dos dias úteis             |");
        Console.WriteLine("|                 9:00h - 20:00h                 |");
        Console.WriteLine("|              Horário dos Sábados               |");
        Console.WriteLine("|                 9:00h - 14:00h                 |");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|_________Escolha a Zona de Parquímetro__________|");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|               1 - Zona 1                       |");
        Console.WriteLine("|               2 - Zona 2                       |");
        Console.WriteLine("|               3 - Zona 3                       |");
        Console.WriteLine("|               4 - Voltar                       |");
        Console.WriteLine("|               5 - Sair                         |");
        Console.WriteLine("|________________________________________________|\n");

        Console.WriteLine("Escolha a opção pretendida -> ");
        int opcaoZ = Convert.ToInt32(Console.ReadLine()); //Selecionar Zona

            Zona z1 = Zonas.buscarZonas()[0];
            Zona z2 = Zonas.buscarZonas()[1];
            Zona z3 = Zonas.buscarZonas()[2];

            switch (opcaoZ)
        {
            case 1:
                ZonaSelecionadaCliente(z1);

                break;

            case 2:
                ZonaSelecionadaCliente(z2);

                break;

            case 3:
                  ZonaSelecionadaCliente(z3);

                break;

            case 4:
                Menus.MenuGeral();
                break;

            case 5:
                System.Environment.Exit(5);
                break;

        }
    }

    //Função para calcular o tempo de estacionamento
    public static double tempoDisponivel(int zona, double valorInserido, double tempoMaxPorZona, double valorMaxPorZona, int numMaxLugares, int estacionamentos)
    {
            int tempEstacionamento1=estacionamentos;
        if (zona == 1)//Valor inserido ao límite
        {
            tempEstacionamento = Math.Round((valorInserido / valorMaxPorZona) * tempoMaxPorZona);
            if (tempEstacionamento <= 45)
            {
                Console.WriteLine("Tem parque disponível por " + tempEstacionamento + " minutos.\n");
                    /*if (tempEstacionamento == tempEstacionamento)
                    {
                        estacionamentos--;
                    }*/


            }
            else
            {
                    tempEstacionamento = 0;
                Console.WriteLine("Tempo limite ultrapasado, insira um valor igual inferior\n ou escolha outra zona para estacionar, o seu dinheiro vai ser devolvido.\n");
                Console.WriteLine("O valor devolvido é " + valorInserido + " €.");
                    
                    EscolherZonas();
            }

        }
        else if (zona == 2)
        {
            tempEstacionamento = Math.Round((valorInserido / valorMaxPorZona) * tempoMaxPorZona);
            if (tempEstacionamento <= 120)
            {
                Console.WriteLine("Tem parque disponível por " + tempEstacionamento + " minutos.\n");
            }
            else
            {
                 tempEstacionamento = 0;
                Console.WriteLine("Tempo limite ultrapasado, insira um valor igual inferior ou \n escolha outra zona para estacionar, o seu dinheiro vai ser devolvido.");
                Console.WriteLine("O valor devolvido é " + valorInserido + " €.");
                
                    
                    EscolherZonas();
            }

        }
        else if (zona == 3)
        {
                tempEstacionamento = Math.Round((valorInserido / valorMaxPorZona) * tempoMaxPorZona);
                if (tempEstacionamento >= 0)
                {
                    Console.WriteLine("Tem parque disponível por " + tempEstacionamento + " minutos.");
                }
            }

            return tempEstacionamento;
        }



    //Função que devolve um true dentro do horário do dia
    public static bool HorarioDeFuncionamento(DayOfWeek diaAceite)
    {

            diaAceite = DateTime.Now.DayOfWeek;

        if (diaAceite != DayOfWeek.Sunday && diaAceite != DayOfWeek.Saturday && DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 20)
        {
            estacionamentoAceite = true;

        }
        else if (diaAceite != DayOfWeek.Sunday && DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 14)
        {
            estacionamentoAceite = true;
        }
        else
        {
            estacionamentoAceite = false;
        }
        return estacionamentoAceite;
    }




    public static void ZonaSelecionadaCliente(Zona zona)
    {
        int lugDisponiveis = zona.numMaxLugares - zona.EstacionamentosOcupados();

        Console.WriteLine(" ________________________________________________ ");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|____________         Cliente        ____________|");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|               Zona " + zona.numZona + " Selecionada               |");
        Console.WriteLine("|                                                |");

        if (zona.numZona == 3)
        {
        Console.WriteLine("|   Zona " + zona.numZona + " tempo ilimitado de estacionamento     |\n| e um custo de " + zona.precoHora + "€ por hora.                  |");
        }
        else
        {
        Console.WriteLine("|   Zona " + zona.numZona + " tem uma duração máxima de " + zona.duracaoMaxima +" minutos  |\n| e um custo de " + zona.precoHora + "€ por hora.                  |");
        }
        Console.WriteLine("|                                                |");
        Console.WriteLine("|   Tem neste momento " + lugDisponiveis + " lugares disponíveis.    |");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|          Deseja estacionar aqui?               |");
        Console.WriteLine("|               1 - Sim                          |");
        Console.WriteLine("|               2 - Não                          |"); //Menu Principal ou Sair
        Console.WriteLine("|               3 - Voltar                       |");
        Console.WriteLine("|________________________________________________|\n");

        Console.WriteLine("Escolha a opção pretendida -> ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
           // case 1:

               // break;
            case 2:
                EscolherZonas();
                break;
            case 3:
                Menus.MenuGeral();
                break;

        }

            string  matricula = "";
            int nif = 0;
            bool parar2 = true;

            Console.WriteLine("Quer imprimir no ticket a matrícula do seu carro e o seu NIF? \n Se sim coloque 's' e Enter, se não coloque 'n' e Enter.");
            if (Console.ReadLine() == "s") 
            {

                Console.WriteLine("\n Coloque a sua matrícula com o seguinte formato 00-AA-00.");
                matricula = (Console.ReadLine());

                Console.WriteLine("\n Introduza o seu NIF");
                nif = int.Parse(Console.ReadLine());

                while (nif.ToString().Length != 9)
                {
                    Console.WriteLine("\n O seu NIF deve ser composto por nove números, tente novamente.");
                    nif = int.Parse(Console.ReadLine());
                }
                parar2 = true;
            }
            else 
            
                parar2 = true;
                while (parar2 == true)
                {

                    Console.WriteLine("\n Insira o dinheiro.");
                    double valorInserido = Convert.ToDouble(Console.ReadLine());
                    
                    double valorMaxPorHora = zona.precoHora * zona.duracaoMaxima / 60; //Ex. Zona1:(1.15 * 45)/60
                    double tempoMaxPorZona = zona.duracaoMaxima;

                    double tempoDisp = tempoDisponivel(zona.numZona, valorInserido, tempoMaxPorZona, valorMaxPorHora, zona.numMaxLugares, zona.contador);


                    if (HorarioDeFuncionamento(DateTime.Now.DayOfWeek) == true && tempoDisp != 0)
                    {
                        estacionar(zona, matricula, nif, valorInserido, tempoDisp);
                          lucroTotalAdmin += valorInserido;
                          estaciOcupado++;
                    
                     }
                    else
                    {

                        Console.WriteLine("Esta fora do horário de cobrança e será reembolsado o valor inserido " + valorInserido + "€.");
                        valorInserido = 0;
                        Menus.MenuCliente();
                        parar2 = false;
                    }


                }

            }

              static void estacionar(Zona zona, string matricula, double nif, double valorInserido, double tempoDisp)
            {

                Ticket t = new Ticket(matricula, nif, valorInserido, DateTime.Now, DateTime.Now.AddMinutes(tempoDisp), zona);



                for (int lugarOcupado = 0; lugarOcupado < zona.estacionamentos.Length; lugarOcupado++)
                {
                    if (zona.estacionamentos[lugarOcupado] == null) //Se tiver lugar ocupado, não emite
                    {
                        zona.estacionamentos[lugarOcupado] = t; // Se lugar livre, emite o ticket e ocupa um lugar
                        break;
                    }
     
                }
                
                Console.WriteLine("Ticket: " + t.numTicket);
                Console.WriteLine("Zona: " + t.zona.numZona);
                Console.WriteLine("Matrícula: " + t.matricula);
                Console.WriteLine("Nº Contribuinte: " + t.nif);
                Console.WriteLine("Valor Pago: " + t.valorInserido + " €");
                Console.WriteLine("Início: " + t.horaInicio);
                Console.WriteLine("Fim: " + t.horaFim);

                //Vai emitir o ticket e regressar ao Menu Inicial, sem apagar o ticket anterior
                Menus.MenuGeral();
            }
        }
            

    }


