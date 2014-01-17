using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForcaTDD
{
    class SorteioPalavra
    {
        public static string RetornaPalavraSorteada()
        {
            var random = new Random();
            var listaPalavars = new List<string> {"BLUMENAU", 
                                                  "ITAJAI", 
                                                  "CHAPECO",
                                                  "FLORIANOPOLIS",
                                                  "POMERODE",
                                                  "INDAIAL"};

            return listaPalavars[random.Next(listaPalavars.Count)];
        }
    }
}