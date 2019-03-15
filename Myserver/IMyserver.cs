using System.Collections.Generic;

namespace core_bili.Myserver
{
    public interface IMyserver<T> where T:class
    {
        IEnumerable<T> GetAll();
    }
}
