using System;
using System.Collections.Generic;
using System.Text;

namespace NetcoreCMS.Data.Interfaces
{
    public interface IMultilLanguage<T>
    {
        T LaguageId { set; get; }
    }
}
