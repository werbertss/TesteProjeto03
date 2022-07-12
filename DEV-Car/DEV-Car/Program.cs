// See https://aka.ms/new-console-template for more information
using System;
MostrarMenu();
static void MostrarMenu()
{
    Console.WriteLine("Bem Vindo a Montadora DEVCar!!!");
    Console.WriteLine("---------------------------------------------------------");
    Console.WriteLine("Digite respectivamente, para selecionar a opção desejada.");
    Console.WriteLine("1 - Moto/Triciclo");
    Console.WriteLine("2 - Carro");
    Console.WriteLine("3 - Camionete");
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
        case 2: Console.WriteLine("Escolheu 2"); break;
        case 0:
            {
                Console.Clear();
                Environment.Exit(0);
                break;
            }
        default: Console.WriteLine("Não escolheu nenhuma das opções"); break;
    }

    Carro carrinho = new Carro()
}