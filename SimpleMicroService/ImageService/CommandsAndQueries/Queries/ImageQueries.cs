using ImageService.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageService.CommandsAndQueries.Queries
{
    public record ListAllImagss : IQuery<List<ImageFile>>
    {
    }
    public record GetImagsById : IQuery<List<ImageFile>>
    {
    }
}
