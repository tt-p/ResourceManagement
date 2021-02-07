using System.Collections.Generic;
using System.Data;

namespace FP_Group_27.ERMS.Data
{
    interface IDbCommon<T>
    {
        abstract T Get(int tid);
        abstract DataTable GetAll();
        abstract void Insert(T t);
        abstract void InsertAll(IEnumerable<T> ts);
        abstract DataTable Search(string searchText);
        abstract void Update(T t);
        abstract void Delete(int tid);
    }
}
