using ImageService.BusinessLogic.Models;
using System;
using System.Collections.Generic;

namespace ImageService.CommandsAndQueries.Queries
{
    public record ListAllTags : IQuery<List<ImageTag>>
    {
    }
    public record ListAllTagsForImage : IQuery<List<ImageTag>>
    {
        public Guid ImageId { get; set; }
    }
    public record GetTag : IQuery<ImageTag>
    {
        public int TagId { get; set; }
    }
}
