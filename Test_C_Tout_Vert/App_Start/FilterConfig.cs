using System.Web;
using System.Web.Mvc;

namespace Test_C_Tout_Vert
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
