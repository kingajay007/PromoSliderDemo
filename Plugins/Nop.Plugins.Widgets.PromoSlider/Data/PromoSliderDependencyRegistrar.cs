using Nop.Core.Infrastructure.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Web.Framework.Mvc;
using Nop.Plugins.Widgets.PromoSlider.Domain;
using Nop.Core.Data;
using Nop.Data;
using Autofac.Core;
using Autofac;

namespace Nop.Plugins.Widgets.PromoSlider.Data
{
    public class PromoSliderDependencyRegistrar : IDependencyRegistrar
    {
        private const string CONTEXT_NAME = "nop_object_context_promo_slider";
        public int Order
        {
            get { return 1; }
        }

        public void Register(Autofac.ContainerBuilder builder, Core.Infrastructure.ITypeFinder typeFinder)
        {
            this.RegisterPluginDataContext<PromoSliderObjectContext>(builder,CONTEXT_NAME);

            builder.RegisterType<EfRepository<PromoSliderRecord>>()
                .As<IRepository<PromoSliderRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
                .InstancePerLifetimeScope();

            builder.RegisterType<EfRepository<PromoImageRecord>>()
                .As<IRepository<PromoImageRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
                .InstancePerLifetimeScope();
        }
    }
}
