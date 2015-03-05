using Nop.Core.Plugins;
using Nop.Plugin.Widgets.PromoSlider.Data;
using Nop.Services.Cms;
using Nop.Web.Framework.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc.Routing;
using System.Web.Routing;

namespace Nop.Plugin.Widgets.PromoSlider
{
    public class PromoSliderPlugin : BasePlugin,IWidgetPlugin,IAdminMenuPlugin
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
                {"Namespaces","Nop.Plugin.Widgets.PromoSlider.Controllers"},
                {"area",null}
            };
        }

        public void GetDisplayWidgetRoute(string widgetZone, out string actionName, out string controllerName, out System.Web.Routing.RouteValueDictionary routeValues)
        {
            actionName = "PromoSliderWidget";
            controllerName = "PromoSlider";
            routeValues = new RouteValueDictionary()
            {
                {"Namespaces","Nop.Plugin.Widgets.PromoSlider.Controllers"},
                {"area",null},
                {"widgetZone",widgetZone}
            };
        }

        public IList<string> GetWidgetZones()
        {
            return new List<string>();
        }

        public bool Authenticate()
        {
            return true;
        }

        public SiteMapNode BuildMenuItem()
        {
            var parentNode = new SiteMapNode()
            {
                Visible=true,
                Title="Promo Slider",
                Url="/PromoSlider/CreateUpdatePromoSlider"
            };

            var createUpdateNode = new SiteMapNode()
            {
                Visible = true,
                Title = "New Slider",
                Url = "/PromoSlider/CreateUpdatePromoSlider"
            };

            var manageSliders = new SiteMapNode()
            {
                Visible = true,
                Title = "Manage Slider",
                Url = "/PromoSlider/ManagePromoSliders"
            };

            parentNode.ChildNodes.Add(createUpdateNode);
            parentNode.ChildNodes.Add(manageSliders);
            return parentNode;
        }
    }
}
