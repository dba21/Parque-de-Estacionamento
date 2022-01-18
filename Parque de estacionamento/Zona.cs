using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parque_de_estacionamento;

namespace Parque_de_estacionamento
{
    public class Zona
    {
        //vairaveis da class
        public int numZona;
        public int duracaoMaxima;
        public double precoHora;
        public int numMaxLugares;
        public int contador;
        public double total;
        public Ticket[] estacionamentos;
        //public int lugarOcupado;

        
    //parametros do construtor da class
        public Zona(int numZona,int duracaoMaxima, double precoHora, int numMaxLugares, double total, int contador)
        {
            this.numZona = numZona;
            this.duracaoMaxima = duracaoMaxima;
            this.precoHora = precoHora;
            this.numMaxLugares = numMaxLugares;
            this.contador = contador;
            estacionamentos = new Ticket[numMaxLugares];
            Zonas.adicionarZona(this);
        }

        public int EstacionamentosOcupados()
        {

            contador = 0;

            for(int i=0; i<estacionamentos.Length; i++)
            {
                if (estacionamentos[i] != null)
                {
                    contador++;
                }

            }
            
            return contador;
        }
       


        public double lucroTotal ()
        {
            total = 0;

            for (int i = 0; i<estacionamentos.Length; i++)
            {
                if (estacionamentos[i] != null)
                {
                    total = total + estacionamentos[i].valorInserido;
                }
            }
            return total;
        }

    }
}
