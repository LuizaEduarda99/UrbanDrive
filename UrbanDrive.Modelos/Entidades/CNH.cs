using System;

namespace UrbanDrive.Modelos.Entidades
{
    public class CNH
    {
        public string Numero { get; set; }
        public string Categoria { get; set; }
        public DateTime DataValidade { get; set; }

        public CNH(string numero, string categoria, DateTime dataValidade)
        {
            if (string.IsNullOrWhiteSpace(numero))
            {
                throw new ArgumentException("O número da CNH não pode estar vazio.");
            }

            if (string.IsNullOrWhiteSpace(categoria))
            {
                throw new ArgumentException("A categoria da CNH não pode estar vazia.");
            }

            Numero = numero;
            Categoria = categoria;
            DataValidade = dataValidade;
        }

        public bool EstaValida()
        {
            return DataValidade >= DateTime.Today;
        }

        public override string ToString()
        {
            string situacao = EstaValida() ? "válida" : "vencida";
            return $"CNH: {Numero} | Categoria: {Categoria} | Validade: {DataValidade:dd/MM/yyyy} | Situação: {situacao}";
        }
    }
}
