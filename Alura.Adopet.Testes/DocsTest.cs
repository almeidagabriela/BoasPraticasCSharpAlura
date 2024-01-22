using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes
{
    public class DocsTest
    {
        [Fact]
        public void CriaDicionarioComandosDeveRetornarDicionarioNaoNulo()
        {
            // Arrange
            Dictionary<string, DocComando> docsComandos;
            var docs = new Docs();

            // Act
            docsComandos = docs.CriaDicionarioComandos();

            // Assert
            Assert.NotNull(docs);
        }
    }
}
