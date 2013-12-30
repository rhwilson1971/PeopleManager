using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using PeopleManager.Infrastructure;
using PeopleManager.Data;

namespace PeopleManager.Management
{
    [Export(typeof(UserDetailViewModel))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class UserDetailViewModel  : NotificationObject
    {
        #region Fields
        private string firstName;
        private string lastName;
        private string imageLocation;
        private readonly IFileBrowserService fileBrowser;
        private readonly IEventAggregator eventAggregator;
        #endregion

        #region Constructor
        [ImportingConstructor]
        public UserDetailViewModel(IFileBrowserService fileBrowser, IEventAggregator eventAggregator)
        {
            this.fileBrowser = fileBrowser;

            BrowseCommand = new DelegateCommand( this.BrowseForImageFile, this.CanBrowse );

            this.eventAggregator = eventAggregator;
            this.eventAggregator.GetEvent<PersonSelectedEvent>().Subscribe(this.PersonWasSelected, ThreadOption.UIThread);
        }
        #endregion

        #region Properties
        public ICommand BrowseCommand { get; private set; }

        public string FirstName { 
            
            get { return this.firstName;}
            set
            {
                if (this.firstName == value)
                {
                    return;
                }

                this.firstName = value;
                this.RaisePropertyChanged(() => this.FirstName);
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (this.lastName == value)
                {
                    return;
                }

                this.lastName = value;
                this.RaisePropertyChanged(() => this.LastName);
            }
        }

        public string ImageLocation
        {
            get { return this.imageLocation; }
            set
            {
                if (this.imageLocation == value)
                {
                    return;
                }

                this.imageLocation = value;
                this.RaisePropertyChanged(() => this.ImageLocation);
            }
        }
        #endregion

        #region Private Implementation
        private void BrowseForImageFile()
        {
            ImageLocation =
                fileBrowser.OpenBrowserDialog(Environment.CurrentDirectory);

        }

        private bool CanBrowse() { return true; }

        private void PersonWasSelected(Person person)
        {
            if (null != person)
            {
                FirstName = person.FirstName;
                LastName = person.LastName;
                ImageLocation = person.Image;
            }
        }
        #endregion
    }
}
