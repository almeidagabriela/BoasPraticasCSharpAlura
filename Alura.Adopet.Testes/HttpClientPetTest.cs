using Alura.Adopet.Console.Servicos;

namespace Alura.Adopet.Testes
{
    public class HttpClientPetTest
    {
        [Fact]
        public async Task ListaPetsDeveRetornarUmaListaNaoVazia()
        {
            // Arrange: configuração do projeto
            var clientePet = new HttpClientPet();

            // Act: ação que vamos testar
            var lista = await clientePet.ListPetsAsync();

            // Assert: verificar se resultado obtido está de acordo com o que esperamos
            Assert.NotNull(lista);
            Assert.NotEmpty(lista);
        }
    }
}