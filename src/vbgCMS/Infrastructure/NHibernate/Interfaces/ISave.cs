using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vbgCMS.Infrastructure.NHibernate.Interfaces
{
    public interface ISave<T>
    {
        void Save(T obj);
    }
}
