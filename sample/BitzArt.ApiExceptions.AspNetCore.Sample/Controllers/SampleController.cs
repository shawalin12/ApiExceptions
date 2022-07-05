﻿using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BitzArt.ApiExceptions.AspNetCore.Sample.Controllers
{
    [ApiController]
    [Route("")]
    public class SampleController : ControllerBase
    {
        [HttpGet("notfound")]
        public IActionResult ThrowNotFound()
        {
            throw BitzArt.ApiException.NotFound("sample 'not found' exception message");
        }

        [HttpGet("unauthorized")]
        public IActionResult ThrowUnauthorized()
        {
            throw BitzArt.ApiException.Unauthorized("sample 'unauthorized' exception message");
        }

        [HttpGet("custom/{statusCode}")]
        public IActionResult ThrowCustom([FromRoute] HttpStatusCode statusCode)
        {
            throw BitzArt.ApiException.Custom(statusCode, "sample custom status code");
        }
    }
}
