using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileUploader.API.Base;
using FileUploader.Business.Interfaces;
using FileUploader.Core.Responses;

namespace FileUploader.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : ControllersBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet, Route("")]
        public IActionResult DisplayWelcome()
        {
            var response = _homeService.DisplayWelcome();

            return APIResponse(response);
        }
    }
}
