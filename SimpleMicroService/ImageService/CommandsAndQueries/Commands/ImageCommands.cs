using System.ComponentModel.DataAnnotations;

namespace ImageService.CommandsAndQueries.Commands
{
    public record AddImage : ICommand<string>
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }
    }
    public record DeleteImage : ICommand<string>
    {

    }
    public record UpdateImage : ICommand<string>
    {
    }

}
