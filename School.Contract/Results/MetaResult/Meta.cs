using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Results.MetaResult
{
    public class ResponseMetadata
    {
        public int PageNumber { get; internal set; }
        public int PageSize { get; internal set; }
        public int TotalRecords { get; internal set; }
        public int PageCount { get; internal set; }
        public bool HasPreviousPage { get; internal set; }
        public bool HasNextPage { get; internal set; }

        public ResponseMetadata()
        {

        }

        public ResponseMetadata(int pageNumber, int pageSize, int pageCount, int totalRecords)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalRecords = totalRecords;
            PageCount = pageCount;
        }
    }
}
