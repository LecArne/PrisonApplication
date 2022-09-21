using MediatR;

namespace PrisonApplication.Contracts.Commands;

public class CommandBase<T> : IRequest<T> where T : class
{

}
