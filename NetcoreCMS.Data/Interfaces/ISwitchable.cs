using NetcoreCMS.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetcoreCMS.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
