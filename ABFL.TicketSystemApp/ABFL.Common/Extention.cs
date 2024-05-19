using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMMON
{
    public static class Extention
    {
        public static IList<T> ConvertIEnumerableToList<T>(this IEnumerable<T> objectList)
        {
            IList<T> _List = new List<T>();
            foreach (var obj in objectList)
            {
                _List.Add(obj);
            }
            return _List;
        }
    }
}
