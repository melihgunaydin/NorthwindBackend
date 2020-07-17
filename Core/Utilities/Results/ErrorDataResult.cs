using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, bool success) : base(data, success)
        {
        }

        public ErrorDataResult(T data, bool success, string message) : base(data, success, message)
        {
        }

        public ErrorDataResult(string message) : base(default, success: false, message)
        {

        }

        public ErrorDataResult() : base(default, success: false)
        {

        }
    }
}
