using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Mef
using System.ComponentModel.Composition;
using System.ComponentModel;

// Prism
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.Prism.Events;

using System.Diagnostics;
using System.Windows.Data;

using MediaServicesManager.Data;
using MediaServicesManager.Infrastructure;

namespace MediaServicesManager.ViewModels
{
    [Export]
    public class ShellViewModel : NotificationObject
    {

        #region Fields
        //private ObservableCollection<Person> people;
        //private Person currentPerson;
        private readonly IEventAggregator eventAggregator;
        #endregion

        #region Properties
        public ICollectionView People { get; private set; }
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="eventAggregator"></param>
        [ImportingConstructor]
        public ShellViewModel(IRepository<Person> repository, IEventAggregator eventAggregator)
        {
            People = new ListCollectionView(repository.Get());

            People.CurrentChanged += new EventHandler(SelectedItemChanged);

            this.eventAggregator = eventAggregator;
        }
        #endregion

        #region Private Implementation
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedItemChanged(object sender, EventArgs e)
        {
            Person current = People.CurrentItem as Person;

            this.eventAggregator.GetEvent<PersonSelectedEvent>().Publish(current);

            Trace.WriteLine("Person selected");
        }
        #endregion
        //public ObservableCollection<Person> People
        //{
        //    get
        //    {
        //        return people;
        //    }
        //}

        //public Person SelectedPerson
        //{
        //    get { return currentPerson; }

        //    set
        //    {
        //        if (currentPerson != value)
        //        {
        //            currentPerson = value;
        //            this.RaisePropertyChanged<Person>(() => this.SelectedPerson);
        //            if (null != currentPerson)
        //            {
        //                this.eventAggregator.GetEvent<PersonSelectedEvent>().Publish(currentPerson);
        //                Trace.WriteLine("Person selected");
        //            }
        //        }
        //    }
        //}
    }
}
