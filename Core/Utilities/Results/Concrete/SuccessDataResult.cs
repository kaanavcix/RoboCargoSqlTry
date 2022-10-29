using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T>,  IDataResult<T>
    {
        public SuccessDataResult(T data, string message, bool sucess) : base(data, message, true)
        {
        }

        public T GetValue { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }

       
    }
}
