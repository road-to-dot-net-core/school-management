using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models.Access_Control
{
    public class Feature : BaseEntity
    {
        public String Label { get; private set; }
        public String Description { get; private set; }
        public String Controller { get; private set; }
        public string ControllerActionName { get; private set; }
        public String Action { get; private set; }
        public string RoutingLink { get; private set; }
        public string Logo { get;private set; }

        public Guid? ParentId { get; private set; }
        public virtual Feature ParentFeature { get;private set; }

        public Feature()
        {

        }
        public Feature(string label, string action, string controller, 
                       string controllerActionName, string description,Guid? parentId=null,string routingLink="",string logo="")
        {
            Id = Guid.NewGuid();

            Label = label;
            Action = action;
            Controller = controller;
            ControllerActionName = controllerActionName;
            Description = description;
            ParentId = parentId;
            RoutingLink = routingLink;
            Logo = logo;
        }

    }
}
