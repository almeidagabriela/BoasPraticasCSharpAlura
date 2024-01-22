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

            return new Pet(
                Guid.Parse(propriedades[0]),
                propriedades[1],
                int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
            );
        }
    }
}
