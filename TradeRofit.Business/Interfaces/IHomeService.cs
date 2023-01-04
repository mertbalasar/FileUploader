using System;
using System.Collections.Generic;
using System.Text;
using FileUploader.Business.Base;
using FileUploader.Core.Responses;

namespace FileUploader.Business.Interfaces
{
    public interface IHomeService
    {
        ServiceResponse<string> DisplayWelcome();
    }
}
