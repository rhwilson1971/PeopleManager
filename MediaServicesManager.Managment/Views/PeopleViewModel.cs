using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediaServicesManager.Data;
using MediaServicesManager.Infrastructure;

using System.ComponentModel;
using Microsoft.Practices.Prism.Events;
using System.Windows.Data;

namespace MediaServicesManager.Management.Views
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class PeopleViewModel : NotificationObject
    {
        private readonly IEventAggregator eventAggregator;

        [ImportingConstructor]
        public PeopleViewModel(IRepository<Person> repository, IEventAggregator eventAggregator)
        {
            People = new ListCollectionView(repository.Get());

            People.CurrentChanged += new EventHandler(OnSelectedItemChanged);

            this.eventAggregator = eventAggregator;
        }

        public ICollectionView People { get; private set; }

        private void OnSelectedItemChanged(object sender, EventArgs e)
        {
            Person current = People.CurrentItem as Person;

            this.eventAggregator.GetEvent<PersonSelectedEvent>().Publish(current);
        }
    }
}
