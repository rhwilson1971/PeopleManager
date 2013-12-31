using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServicesManager.Data
{
    public class ProgramDetailRepository : IRepository<ProgramDetail>
    {
        TestDataEntities db = new TestDataEntities();

        public ObservableCollection<ProgramDetail> Get()
        {
            return new ObservableCollection<ProgramDetail>(db.ProgramDetails.ToList<ProgramDetail>());
        }

        public void Add(ProgramDetail p)
        {
            db.Entry(p);
            db.SaveChanges();
        }

        public void Delete(ProgramDetail p)
        {
            throw new NotImplementedException("Del not implemented yet");
        }
    }
}
