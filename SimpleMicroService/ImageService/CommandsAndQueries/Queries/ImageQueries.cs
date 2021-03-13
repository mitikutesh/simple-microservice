using ImageService.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImageService.CommandsAndQueries.Queries
{
    public record ListAllImages : IQuery<IEnumerable<ImageFile>>
    {
    }
    public record GetImagsById : IQuery<ImageFile>
    {
        [Required]
        public Guid Id { get; set; }
    }

    public record GetImagesByTag : IQuery<IEnumerable<ImageFile>> 
    {
        [Required]
        public Guid TagId { get; set; }
    }
}
