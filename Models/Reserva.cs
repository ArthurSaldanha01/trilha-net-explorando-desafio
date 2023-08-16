using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa_de_hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes;
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        
        public Reserva(){}
        public Reserva(int diasreservados){
            this.DiasReservados = diasreservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            //Verifica se a capacidade é maior ou igual ao número de hóspedes recebido
            if (hospedes.Count <= Suite.Capacidade){

                this.Hospedes = hospedes;

            }
            else
            {
                //Retorna uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("Capacidade insuficiente para o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite){
            this.Suite = suite;
        }

        public int ObterQuantidadeHospedes(){
            //Retona a quantidade de hóspedes
            return Hospedes.Count;
        }
        
        public decimal CalcularValorDiaria()
        {
            //Retorna o valor da diária
            //Cálculo: DiasReservados x Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            //Caso os dias reservados forem maior ou igual a 10, conceda um desconto de 10%
            if (DiasReservados >= 10){
                valor -= valor * 0.1m; //Aplicando desconto de 10%
            }

            return valor;
        }
       
    }
}