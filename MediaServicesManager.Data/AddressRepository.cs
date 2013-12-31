using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServicesManager.Data
{
    [Export(typeof(IRepository<Address>))]
    public class AddressRepository : IRepository<Address>
    {
        TestDataEntities db = new TestDataEntities();

        public ObservableCollection<Address> Get()
        {
            return new ObservableCollection<Address>(db.Addresses.ToList<Address>());
        }

        public void Add(Address a)
        {
            db.Entry(a);
            db.SaveChanges();
        }

        public void Delete(Address a)
        {
            throw new NotImplementedException("Del not implemented yet");
        }
    }
}
