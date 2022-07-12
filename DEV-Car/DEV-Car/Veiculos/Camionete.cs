using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculos
{
    public class Camionete: Veiculo
    {
        public Camionete(int totalDePortas, int capacidadeDeCarregamentoNaCacanba, int potenciaEmCavalos, string combustivel, int numeroDoChassi, int dataFrabicacao, string nome, string placa, decimal valor, decimal cPF, string cor) : base (numeroDoChassi, dataFrabicacao, nome, placa, valor, cPF, cor)
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
}
