using ImageService.BusinessLogic.Models;
using ImageService.CommandsAndQueries.Queries;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ImageService.BusinessLogic
{
    public class QueryHandlers : IRequestHandler<ListAllImages, List<ImageFile>>,
                                IRequestHandler<GetImagsById, ImageFile>,
                                 IRequestHandler<ListAllTags, List<ImageTag>>,
                                IRequestHandler<ListAllTagsForImage, List<ImageTag>>,
                                IRequestHandler<GetTag, ImageTag>,
                                IRequestHandler<GetImagesByTag, List<ImageFile>>
    {
        public Task<List<ImageFile>> Handle(ListAllImages request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<ImageFile> Handle(GetImagsById request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ImageTag>> Handle(ListAllTags request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ImageTag>> Handle(ListAllTagsForImage request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<ImageTag> Handle(GetTag request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ImageFile>> Handle(GetImagesByTag request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
