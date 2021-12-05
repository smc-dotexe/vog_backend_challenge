using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using VogCodeChallenge.API.Exceptions;

namespace VogCodeChallenge.API.Middleware
{
    public class GlobalExceptionHandler
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }

            catch (Exception ex)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                string errorMessage = null;

                switch (ex)
                {
                    case NotFoundException err:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        errorMessage = err.Message;
                        break;
                    default: // To prevent generic 500 errors from being returned.
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        errorMessage = "We're sorry, your request could not be completed: " + ex.Message;
                        break;
                }

                var result = JsonSerializer.Serialize(new { message = errorMessage });
                await response.WriteAsync(result);
            }
        }
    }
}
