using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, bool success) : base(data, success: true)
        {
        }


        public SuccessDataResult(T data) : base(data, success: true)
        {
        }

        public SuccessDataResult(T data, string message) : base(default, success: true, message)
        {

        }

        public SuccessDataResult() : base(default, success: true)
        {

        }
    }
}
