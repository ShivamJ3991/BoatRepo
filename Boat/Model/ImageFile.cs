using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Boat.Model
{
    public class ImageFile : BaseModel
    {
        public string Title { get; set; }
        public string Path { get; set; }
        public string Source { get; set; }
        public string MimeType { get; set; }
        public string FileName { get; set; }
        public string Type { get; set; }
        public byte[] Bytes { get; set; }
    }
}
