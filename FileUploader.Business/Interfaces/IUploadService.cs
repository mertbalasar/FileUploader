using FileUploader.Core.Responses;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileUploader.Business.Interfaces
{
    public interface IUploadService
    {
        Task<ServiceResponse> UploadFile(IFormFile file);
    }
}
