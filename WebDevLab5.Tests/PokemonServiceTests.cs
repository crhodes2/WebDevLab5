using System;
using NUnit.Framework;
using FakeItEasy;
using WebDevLab5.Data.Entities;
using WebDevLab5.Repositories;
using WebDevLab5.Services;

namespace WebDevLab5.Tests
{
    [TestFixture]
    public class PokemonServiceTests
    {
        private IPokemonRepository _PokemonRespository;

        [SetUp]
        public void SetUp()
        {
            _PokemonRespository = A.Fake<IPokemonRepository>();
        }

        [Test]
        public void ShouldNotIndicateCheckupAlert()
        {
            // Arrange
            A.CallTo(() => _PokemonRespository.GetPokemon(A<int>.Ignored)).Returns(new Pokemon
            {
                NextCheckup = DateTime.Now.AddDays(29)
            });

            // Act (SUT)
            var PokemonService = new PokemonService(_PokemonRespository);
            var PokemonViewModel = PokemonService.GetPokemon(1);

            // Assert
            Assert.IsFalse(PokemonViewModel.CheckupAlert);
        }

        [Test]
        public void ShouldIndicateCheckupAlert()
        {
            // Arrange
            A.CallTo(() => _PokemonRespository.GetPokemon(A<int>.Ignored)).Returns(new Pokemon
            {
                NextCheckup = DateTime.Now.AddDays(13)
            });

            // Act (SUT)
            var PokemonService = new PokemonService(_PokemonRespository);
            var PokemonViewModel = PokemonService.GetPokemon(1);

            // Assert
            Assert.IsTrue(PokemonViewModel.CheckupAlert);
        }
    }
}
