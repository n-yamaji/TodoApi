
using System;
using Microsoft.AspNetCore.Mvc.Routing;

namespace TodoApi.Attributes
{
    public class RestControllerAttribute : Attribute, IRouteTemplateProvider
    {
        public string Template => "api/[controller]";

        public int? Order { get; set; }

        public string Name { get; set; }
    }
}