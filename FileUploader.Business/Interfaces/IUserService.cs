using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FileUploader.Business.Models.EntitiesModels;
using FileUploader.Core.Requests;
using FileUploader.Core.Responses;
using FileUploader.Entities.Models;

namespace FileUploader.Business.Interfaces
{
    public interface IUserService
    {
        Task<ServiceResponse<UserModel>> SignUp(UserSignUpRequest request);
        Task<ServiceResponse<UserModel>> SignIn(UserSignInRequest request);
        Task<ServiceResponse> LogOut();
        Task<ServiceResponse> DeleteUser(string userId);
    }
}
