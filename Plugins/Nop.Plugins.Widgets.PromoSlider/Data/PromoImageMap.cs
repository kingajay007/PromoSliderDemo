using Nop.Plugins.Widgets.PromoSlider.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugins.Widgets.PromoSlider.Data
{
    public class PromoImageMap : EntityTypeConfiguration<PromoImageRecord>
    {
        public PromoImageMap()
        {
            ToTable("PromoSlider_PromoImages");
            HasKey(m=>m.PromoImageId);
            Property(m=>m.Caption);
            Property(m => m.DisplayOrder);
            Property(m => m.FilePath);
            Property(m => m.Url);

            this.HasRequired(i => i.PromoSlider)
                .WithMany(s => s.Images)
                .HasForeignKey(i=>i.PromoSliderId);
        }
    }
}
