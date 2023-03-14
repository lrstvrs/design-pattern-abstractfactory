﻿using AbstractFactory.Fabricas;
using AbstractFactory.Interface;

IFabricaBases fabrica;

Console.Write("Escolha um dos personagens: 1 - Protoss | 2 - Zergs | 3 - Terranos ");
Console.WriteLine();

switch (Console.ReadLine())
{
    case "1":
        fabrica = new FabricaBaseProtoss();
        break;
    case "2":
        fabrica = new FabricaBaseZerg();
        break;
    case "3":
        fabrica = new FabricaBaseTerran();
        break;
}
Console.ReadLine();