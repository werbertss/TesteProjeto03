using System;
namespace Veiculos;

public class MotoTriciclo : Veiculo
{
	public MotoTriciclo(int potencia, int totalDeRodas): base (int numeroDoChassi, int dataFrabicacao, string nome, string placa, decimal valor, decimal cPF, string cor)
    {
        Potencia = potencia;
        TotalDeRodas = totalDeRodas;
    }

    public int Potencia { get; set; }
	public int TotalDeRodas { get; set; }
}
