using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)
        {
            Message = message;

            //read only can be set in constructor
        }
        public Result(bool success)
        {
            Success = success;

            //read only can be set in constructor
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
