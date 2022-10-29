using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T> : Result,IDataResult<T>
    {
        public T? GetValue { get; set; }

       

        public DataResult(T? data,string message,bool sucess) : base(sucess, message)
        {
            GetValue = data;
        }
    }
}
