using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using vbgCMS.Infrastructure.CMS;
using FluentNHibernate.Mapping;

namespace vbgCMS.Data.Mappings
{
    public class PageMap : ClassMap<Page>
    {
        public PageMap()
        {
            Id(x => x.Id).GeneratedBy.HiLo("0").UnsavedValue(default(long));
            Map(x => x.Title);
            Map(x => x.Slug);

            References<Site>(x => x.Site);

            HasMany<Zone>(x => x.Zones).AsSet().Cascade.AllDeleteOrphan();
            HasMany<Widget>(x => x.Widgets).AsSet().Cascade.AllDeleteOrphan();
            Version(x => x.Version);
        }
    }
}
