using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using DreamwareTZ.Models;

namespace DreamwareTZ.Infrastructure
{
    public static class Helpers
    {
        public static MvcHtmlString MyGrid(this HtmlHelper html, GridForViewModel model)
        {
            var content = "";
            
            //Table Header Done
            content += "<table class='table table-hover'><thead><tr>";
            foreach (var th in model.TypeObj.GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                if (th.Name == "Id")
                {
                    continue;
                }
                content += $"<th>{th.Name}</th>";
            }
            
            content += "</tr></thead><tbody>";
            foreach (var obj in model.ListObj)
            {
                var fields = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
                var fContent = "<tr>";
                foreach (var field in fields)
                {
                    if (field.GetValue(obj) != null)
                    {
                        fContent += $"<td>{field.GetValue(obj)}</td> ";
                    }
                }
                content += "</tr>" + fContent;
                
            }
            content += "</tbody></table>";

            return new MvcHtmlString(content);
        }
    }
}