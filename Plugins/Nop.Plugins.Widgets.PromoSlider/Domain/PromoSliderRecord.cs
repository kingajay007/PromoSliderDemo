using Nop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugins.Widgets.PromoSlider.Domain
{
    class PromoSliderRecord : BaseEntity
    {
        public PromoSliderRecord()
        {
            Images = new List<PromoImageRecord>();
        }
        public virtual int PromoSliderId { get; set; }
        public virtual String PromoSliderName { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual String ZoneName { get; set; }
        public virtual int Interval { get; set; }
        public virtual bool PauseOnHover { get; set; }
        public virtual bool Wrap { get; set; }
        public virtual bool Keyboard { get; set; }

        public virtual List<PromoImageRecord> Images { get; set; }
    }
}
