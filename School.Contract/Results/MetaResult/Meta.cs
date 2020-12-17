using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Results.MetaResult
{
    public class ResponseMetadata
    {
        public int total { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int returned { get; set; }

        public ResponseMetadata()
        {

        }
        public ResponseMetadata(int total, int limit, int offset, int returned)
        {
            this.total = total;
            this.limit = limit;
            this.offset = offset;
            this.returned = returned;
        }
    }
}
