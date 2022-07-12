using System;
namespace Veiculos;

public class Camionete
{	
    public Camionete(int totalDePortas, int capacidadeDeCarregamentoNaCacanba, int potenciaEmCavalos, string combustivel)
    {
        TotalDePortas = totalDePortas;
        CapacidadeDeCarregamentoNaCacanba = capacidadeDeCarregamentoNaCacanba;
        PotenciaEmCavalos = potenciaEmCavalos;
        Combustivel = combustivel;
    }
    public int TotalDePortas { get; set; }
	public int CapacidadeDeCarregamentoNaCacanba { get; set; }
	public int PotenciaEmCavalos { get; set; }
	public string Combustivel { get; set; }

	public string Cor { get; set; }
}
