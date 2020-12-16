using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace School.Contract.Results.SuccessResults
{
    public class SuccessResult
    {
        public object Data { get; set; }

        public SuccessResult(ISuccessResponse response)
        {
            Data = response;
        }
    }
}
