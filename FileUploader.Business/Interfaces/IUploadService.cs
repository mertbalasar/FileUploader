using FileUploader.Business.Models.EntitiesModels;
using FileUploader.Core.Responses;
using FileUploader.Entities.LookUpModels;
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
        ServiceResponse<List<FilesModel>> GetFiles();
    }
}
