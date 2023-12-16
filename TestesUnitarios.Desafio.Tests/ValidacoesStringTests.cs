using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //TODO: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange

        // Arrange
        // testando o certo
        var texto = "amanhã";
        // testando o errado
        // var texto = "amanheceu";

        var resultadoEsperado = 6;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        // testando o correto
        // var texto = "Esse é um texto simples";
        var textoProcurado = "qualquer";
        
        //TODO: Corrigir a chamada do método "ContemCaractere" da seção Act
        // Act
         var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        // testando o correto
        var texto = "Esse é um texto qualquer";
        // testando o errado
        // var texto = "Esse é um teste qualquer";

        // var textoProcurado = "teste";
        var textoProcurado = "teste";
        
        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.False com base no retorno da chamada ao método
        Assert.False(resultado);
    }

    //TODO: Corrigir a anotação [Fact]
    [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
    {
        //TODO: Corrigir a variável "textoProcurado" seção Arrange

        // Arrange
        // testando o correto
        var texto = "Começo, meio e fim do texto procurado";
        // testando o errado
        // var texto = "Começo, meio e fim do texto procura";
        
        var textoProcurado = "procurado";
        
        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
