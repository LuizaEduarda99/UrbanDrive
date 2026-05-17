using System;

namespace UrbanDrive.Modelos.Entidades
{
    public class Veiculo
    {
        // ATRIBUTO PRIVADO (Encapsulamento)
        private string _placa = string.Empty;

        // PROPRIEDADES
        public int Id { get; set; }

        public string Placa
        {
            get => _placa;

            set
            {
                // VALIDAÇÃO
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A placa não pode estar vazia.");
                }

                _placa = value;
            }
        }

        public string Modelo { get; set; } = string.Empty;

        public decimal ValorDiaria { get; set; }

        // CONSTRUTOR VAZIO
        public Veiculo()
        {
        }

        // CONSTRUTOR PARAMETRIZADO
        public Veiculo(int id, string placa, string modelo, decimal valorDiaria)
        {
            Id = id;
            Placa = placa;
            Modelo = modelo;
            ValorDiaria = valorDiaria;
        }

        // MÉTODO
        public virtual decimal CalcularAluguel(int dias)
        {
            return ValorDiaria * dias;
        }
    }
}
