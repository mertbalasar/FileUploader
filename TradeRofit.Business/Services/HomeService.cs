using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using FileUploader.Business.Base;
using FileUploader.Business.Interfaces;
using FileUploader.Core.Responses;
using FileUploader.DAL.Repository;
using FileUploader.Entities.Models;

namespace FileUploader.Business.Services
{
    public class HomeService : ServiceBase, IHomeService
    {
        public HomeService(IHttpContextAccessor httpAccessor) : base(httpAccessor)
        {
            
        }

        public ServiceResponse<string> DisplayWelcome()
        {
            try
            {
                return new ServiceResponse<string>()
                {
                    Result = "Welcome To FileUploader"
                };
            } 
            catch (Exception e)
            {
                return new ServiceResponse<string>()
                {
                    Result = null,
                    Code = StatusCodes.Status500InternalServerError,
                    Message = e.Message
                };
            }
        }
    }
}
