using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa_de_hospedagem.Models
{
    public class Pessoa
    {
        //Atributos
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string nomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        //Construtores
        
        public Pessoa(){ }

        public Pessoa(string nome){

            Nome = nome;

        }

        public Pessoa(String nome, string sobrenome){

            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}