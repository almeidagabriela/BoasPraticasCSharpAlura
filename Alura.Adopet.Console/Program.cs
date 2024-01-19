using System.Net.Http.Headers;
using System.Net.Http.Json;
using Alura.Adopet.Console;
using Alura.Adopet.Console.Comandos;

Dictionary<string, IComando> comandosDoSistema = new()
{
    {"help", new Help() },
    {"import", new Import() },
    {"show", new Show() },
    {"list", new List() }
};

Console.ForegroundColor = ConsoleColor.Green;
try
{
    string comando = args[0].Trim();

    if (comandosDoSistema.ContainsKey(comando))
    {
        IComando? comandoASerExecutado = comandosDoSistema[comando];
        await comandoASerExecutado.ExecutarAsync(args);
    } 
    else
    {
        Console.WriteLine("Comando inválido!");
    }
}
catch (Exception ex)
{
    // mostra a exceção em vermelho
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Aconteceu um exceção: {ex.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.White;
}