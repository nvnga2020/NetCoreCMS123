using NetcoreCMS.Data.Enums;
using NetcoreCMS.Data.Interfaces;
using NetcoreCMS.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetcoreCMS.Data.Entities
{
    public class ProductCatalog : DomailEntity<int>, IHasMetaData,ISwitchable,ISortable,IDateTracking
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { set; get; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public string SeoPageTitle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SeoAlias { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SeoKeywords { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SeoDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateCreated { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateModified { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SortOrder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Status Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
