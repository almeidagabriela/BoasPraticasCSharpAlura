using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes
{
    public class DocsTest
    {
        [Fact]
        public void QuandoExistemComandosDeveRetornarDicionarioNaoVazio()
        {
            // Arrange
            Assembly assemblyComTipoDocComando = Assembly.GetAssembly(typeof(DocComando))!;
            Dictionary<string, DocComando> docsComandos;

            // Act
            docsComandos = Docs.ToDictionary(assemblyComTipoDocComando);

            // Assert
            Assert.NotNull(docsComandos);
            Assert.NotEmpty(docsComandos);
            Assert.Equal(4, docsComandos.Count);
        }
    }
}
