using ImageService.BusinessLogic.Data;
using ImageService.BusinessLogic.Models;
using ImageService.CommandsAndQueries.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ImageService.BusinessLogic
{
    public class CommandHanlders : IRequestHandler<AddImage, string>,
                                   IRequestHandler<DeleteImage, string>,
                                    IRequestHandler<UpdateImage, string>,
                                IRequestHandler<AddTag, string>,
                                   IRequestHandler<DeleteTag, string>,
                                    IRequestHandler<UpdateTag, string>
    {
        private readonly IApplicationContext _context;

        public CommandHanlders(IApplicationContext context)
        {
            _context = context;
        }
        public async Task<string> Handle(AddImage request, CancellationToken cancellationToken)
        {
            var img = new ImageFile
            {
                Id = request.Id,
                Image = request.Image,
                Name = request.ImageName
            };
            _context.ImageFiles.Add(img);
            if (await _context.SaveChangesAsync() > 0)
                return "Image Created!";
            else
                return "failed to create!";
        }

        public Task<string> Handle(DeleteImage request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> Handle(UpdateImage request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> Handle(AddTag request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> Handle(DeleteTag request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> Handle(UpdateTag request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
