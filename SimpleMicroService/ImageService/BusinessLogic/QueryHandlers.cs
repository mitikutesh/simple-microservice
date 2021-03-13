using ImageService.BusinessLogic.Data;
using ImageService.BusinessLogic.Models;
using ImageService.CommandsAndQueries.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ImageService.BusinessLogic
{
    public class QueryHandlers : IRequestHandler<ListAllImages, IEnumerable<ImageFile>>,
                                IRequestHandler<GetImagsById, ImageFile>,
                                 IRequestHandler<ListAllTags, IEnumerable<ImageTag>>,
                                IRequestHandler<ListAllTagsForImage, IEnumerable<ImageTag>>,
                                IRequestHandler<GetTag, ImageTag>,
                                IRequestHandler<GetImagesByTag, IEnumerable<ImageFile>>
    {
        private readonly IApplicationContext _context;

        public QueryHandlers(IApplicationContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ImageFile>> Handle(ListAllImages request, CancellationToken cancellationToken)
        {
            var testImg = new ImageFile { Id = Guid.NewGuid(), Image = null, Name = "test", Tags = null };
            var imgList = await _context.ImageFiles.ToListAsync();
            imgList.Add(testImg);
            if (imgList == null)
                return null;
            return imgList.AsReadOnly();
        }

        public Task<ImageFile> Handle(GetImagsById request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ImageTag>> Handle(ListAllTags request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ImageTag>> Handle(ListAllTagsForImage request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<ImageTag> Handle(GetTag request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ImageFile>> Handle(GetImagesByTag request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
