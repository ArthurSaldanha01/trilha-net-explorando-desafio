using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa_de_hospedagem.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public string InfoCompleta => $"Tipo da suíte: {TipoSuite}\nCapacidade: {Capacidade}\nValor da Diária: {ValorDiaria}".ToUpper();

        public Suite(){}

        public Suite(string tiposuite, int capacidade, decimal valordiaria){
            this.TipoSuite = tiposuite;
            this.Capacidade = capacidade;
            this.ValorDiaria = valordiaria;
        }
    }
}