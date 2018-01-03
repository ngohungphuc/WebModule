using System.Web.Mvc;

namespace Sample
{
    public class MarketingAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Marketing";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {

            context.MapRoute(

                "Marketing_default",

                "Marketing/{controller}/{action}/{id}",

                new { controller = "Marketing", action = "Index", id = UrlParameter.Optional },

                new string[] { "Marketing.Controllers" });

        }
    }
}