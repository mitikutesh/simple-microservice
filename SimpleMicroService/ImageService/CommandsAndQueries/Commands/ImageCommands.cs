using System;
using System.ComponentModel.DataAnnotations;

namespace ImageService.CommandsAndQueries.Commands
{
    public record AddImage : ICommand<string>
    {
       // [Required]
        public Guid Id { get; set; }
         [Required]
        public string ImageName { get; set; }

        //[Required]
        public Byte[] Image { get; set; }
    }
    public record DeleteImage : ICommand<string>
    {
        [Required]
        public Guid Id { get; set; }

    }
    public record UpdateImage : ICommand<string>
    {
        [Required]
        public Guid Id { get; set; }
    }

}
