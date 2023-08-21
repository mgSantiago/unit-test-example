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
            //Testes não são somente para passar no Sonar
            //Utilizar Stryker em caso de testes unitários cobrindo somente o básico.
         
            //Arrange

            //Act

            //Assert
            string actual = "ABCDEFGHI";
            actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
        }
    }
}