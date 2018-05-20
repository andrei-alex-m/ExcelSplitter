using System;
using Caly.Utils;
namespace CS.BusinessLayer.Repo
{
    public interface BaseRepo<T> where T:BaseObject
    {
        T Get(int Id);

        void Delete(int Id);

        bool Update(T obj);

        IEnumerable<T> GetAll();


    }

    public class o:BaseRepo<BaseObject>
    {

    }
}
