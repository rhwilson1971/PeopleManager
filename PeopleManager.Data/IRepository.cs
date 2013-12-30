using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.Data
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ObservableCollection<T> Get();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        void Add(T p);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        void Delete(T p);
    }
}
