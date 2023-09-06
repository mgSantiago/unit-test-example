using MediatR;
using UnitTestExample.UseCases.User;

namespace UnitTestExample.Commands.CreateUser
{
    public sealed record CreateUserCommand(string Name, int Age, IEnumerable<AddressCommand> Addresses) : IRequest
    {
    }
}
