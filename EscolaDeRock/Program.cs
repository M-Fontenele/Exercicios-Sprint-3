﻿using System;
using System.Collections.Generic;
using EscolaDeRock.Models;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock
{
    enum FormacaoEnum : int 
    {
        TRIO = 3,
        QUARTETO
    };

    enum InstrumentosEnum : int
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLÃO
    };

    enum CategoriaEnum : int
    {
        HAMONIA,
        PERCUSSÃO,
        MELODIA
    };

    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;

            string[] itensMenuPrincipa = Enum.GetNames(typeof(FormacaoEnum));
            string[] intensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                "      - 0                    ",
                "      - 1                    "
            };

            int opcoesFormacaoSelecionada = 0;
            string menuBar = "==================================";

            do 
            {
                bool formacaoEscolhida = false;

                do
                {
                    #region Area do menu
                    Console.Clear();
                    Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("    Seja bem-vind@!          ");
                    Console.WriteLine("    Escolha uma formação:    ");
                    Console.ResetColor();
                    Console.WriteLine(menuBar);

                    for(int i = 0; i < opcoesFormacao.Count; i++)
                    {
                        string titulo = itensMenuPrincipa[i];
                        if(opcoesFormacaoSelecionada == i)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(opcoesFormacao[opcoesFormacaoSelecionada].Replace("-",">").Replace(i.ToString(),titulo));
                            Console.ResetColor();
                        } 
                        else
                        {
                            Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(),titulo));
                        }
                    }
                    // * leitura de teclado
                    var key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == 0 ? opcoesFormacaoSelecionada : --opcoesFormacaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                            opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcoesFormacaoSelecionada : ++opcoesFormacaoSelecionada;
                            break;
                        case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                            break;
                    }
                } while(!formacaoEscolhida);
                
            #endregion

            } while(!querSair);
        }
    }
}
