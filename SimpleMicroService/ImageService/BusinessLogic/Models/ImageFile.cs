using System;
using System.Collections.Generic;

namespace ImageService.BusinessLogic.Models
{
    public class ImageFile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Byte[] Image { get; set; }
        public List<ImageTag> Tags { get; set; }
    }
}
