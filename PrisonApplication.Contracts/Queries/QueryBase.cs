using MediatR;

namespace PrisonApplication.Contracts.Queries;

public class QueryBase<T> : IRequest<T> where T : class
{
}
