using FileUploader.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileUploader.Entities.LookUpModels
{
    public class FilesLookUp : Files
    {
        public User User { get; set; }
    }
}
