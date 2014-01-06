using BetterCms.Core.Models;

namespace BetterCms.Module.Pages.Models.Maps
{
    public class SitemapArchiveMap : EntityMapBase<SitemapArchive>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapArchiveMap"/> class.
        /// </summary>
        public SitemapArchiveMap() : base(PagesModuleDescriptor.ModuleName)
        {
            Table("SitemapArchives");

            Map(x => x.ArchivedVersion).Nullable().Length(MaxLength.Max);

            References(x => x.Sitemap).Cascade.None().LazyLoad();
        }
    }
}