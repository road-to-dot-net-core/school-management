using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Response.Access_Control.Menu
{
    public class MenuResponse
    {
        public string Label { get; set; }
        public string Logo { get; set; }
        public string RoutingLink { get; set; }
        IEnumerable<MenuResponse> ChildItems { get; set; }


    }
}
