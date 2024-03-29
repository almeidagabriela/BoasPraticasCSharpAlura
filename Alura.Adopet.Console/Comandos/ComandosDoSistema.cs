﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Comandos
{
    internal class ComandosDoSistema
    {
        Dictionary<string, IComando> comandosDoSistema = new()
        {
            {"help", new Help() },
            {"import", new Import() },
            {"show", new Show() },
            {"list", new List() }
        };

        public IComando? this[string key] => comandosDoSistema.ContainsKey(key) ? comandosDoSistema[key] : null;
    }
}
