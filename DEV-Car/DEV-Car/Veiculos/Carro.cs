using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculos
{
    public class Carro: Veiculo
    {
        public Carro(int totalDePortas, string tipoCombustivel, int potenciaEmCavalos, int numeroDoChassi, int dataFrabicacao, string nome, string placa, decimal valor, decimal cPF, string cor): base(numeroDoChassi, dataFrabicacao, nome, placa, valor, cPF, cor)
        {
            TotalDePortas = totalDePortas;
            TipoCombustivel = tipoCombustivel;
            PotenciaEmCavalos = potenciaEmCavalos;
        }
        public int TotalDePortas { get; set; }
        public string TipoCombustivel { get; set; }
        public int PotenciaEmCavalos { get; set; }
    }
}
