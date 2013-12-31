using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServicesManager.Data
{
    [Export(typeof(IRepository<PhoneNumber>))]
    public class PhoneRepository : IRepository<PhoneNumber>
    {
        TestDataEntities db = new TestDataEntities();

        public ObservableCollection<PhoneNumber> Get()
        {
            return new ObservableCollection<PhoneNumber>(db.PhoneNumbers.ToList<PhoneNumber>());
        }

        public void Add(PhoneNumber p)
        {
            db.Entry(p);
            db.SaveChanges();
        }

        public void Delete(PhoneNumber p)
        {
            throw new NotImplementedException("Del not implemented yet");
        }
    }
}
