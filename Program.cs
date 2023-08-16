using Programa_de_hospedagem.Models;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//Cria os modelos de hóspedes e cadastra na lista de hóspedes

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Carlos");
Pessoa p2 = new Pessoa("Ana");

hospedes.Add(p1);
hospedes.Add(p2);

//Cria a suíte

Suite primeiraSuite = new Suite("Premium", 2, 30);

//Cria uma nova reserva, passando a suíte e os hóspedes

Reserva reserva = new Reserva(5);
reserva.CadastrarSuite(primeiraSuite);
reserva.CadastrarHospedes(hospedes);

//Exibe a quantidade de hóspedes e o valor da diária

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

