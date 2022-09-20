using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   public abstract class BaseController:ControllerBase
    {
        protected ActionResult<TResult> OkorNotFound<TResult>(TResult result)
            => result is null ? NotFound() : Ok(result); 
    }
}
