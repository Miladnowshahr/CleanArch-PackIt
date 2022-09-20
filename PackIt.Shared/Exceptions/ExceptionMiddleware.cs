using Microsoft.AspNetCore.Http;
using PackIt.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PackIt.Shared.Exceptions
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
			try
			{
				await next(context);
			}
			catch (PackItException ex)
			{
				context.Response.StatusCode = 400;
				context.Response.Headers.Add("Content-type", "application/json");

				var errorCode = ToUnderscoreCase(ex.GetType().Name.Replace("Exception", String.Empty));

				var json = JsonSerializer.Serialize(new { ErrorCode = errorCode, ex.Message });
				await context.Response.WriteAsync(json);
			}
        }


		private static string ToUnderscoreCase(string value)
			=> string.Concat((value ?? string.Empty).Select((x, i) => i > 0 && char.IsUpper(x) && !char.IsUpper(value[i - 1]) ? $"_{x}" : x.ToString())).ToLower();
    }
}
