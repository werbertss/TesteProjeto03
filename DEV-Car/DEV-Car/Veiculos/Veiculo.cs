using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculos
{
    public class Veiculo
    {
        public Veiculo(int numeroDoChassi, int dataFrabicacao, string nome, string placa, decimal valor, decimal cPF, string cor)
        {
            NumeroDoChassi = numeroDoChassi;
            DataFrabicacao = dataFrabicacao;
            Nome = nome;
            Placa = placa;
            Valor = valor;
            CPF = cPF;
            Cor = cor;

            //
        }

        public int NumeroDoChassi { get; set; }
        public int DataFrabicacao { get; set; }
        public string Nome { get; set; }
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
}