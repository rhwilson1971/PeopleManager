using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.Data
{
    [Export(typeof(IRepository<Person>))]
    public class PersonRepository : IRepository<Person>
    {
        TestDataEntities db;

        public PersonRepository()
        {
            db = new TestDataEntities();
        }

        public ObservableCollection<Person> Get()
        {
            return new ObservableCollection<Person>(db.People.ToList<Person>());
        }

        public void Add(Person p)
        {
            db.Entry(p);
            db.SaveChanges();
        }

        public void Delete(Person p)
        {
            throw new NotImplementedException("Del not implemented yet");
        }
    }
}
