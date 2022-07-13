using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_Car.Comprador
{
    internal class Comprador
    {
        public Comprador(string dadosVeiculo, string cPF, decimal valor, int data)
        {
            DadosVeiculo = dadosVeiculo;
            CPF = cPF;
            Valor = valor;
            Data = data;
        }

        public string DadosVeiculo { get; set; }
        public string CPF { get; set; }
        public decimal Valor { get; set; }
        public  int Data { get; set; }
    }
}
