﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUploader.Entities.Base
{
    public interface ICollectionBase
    {
        string Id { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
