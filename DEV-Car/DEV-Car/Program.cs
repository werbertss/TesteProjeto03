// See https://aka.ms/new-console-template for more information
using DEV_Car.Veiculos;
using DEV_Car.CadastrosVeiculos;
using DEV_Car.CadastrosVeiculos.Carros;
using System;

CadastroCarros();




MostrarMenu();
static void MostrarMenu()
{
    Console.WriteLine("Bem Vindo a Montadora DEVCar!!!");
    Console.WriteLine("---------------------------------------------------------");
    Console.WriteLine("Digite respectivamente, para selecionar a opção desejada.");
    Console.WriteLine("1 - Moto/Triciclo");
    Console.WriteLine("2 - Carro");
    Console.WriteLine("3 - Camionete");
    Console.WriteLine("4 - Todos");
    Console.WriteLine("0 - Para voltar");
    Console.WriteLine("Digite:");
}

LerMenu();
static void LerMenu()
{
    var option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 1: Console.WriteLine("Escoleu 1"); break;
        case 2: 
            {
                EscolhaCarro();
                CadastroVeiculosCarros();
                break;
            }; 
        case 3: Console.WriteLine("Escolheu 3"); break;
        case 4: Console.WriteLine("Escolheu 4"); break;
        case 0:
            {
                Console.Clear();
                Environment.Exit(0);
                break;
            }
        default: Console.WriteLine("Não escolheu nenhuma das opções"); break;
    }

}

static void EscolhaCarro()
{
    Console.WriteLine(@"

-------------------------------------------------------------------
");

    Console.WriteLine("Ótima Escolha!");
    Console.WriteLine("Responda outras perguntas");

    Console.WriteLine(@"
-------------------------------------------------------------------
");

    Console.WriteLine("Quantas portas deseja, que o veículo tenha?");
    var QuantidadePortasCarro = Console.ReadLine();
    Console.WriteLine(@$"Você escolheu {QuantidadePortasCarro}
");

    Console.WriteLine("Qual tipo de Combustivel? Flex ou Gasolina?");
    var FlexOuGasolinaCarro = Console.ReadLine();
    Console.WriteLine(@$"Você escolheu {FlexOuGasolinaCarro}
");

    Console.WriteLine("Qual a Portencia em cavalos?");
    var PotenciaCavalosCarro = Console.ReadLine();
    Console.WriteLine(@$"Você escolheu {PotenciaCavalosCarro}
");

    
}


//Desconsiderar Códigos abaixo
static void CadastroCarros()
{
    //Gol
    DEV_Car.CadastrosVeiculos.Carros.Gol.NomeCarro = "Gol";
    DEV_Car.CadastrosVeiculos.Carros.Gol.CorCarro = "Vermelho";
    DEV_Car.CadastrosVeiculos.Carros.Gol.MarcaCarro = "Chevrolet";
    DEV_Car.CadastrosVeiculos.Carros.Gol.CombustivelCarro = "Gasolina";
    DEV_Car.CadastrosVeiculos.Carros.Gol.VelocidadeCarro = ("200");

}


//Desconsiderar códigos abaixo
static void Teste()
{
    Console.WriteLine($@" 
01 Opção:
Carro: {DEV_Car.CadastrosVeiculos.Carros.Gol.NomeCarro}
Cor: {DEV_Car.CadastrosVeiculos.Carros.Gol.CorCarro}
Marca: {DEV_Car.CadastrosVeiculos.Carros.Gol.MarcaCarro}
Combustivel: {DEV_Car.CadastrosVeiculos.Carros.Gol.CombustivelCarro}
Velocidade Maxima: {DEV_Car.CadastrosVeiculos.Carros.Gol.VelocidadeCarro}");
}

static void CadastroVeiculosCarros()
{
    DEV_Car.Veiculos.Carro Gol = new DEV_Car.Veiculos.Carro("Gol", 4, "Gasolina", 70, 5, 2013, "11111", "Azul", 15000);

    DEV_Car.Veiculos.Carro Monza = new DEV_Car.Veiculos.Carro("Monza", 2, "Gasolina", 100, 5, 2001, "1222222", "Preto", 9000);

    //Gol
    Console.WriteLine(@$"
Nome: {Gol.Nome}
Portas: {Gol.TotalDePortas}
Potencia: {Gol.PotenciaEmCavalos}
Chassi: {Gol.NumeroDoChassi}
Ano: {Gol.DataFrabicacao}
Placa: {Gol.Placa}
Cor: {Gol.Cor}
Valor R$: {Gol.Valor}
");

    //Monza
    Console.WriteLine(@$"
Nome: {Monza.Nome}
Portas: {Monza.TotalDePortas}
Potencia: {Monza.PotenciaEmCavalos}
Chassi: {Monza.NumeroDoChassi}
Ano: {Monza.DataFrabicacao}
Placa: {Monza.Placa}
Cor: {Monza.Cor}
Valor R$: {Monza.Valor}
");

    //







    Console.ReadLine();

}




