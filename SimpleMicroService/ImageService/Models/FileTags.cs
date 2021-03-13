using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageService.Models
{
    public class FileTags
    {
        public Guid Id { get; set; }
        public Guid FileId { get; set; }
        public Guid TagId { get; set; }
    }
}
