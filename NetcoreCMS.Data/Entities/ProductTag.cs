using NetcoreCMS.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetcoreCMS.Data.Entities
{
    public class ProductTag: DomailEntity<int>
    {
        public int ProductId { get; set;}
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string TagId { get; set; }
        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
 
    }
}
