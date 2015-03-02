using Nop.Core.Plugins;
using Nop.Plugins.Widgets.PromoSlider.Data;
using Nop.Services.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace Nop.Plugins.Widgets.PromoSlider
{
    public class PromoSliderPlugin : BasePlugin,IWidgetPlugin
    {
        private PromoSliderObjectContext _context;
        public PromoSliderPlugin(PromoSliderObjectContext context)
        {
            this._context = context;
        }

        public override void Install()
        {
            _context.Install();
            base.Install();
        }

        public override void Uninstall()
        {
            _context.Uninstall();
            base.Uninstall();
        }

        public void GetConfigurationRoute(out string actionName, out string controllerName, out System.Web.Routing.RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "PromoSlider";
            routeValues = new RouteValueDictionary()
            {
                {"Namespaces","Nop.Plugins.Widgets.PromoSlider.Controllers"},
                {"area",null},
            };
        }

        public void GetDisplayWidgetRoute(string widgetZone, out string actionName, out string controllerName, out System.Web.Routing.RouteValueDictionary routeValues)
        {
            actionName = "PromoSliderWidget";
            controllerName = "PromoSlider";
            routeValues = new RouteValueDictionary()
            {
                {"Namespaces","Nop.Plugins.Widgets.PromoSlider.Controllers"},
                {"area",null},
                {"widgetZone",widgetZone}
            };
        }

        public IList<string> GetWidgetZones()
        {
            return new List<string>();
        }
    }
}
