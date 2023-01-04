using FileUploader.API.Attributes;
using FileUploader.API.Base;
using FileUploader.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploader.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UploadController : ControllersBase
    {
        private readonly IUploadService _uploadService;

        public UploadController(IUploadService uploadService)
        {
            _uploadService = uploadService;
        }

        [HttpPost, Route("")]
        public async Task<IActionResult> UploadFile([FromForm] IFormFile file)
        {
            var response = await _uploadService.UploadFile(file);

            return APIResponse(response);
        }
    }
}
