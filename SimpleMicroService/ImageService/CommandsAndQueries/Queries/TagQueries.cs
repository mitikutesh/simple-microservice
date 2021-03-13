using ImageService.BusinessLogic.Models;
using System;
using System.Collections.Generic;

namespace ImageService.CommandsAndQueries.Queries
{
    public record ListAllTags : IQuery<IEnumerable<ImageTag>>
    {
    }
    public record ListAllTagsForImage : IQuery<IEnumerable<ImageTag>>
    {
        public Guid ImageId { get; set; }
    }
    public record GetTag : IQuery<ImageTag>
    {
        public Guid TagId { get; set; }
    }
}
