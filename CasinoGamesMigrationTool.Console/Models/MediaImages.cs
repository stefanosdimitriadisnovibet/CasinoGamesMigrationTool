using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class MediaImages
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Source { get; set; }
        public string Path { get; set; }
        public string Tags { get; set; }
        public byte ImageType { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public byte ThumbType { get; set; }
        public int ThumbWidth { get; set; }
        public int ThumbHeight { get; set; }
        public byte[] ThumbData { get; set; }
    }
}
