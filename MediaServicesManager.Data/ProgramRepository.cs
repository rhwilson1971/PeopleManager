using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServicesManager.Data
{
    public class ProgramRepository : IRepository<Program>
    {
        TestDataEntities db = new TestDataEntities();

        public ObservableCollection<Program> Get()
        {
            return new ObservableCollection<Program>(db.Programs.ToList<Program>());
        }

        public void Add(Program p)
        {
            db.Entry(p);
            db.SaveChanges();
        }

        public void Delete(Program p)
        {
            throw new NotImplementedException("Del not implemented yet");
        }
    }
}
