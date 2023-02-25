using MediatR;

namespace Teladoc.Application.Interfaces
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
