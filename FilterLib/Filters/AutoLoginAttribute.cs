
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace LiuJg.Filters
{
    /// <summary>
    /// 自动登陆验证过滤器
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class AutoLoginAttribute: FilterAttribute, IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var url = filterContext.RequestContext.HttpContext.Request.Url.ToString();
            
            
            if (filterContext.IsChildAction)
                return;
            filterContext.Result = new RedirectResult("/filter?" + url);
            
        }
        
    }
}
