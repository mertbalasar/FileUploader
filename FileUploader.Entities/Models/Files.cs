using FileUploader.Entities.Attributes;
using FileUploader.Entities.Base;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileUploader.Entities.Models
{
    [CollectionName("file")]
    public class Files : CollectionBase
    {
        public string FilePath { get; set; }
        public ObjectId UserId { get; set; }
    }
}
