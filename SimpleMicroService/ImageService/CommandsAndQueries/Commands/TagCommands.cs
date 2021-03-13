using System.ComponentModel.DataAnnotations;

namespace ImageService.CommandsAndQueries.Commands
{
    public record AddTag : ICommand<string>
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Tag { get; set; }
    }
    public record DeleteTag : ICommand<string>
    {

    }
    public record UpdateTag : ICommand<string>
    {
    }
}
