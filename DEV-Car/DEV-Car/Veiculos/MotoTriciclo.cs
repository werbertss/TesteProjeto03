using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculos
{
    public class MotoTriciclo : Veiculo
    {
        public MotoTriciclo(int potencia, int totalDeRodas, int numeroDoChassi, int dataFrabicacao, string nome, string placa, decimal valor, decimal cPF, string cor) : base(numeroDoChassi, dataFrabicacao, nome, placa, valor, cPF, cor)
        {
            Potencia = potencia;
            TotalDeRodas = totalDeRodas;
        }

        public int Potencia { get; set; }
        public int TotalDeRodas { get; set; }
    }
}
