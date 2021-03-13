using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImageService.Models
{
    public class FileTag
    {
        public Guid Id { get; set; }
        public Guid FileId { get; set; }
        public Guid TagId { get; set; }
        public  ImageFile ImageFile { get; set; }
        public  ImageTag ImageTag { get; set; }
    }
}
