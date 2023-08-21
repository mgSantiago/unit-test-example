using FluentAssertions;
namespace Test.Handlers
{
    public class UserCommandTest
    {
        [Fact]
        //Melhorar nomes dos testes
        public void Should_ThrowException_When_AgeLessThan18()
        {
            //triple A
            //Utilizar AutoBogus
            //Acts mais claros
            //Testes mais simples
            //Asserts mais claros
            //Testes n�o s�o somente para passar no Sonar
            //Utilizar Stryker em caso de testes unit�rios cobrindo somente o b�sico.
         
            //Arrange

            //Act

            //Assert
            string actual = "ABCDEFGHI";
            actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
        }
    }
}