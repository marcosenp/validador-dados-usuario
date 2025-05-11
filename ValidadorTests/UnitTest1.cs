using Xunit;

public class UsuarioTests
{
    [Theory]
    [InlineData("12345678901", true)]
    [InlineData("1234567890", false)]
    [InlineData("abcdefghijk", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void TestarValidacaoCpf(string cpf, bool esperado)
    {
        bool resultado = Program.ValidarCpf(cpf);

        Assert.Equal(esperado, resultado);
    }
}
