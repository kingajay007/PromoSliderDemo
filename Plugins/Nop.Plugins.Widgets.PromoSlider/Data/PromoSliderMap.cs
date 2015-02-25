using Nop.Plugins.Widgets.PromoSlider.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugins.Widgets.PromoSlider.Data
{
    public class PromoSliderMap : EntityTypeConfiguration<PromoSliderRecord>
    {
        public PromoSliderMap()
        {
            ToTable("PromoSlider_PromoSliders");
            HasKey(m=>m.PromoSliderId);
            Property(m => m.Interval);
            Property(m => m.IsActive);
            Property(m => m.PauseOnHover);
            Property(m => m.PromoSliderName);
            Property(m => m.Wrap);
            Property(m => m.ZoneName);

        }
    }
}
