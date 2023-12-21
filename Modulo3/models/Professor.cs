using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo3.models
{
    public class Professor : Pessoa
    {
        public decimal Salario {get; set;}

        public override void Apresentar()
        {
            Console.WriteLine($"Sou professor e ganho {Salario}");
        }

    }

}