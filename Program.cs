using System;
using Primeiro;
using CSharp;
using Interface;
using Enum;

namespace CSharp
{ 
    class Progran 
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Jonatas;
            Pessoas pessoa5  = (Pessoas)4;

            Animal animal = new Animal();

            animal.Nome = "Luna";
            animal.NomeDono = "Giuliana";
            animal.Especie = "Gato";

            Pessoa person = new Pessoa();

            person.Nome = "Giovanna";
            person.Idade = 18;
            person.Estado = "SP";

            var person2 = new Pessoa();

            person2.Nome = "Jéssica";
            person2.Idade = 30;
            person2.Estado = "MG";

            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine(pessoa5);
        }
    }
}
