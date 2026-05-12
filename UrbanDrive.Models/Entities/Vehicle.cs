using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanDrive.Models.Entities
{
    public class Vehicle
    {
        // ATRIBUTO PRIVADO (Encapsulamento)
        private string _plate;

        // PROPRIEDADES
        public int Id { get; set; }

        public string Plate
        {
            get => _plate;

            set
            {
                // VALIDAÇÃO
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Plate cannot be empty.");
                }

                _plate = value;
            }
        }

        public string Model { get; set; }

        public decimal DailyRate { get; set; }

        // CONSTRUTOR VAZIO
        public Vehicle()
        {

        }

        // CONSTRUTOR PARAMETRIZADO
        public Vehicle(int id, string plate, string model, decimal dailyRate)
        {
            Id = id;
            Plate = plate;
            Model = model;
            DailyRate = dailyRate;
        }

        // MÉTODO
        public virtual decimal CalculateRental(int days)
        {
            return DailyRate * days;
        }
    }
}