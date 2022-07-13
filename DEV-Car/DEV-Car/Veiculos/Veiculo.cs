using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculos
{
    public class Veiculo
    {
        public Veiculo(string nome,int numeroDoChassi, int dataFrabicacao, string placa, string cor, int valor)
        {
            NumeroDoChassi = numeroDoChassi;
            DataFrabicacao = dataFrabicacao;
            Nome = nome;
            Placa = placa;
            Valor = valor;
            Cor = cor;

            //
        }

        public int NumeroDoChassi { get; set; }
        public int DataFrabicacao { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public int Valor { get; set; }

        public string Cor { get; set; }

        //Virtual significa que o metodo pode ser alterado. Polimorfismo
        public virtual void VenderVeiculo()
        {
        }

        //Virtual significa que o metodo pode ser alterado. Polimorfismo
        public virtual void ListarInformacoes()
        {
        }

        //Virtual significa que o metodo pode ser alterado. Polimorfismo
        public virtual void AlterarInformacoes()
        {
        }

    }
}