using MediatR;

namespace Teladoc.Application.Interfaces
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
