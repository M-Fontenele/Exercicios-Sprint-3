﻿using System;
using ByteBank2.Models;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente1 = new ContaCorrente(1,1, "Alexandre");
            ContaCorrente contaCorrente2 = new ContaCorrente(1,2, "Cesar");
            
            ContaEspecial contaEspecial1 = new ContaEspecial(1,2, "Cesar");
        }
    }
}
