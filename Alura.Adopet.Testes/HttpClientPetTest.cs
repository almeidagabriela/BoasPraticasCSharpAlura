using Alura.Adopet.Console.Servicos;

namespace Alura.Adopet.Testes
{
    public class HttpClientPetTest
    {
        [Fact]
        public async Task ListaPetsDeveRetornarUmaListaNaoVazia()
        {
            // Arrange: configura��o do projeto
            var clientePet = new HttpClientPet();

            // Act: a��o que vamos testar
            var lista = await clientePet.ListPetsAsync();

            // Assert: verificar se resultado obtido est� de acordo com o que esperamos
            Assert.NotNull(lista);
            Assert.NotEmpty(lista);
        }
    }
}