using System;
using System.Collections.Generic;
using System.Text;

namespace NetcoreCMS.Infrastructure.ShareKernel
{
    public abstract class DomailEntity<T>
    {
        public T Id { get; set; }
        // kiem tra xem kieu du lieu cua Id co giong gia tri mac dinh cua kieu T hay k
        // true neu DomailEntity co identity
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}
