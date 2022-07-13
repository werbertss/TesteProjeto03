using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculos
{
    public class Carro: Veiculo
    {
        public Carro(string nome, int totalDePortas, string tipoCombustivel, int potenciaEmCavalos, int numeroDoChassi, int dataFrabicacao, string placa, string cor, int valor) : base(nome, numeroDoChassi, dataFrabicacao, placa, cor, valor)
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
