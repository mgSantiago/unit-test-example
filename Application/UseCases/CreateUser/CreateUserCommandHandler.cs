using MediatR;
using UnitTestExample.Commands.CreateUser;
using UnitTestExample.Repositories;

namespace UnitTestExample.UseCases.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IUserRepository userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            //Validator here
            if(request == null)
                throw new ArgumentNullException(nameof(request));

            var addresses = request.Addresses.Select(k => new Entities.Address(Guid.NewGuid(), k.Line1, k.Line2, k.City, k.State, k.PostalCode, k.Country)).ToList();

            var user = new Entities.User(Guid.NewGuid(), request.Name, request.Age, addresses);

            return null;
        }
    }
}
