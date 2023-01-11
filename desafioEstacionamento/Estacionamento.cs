using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioEstacionamento
{
    public class Estacionamento
    {
        static void Main() { }
        decimal precoInicial = 0;
        decimal precoPorHora = 0;
        List<string> veiculos = new List<string>();

        public Estacionamento(decimal PrecoInicial, decimal PrecoPorHora)
        {
            this.precoInicial = PrecoInicial;
            this.precoPorHora = PrecoPorHora;

        }
        public void AdicionarVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo:");
            veiculos.Add(Console.ReadLine());

        }
        public void RemoveVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para remove-lo:");

            string placa = "";
            placa = Console.ReadLine();

            if (veiculos.Any(x=> x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu no estacionamento:");

                int horas = 0;
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(Console.ReadLine());

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Esse veículo não está estacionado aqui. Confira se digitou a placa corretamente!");
            }

        }

        public void ListarVeiculos()
        {

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //eiculos.ForEach(i => Console.WriteLine(i.ToString()));
                foreach(var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos no estacionamento!");
            }


            



        }


    }
}
