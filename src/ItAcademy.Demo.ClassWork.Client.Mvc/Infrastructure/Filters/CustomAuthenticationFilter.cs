using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Filters
{
    public class CustomAuthenticationFilter : FilterAttribute, IAuthenticationFilter
    {
        private string context;

        public CustomAuthenticationFilter(string context)
        {
            this.context = context;
        }

        void IAuthenticationFilter.OnAuthentication(AuthenticationContext filterContext)
        {
            Debug.WriteLine($"{context}: OnAuthentication");
        }

        void IAuthenticationFilter.OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            Debug.WriteLine($"{context}: OnAuthenticationChallenge");
        }
    }
}