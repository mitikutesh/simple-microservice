using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageService.CommandsAndQueries.Queries
{
    public interface IQuery<T> : IRequest<T>
    {
    }
}
