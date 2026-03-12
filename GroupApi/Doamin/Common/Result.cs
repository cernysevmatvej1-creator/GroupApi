using System;
using System.Collections.Generic;
using System.Text;

namespace GroupApi.Common
{

    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public static Result Ok(string message = null) =>
            new() { Success = true, Message = message ?? "Успешно" };

        public static Result Fail(string message) =>
            new() { Success = false, Message = message };
    }
}
