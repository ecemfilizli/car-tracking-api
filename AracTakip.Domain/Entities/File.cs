﻿using AracTakip.Domain.Entities.Common;

namespace AracTakip.Domain.Entities
{
    public class File : BaseEntity
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Storage { get; set; }
        public string FileDescription { get; set; }
    }
}
