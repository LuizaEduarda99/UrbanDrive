using System;
using System.Collections.Generic;

namespace UrbanDrive.Modelos.Entidades
{
    public class Motorista
    {
        public string Nome { get; set; }

        // Composição: a CNH pertence ao motorista.
        public CNH Cnh { get; set; }

        // Associação com veículos.
        public List<Veiculo> Veiculos { get; set; }

        public Motorista(string nome, CNH cnh)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do motorista não pode estar vazio.");
            }

            Nome = nome;
            Cnh = cnh;
            Veiculos = new List<Veiculo>();
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
        }

        public bool PodeDirigir()
        {
            return Cnh.EstaValida();
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Motorista: {Nome}");
            Console.WriteLine(Cnh);
            Console.WriteLine($"Pode dirigir: {(PodeDirigir() ? "Sim" : "Não")}");

            Console.WriteLine("Veículos associados:");

            foreach (var veiculo in Veiculos)
            {
                Console.WriteLine($"- {veiculo.Modelo} | Placa: {veiculo.Placa}");
            }
        }
    }
}
