﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "show", documentacao: "adopet show <arquivo> comando que exibe no terminal o conteúdo do arquivo importado.")]
    internal class Show : IComando
    {
        public Task ExecutarAsync(string[] args)
        {
            ListaDadosASerImportados(caminhoDoArquivoASerExibido: args[1]);
            return Task.CompletedTask;
        }

        private void ListaDadosASerImportados(string caminhoDoArquivoASerExibido)
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo();
            var listaDePets = leitor.RealizaLeitura(caminhoDoArquivoASerExibido);

            foreach (var pet in listaDePets)
            {
                System.Console.WriteLine(pet);
            }
        }
    }
}
