using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServicesManager.Data
{
    public class ResourcesRepository : IRepository<Resource>
    {
        TestDataEntities db = new TestDataEntities();

        public ObservableCollection<Resource> Get()
        {
            return new ObservableCollection<Resource>(db.Resources.ToList<Resource>());
        }

        public void Add(Resource p)
        {
            db.Entry(p);
            db.SaveChanges();
        }

        public void Delete(Resource p)
        {
            throw new NotImplementedException("Del not implemented yet");
        }
    }
}
