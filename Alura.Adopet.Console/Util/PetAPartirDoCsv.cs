using Alura.Adopet.Console.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Util
{
    public static class PetAPartirDoCsv
    {
        public static Pet ConverteDoTexto(this string? linha)
        {
            string[]? propriedades = linha?.Split(';') ?? throw new ArgumentNullException("Texto não pode ser nulo!");

            if (string.IsNullOrEmpty(linha)) throw new ArgumentException("Texto não pode ser vazio!");

            if (propriedades.Length != 3) throw new ArgumentException("Texto inválido!");

            bool sucesso = Guid.TryParse(propriedades[0], out Guid petId);
            if (!sucesso) throw new ArgumentException("Guid inválido!");

            return new Pet(
                petId,
                propriedades[1],
                int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
            );
        }
    }
}
