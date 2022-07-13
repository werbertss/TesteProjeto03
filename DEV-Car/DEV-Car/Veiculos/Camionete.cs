using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Veiculos
{
    public class Camionete: Veiculo
    {
        public Camionete(string nome, int totalDePortas, int capacidadeDeCarregamentoNaCacanba, int potenciaEmCavalos, string combustivel, int numeroDoChassi, int dataFrabicacao, string placa, string cor, int valor) : base (nome, numeroDoChassi, dataFrabicacao, placa, cor, valor)
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
        
        //Fabricado somente cor Roxa
        public string Cor { get; set; }
    }
}
