using UrbanDrive.Modelos.Entidades;

Veiculo veiculo = new Veiculo(
    1,
    "ABC-1234",
    "Toyota Corolla",
    150
);

CNH cnh = new CNH(
    "12345678900",
    "B",
    DateTime.Today.AddYears(3)
);

Motorista motorista = new Motorista("Anna", cnh);
motorista.AdicionarVeiculo(veiculo);

Console.WriteLine("=== URBANDRIVE ===");
Console.WriteLine();

Console.WriteLine("=== DADOS DO VEÍCULO ===");
Console.WriteLine($"ID: {veiculo.Id}");
Console.WriteLine($"Modelo: {veiculo.Modelo}");
Console.WriteLine($"Placa: {veiculo.Placa}");
Console.WriteLine($"Aluguel para 3 dias: {veiculo.CalcularAluguel(3):C}");

Console.WriteLine();
Console.WriteLine("=== DADOS DO MOTORISTA ===");
motorista.ExibirInformacoes();
