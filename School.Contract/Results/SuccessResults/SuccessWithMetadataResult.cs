using PagedList;
using School.Contract.Results.MetaResult;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace School.Contract.Results.SuccessResults
{
    public class SuccessWithMetadataResult<T> where T: ISuccessResponse
    {
        public object Data { get; set; }

        public ResponseMetadata Meta { get; set; }

        public SuccessWithMetadataResult(T response, ResponseMetadata metadata)
        {
            Data = response;
            this.Meta = metadata;
        }

        public SuccessWithMetadataResult(PagedList<T> response)
        {
            Data = response.ToList();
            this.Meta = new ResponseMetadata() 
            {
                PageCount = response.PageCount,
                PageNumber = response.PageNumber,
                PageSize = response.PageSize,
                TotalRecords = response.TotalItemCount,
                HasPreviousPage = response.HasPreviousPage,
                HasNextPage = response.HasNextPage
            };
        }
    }
}
