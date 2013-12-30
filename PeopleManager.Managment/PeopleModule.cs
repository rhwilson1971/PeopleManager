using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleManager.Infrastructure;
using Microsoft.Practices.Prism.MefExtensions.Modularity;

namespace PeopleManager.Management
{
    [ModuleExport(typeof(PeopleModule))]
    public class PeopleModule : IModule
    {
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public PeopleModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion(RegionNames.UserDetailRegion, typeof(PeopleManager.Management.Views.UserDetailView));
            this.regionManager.RegisterViewWithRegion(RegionNames.PeopleViewRegion, typeof(PeopleManager.Management.Views.PeopleView));
        }
    }
}
