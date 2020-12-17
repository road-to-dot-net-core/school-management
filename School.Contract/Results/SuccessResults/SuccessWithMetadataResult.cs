using School.Contract.Results.MetaResult;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Text;

namespace School.Contract.Results.SuccessResults
{
    public class SuccessWithMetadataResult 
    {
        public object Data { get; set; }

        public ResponseMetadata Mata { get; set; }

        public SuccessWithMetadataResult(ISuccessResponse response, ResponseMetadata metadata)
        {
            Data = response;
            this.Mata = metadata;
        }
    }
}
