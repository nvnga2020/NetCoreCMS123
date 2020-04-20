using NetcoreCMS.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetcoreCMS.Data.Entities
{
    public class Tag: DomailEntity<string>
    {
        [MaxLength(50)]
        [Required]
        public string Name { set; get; }
        [MaxLength(50)]
        [Required]
        public string Type { set; get; }
    }
}
