using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad Request.",
                401 => "Not Authorized.",
                404 => "Resource Not Found.",
                500 => "Errors Found.",
                _ => null
            };
        }

        public int StatusCode {get; set; }
        public string Message {get; set; }
    }
}