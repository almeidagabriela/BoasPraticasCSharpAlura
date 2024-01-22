using Alura.Adopet.Console.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "help", documentacao: "adopet help comando que exibe informações da ajuda. \n" +
                                                 "adopet help <NOME_COMANDO> para acessar a ajuda de um comando específico.")]
    internal class Help : IComando
    {
        private Dictionary<string, DocComando> docsComandos;

        public Help()
        {
            docsComandos = Docs.ToDictionary(Assembly.GetExecutingAssembly());
        }

        public Task ExecutarAsync(string[] args)
        {
            ListaDeComandos(comandos: args);
            return Task.CompletedTask;
        }

        private void ListaDeComandos(string[] comandos)
        {
            System.Console.WriteLine("Lista de comandos.");
            // se não passou mais nenhum argumento mostra help de todos os comandos
            if (comandos.Length == 1)
            {
                System.Console.WriteLine("adopet help <parametro> ous simplemente adopet help  " +
                     "comando que exibe informações de ajuda dos comandos.");
                System.Console.WriteLine("Adopet (1.0) - Aplicativo de linha de comando (CLI).");
                System.Console.WriteLine("Realiza a importação em lote de um arquivos de pets.");
                System.Console.WriteLine("Comando possíveis: ");

                foreach (var doc in docsComandos.Values)
                {
                    System.Console.WriteLine(doc.Documentacao);
                }

                System.Console.WriteLine("Execute 'adopet.exe help [comando]' para obter mais informações sobre um comando." + "\n\n\n");
            }
            // exibe o help daquele comando específico
            else if (comandos.Length == 2)
            {
                string comandoASerExibido = comandos[1];

                if (docsComandos.ContainsKey(comandoASerExibido))
                {
                    var comando = docsComandos[comandoASerExibido];
                    System.Console.WriteLine(comando.Documentacao);
                }
            }
        }
    }
}
