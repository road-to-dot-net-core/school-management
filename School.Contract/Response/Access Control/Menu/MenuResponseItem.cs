﻿using School.Contract.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Response.Access_Control.Menu
{
    public class MenuResponseItem : ISuccessResponse
    {
        //public Guid Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string RoutingLink { get; set; }
        //public Guid? ParentId { get; set; }


    }
    public class UserMenuResponse : ISuccessResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<MenuResponseItem> Items { get; set; }
    }
}
