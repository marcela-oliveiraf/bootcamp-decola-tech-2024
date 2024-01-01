using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using sistema.Classes;

namespace sistema_tests{
    public class ValidacoesListaTests{
        private ValidacoesLista _validacoes = new ValidacoesLista();

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista(){
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var resultadoEsperado = new List<int> { 5, 9 };

            // Act
            var resultado = _validacoes.RemoverNumerosNegativos(lista);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveConterONumero9NaLista(){
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 9;

            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista(){

            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 10;

            // Act
            bool resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

            // Assert
            Assert.False(resultado);  // Espera que False significa que nao tem o numero procurado
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2(){
            //TODO: Implementar método de teste

            // Arrange
            var lista = new List<int> { 5, 7, 8, 9 };
            var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
            
            // Act
            var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista(){
            //TODO: Implementar método de teste

            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            int resultado = _validacoes.RetornarMaiorNumeroLista(lista);

            // Assert
            Assert.Equal(9, resultado);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaLista(){

            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            var resultado = _validacoes.RetornarMenorNumeroLista(lista);

            // Assert
            Assert.Equal(-8, resultado);
        }
    }
}