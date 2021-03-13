using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageService.Models
{
    public class ImageFile
    {
        public Guid Id { get; set; }
        public Byte[] Image { get; set; }
    }
}
