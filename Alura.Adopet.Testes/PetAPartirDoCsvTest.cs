﻿using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes
{
    public class PetAPartirDoCsvTest
    {
        [Fact]
        public void QuandoStringForValidaDeveRetornarUmPet()
        {
            // Arrange
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";

            // Act
            Pet pet = linha.ConverteDoTexto();

            // Assert
            Assert.NotNull(pet);
        }

        [Fact]
        public void QuandoStringForNulaDeveLancarArgumentNullException()
        {
            // Arrange
            string? linha = null;

            // Act + Assert
            Assert.ThrowsAny<ArgumentNullException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void QuandoStringForVaziaDeveLancarArgumentException()
        {
            // Arrange
            string linha = string.Empty;

            // Act + Assert
            Assert.ThrowsAny<ArgumentException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void QuandoFaltarCamposDeveLancarArgumentException()
        {
            // Arrange
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão";

            // Act
            Assert.ThrowsAny<ArgumentException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void QuandoGuidForInvalidoDeveLancarArgumentException()
        {
            // Arrange
            string linha = "456b24f4-19e2-4423-845d;Lima Limão;1";

            // Act
            Assert.ThrowsAny<ArgumentException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void QuandoTipoForInvalidoDeveLancarArgumentException()
        {
            // Arrange
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;99";

            // Act
            Assert.ThrowsAny<ArgumentException>(() => linha.ConverteDoTexto());
        }
    }
}
