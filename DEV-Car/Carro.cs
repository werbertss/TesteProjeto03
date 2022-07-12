using System;
namespace Veiculos;

public class Carro
{
	public Carro(int totalDePortas, string tipoCombustivel, int potenciaEmCavalos)
    {
        TotalDePortas = totalDePortas;
        TipoCombustivel = tipoCombustivel;
        PotenciaEmCavalos = potenciaEmCavalos;
    }
    public int TotalDePortas { get; set; }
	public string TipoCombustivel { get; set; }
	public int PotenciaEmCavalos { get; set; }
}
