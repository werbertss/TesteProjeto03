using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculos
{
    public class MotoTriciclo : Veiculo
    {
        public MotoTriciclo(string nome, int potencia, int totalDeRodas, int numeroDoChassi, int dataFrabicacao, string placa, string cor, int valor) : base(nome, numeroDoChassi, dataFrabicacao, placa, cor, valor)
        {
            Potencia = potencia;
            TotalDeRodas = totalDeRodas;
        }

        public int Potencia { get; set; }
        public int TotalDeRodas { get; set; }
    }
}
