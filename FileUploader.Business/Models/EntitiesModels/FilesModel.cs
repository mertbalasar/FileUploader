using System;
using System.Collections.Generic;
using System.Text;

namespace FileUploader.Business.Models.EntitiesModels
{
    public class FilesModel
    {
        public string FilePath { get; set; }
        public UserModel User { get; set; }
    }
}
