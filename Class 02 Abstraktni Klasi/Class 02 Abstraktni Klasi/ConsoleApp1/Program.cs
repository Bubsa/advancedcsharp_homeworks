﻿// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Entities.BaseEntity;
using ConsoleApp1.Entities.Models;

Console.WriteLine("Hello, World!");

#region
Developer devOne = new Developer(1, "Bob", "Bobsky", 23, "123-123-1234", new List<string> {"JavaScript", "C#", "Java"}, 150);

Tester testerOne = new(2, "Jill", "Wayne", 32, "234-234-2345", 14);

Operations opsOne = new(3, "Greg", "Gregsky", 38, "345-345-3456", new List<string> { "Optimus", "PickPro", "ProtoBeat" });

DevOps devOpsOne = new(4, "John", "Doe", 50, "456-456-4567", false, true);

QAEngineer qaOne = new(5, "Steve", "Stevenson", 33, "567-567-5678", new List<string> { "Selenium", "Puppeteer" });

//Human human = new Human

// ABSTRAKTNI KLASI SE SEKOGASH ISKORISTUVANI VO KLASI OD KADE SHO SE NASLEDUVA. TOA E NESHTO VO PRAKSA SHO SE ISKORISTUVA SEKOGAS DA GO ZASHTITIME KODOT OD POTENCIJALNI PROBLEMI
#endregion