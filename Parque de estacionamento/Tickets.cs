using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parque_de_estacionamento;

namespace Parque_de_estacionamento
{
    public class Ticket
    {
        //Guarda o troco, matricula, nome do cliente
        //instanciar aqui as variáveis
        
        public Zona zona;
        public static int ticket = 1;
        public int numTicket;
        public string matricula;
        public double nif;
        public double valorInserido;
        public DateTime horaInicio;
        public DateTime horaFim;
        //public double troco;
        public double lucrototal;


        public Ticket(string matricula, double nif, double valorInserido, DateTime horaInicio, DateTime horaFim, Zona zona)
        {
            this.numTicket = ticket++;
            this.matricula = matricula;
            this.nif = nif;
            this.valorInserido = valorInserido;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
            //this.troco = troco; // Não há troco
            
            this.zona = zona;
        }

    }
}

   


