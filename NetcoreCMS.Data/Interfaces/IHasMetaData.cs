using System;
using System.Collections.Generic;
using System.Text;

namespace NetcoreCMS.Data.Interfaces
{
    public interface IHasMetaData
    {
        string SeoPageTitle { set; get; }
        string SeoAlias { set; get; }
        string SeoKeywords { set; get; }
        string SeoDescription { set; get; }
    }
}
