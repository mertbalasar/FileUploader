using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileUploader.Business.Models.EntitiesModels;
using FileUploader.Core.Requests;
using FileUploader.Entities.Models;
using FileUploader.Entities.LookUpModels;

namespace FileUploader.API.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserSignUpRequest>();
            CreateMap<UserSignUpRequest, User>();
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>();

            CreateMap<FilesLookUp, FilesModel>();
            CreateMap<FilesModel, FilesLookUp>();
        }
    }
}
