using FileUploader.Business.Base;
using FileUploader.Business.Interfaces;
using FileUploader.Core.Responses;
using FileUploader.DAL.Repository;
using FileUploader.Entities.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileUploader.Business.Services
{
    public class UploadService : ServiceBase, IUploadService
    {
        private readonly IMongoRepository<Files> _filesRepository;

        public UploadService(IHttpContextAccessor httpAccessor,
            IMongoRepository<Files> filesRepository) : base(httpAccessor)
        {
            _filesRepository = filesRepository;
        }

        public async Task<ServiceResponse> UploadFile(IFormFile file)
        {
            var response = new ServiceResponse { };

            try
            {
                var path = "C:/Users/" + Environment.UserName + "/FileUploaderFiles";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (var stream = new FileStream(Path.Combine(path, file.FileName), FileMode.Create))// TODO:resizing here 
                {
                    file.CopyTo(stream);
                }

                var res = await _filesRepository.InsertOneAsync(new Files
                {
                    UserId = User.Id,
                    FilePath = Path.Combine(path, file.FileName)
                });

                if (res.Code != 200)
                {
                    response.Code = res.Code;
                    response.Message = res.Message;
                }
            }
            catch (Exception e)
            {
                response.Code = 500;
                response.Message = e.Message;
            }

            return response;           
        }
    }
}
