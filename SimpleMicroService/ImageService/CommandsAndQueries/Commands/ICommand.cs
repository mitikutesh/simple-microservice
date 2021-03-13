using MediatR;

namespace ImageService.CommandsAndQueries.Commands
{
    public interface ICommand<T> : IRequest<T>
    {
    }
}
