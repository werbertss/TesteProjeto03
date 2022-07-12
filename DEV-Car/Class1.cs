using System;
namespace Veiculos;

public class Class1
{
	public Class1(int numeroDoChassi, int dataFrabicacao, string nome, string placa, decimal valor, decimal cPF, string cor)
    {
        NumeroDoChassi = numeroDoChassi;
        DataFrabicacao = dataFrabicacao;
        Nome = nome;
        Placa = placa;
        Valor = valor;
        CPF = cPF;
        Cor = cor;

        VenderVeiculo();
        ListarInformacoes();
        AlterarInformacoes();
    }

    public int NumeroDoChassi {get; set;}
	public int DataFrabicacao {get; set;}
	public string Nome {get; set;}
	public string Placa { get; set; }
	public decimal Valor { get; set; }

	public decimal CPF { get; set; }
	public string Cor { get; set; }

    public void VenderVeiculo()
    {
    }

    public void ListarInformacoes()
    {    
    }

    public void AlterarInformacoes()
    {
    }

}
