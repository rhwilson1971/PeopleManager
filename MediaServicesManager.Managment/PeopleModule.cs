using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaServicesManager.Infrastructure;
using Microsoft.Practices.Prism.MefExtensions.Modularity;

namespace MediaServicesManager.Management
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
            this.regionManager.RegisterViewWithRegion(RegionNames.UserDetailRegion, typeof(MediaServicesManager.Management.Views.UserDetailView));
            this.regionManager.RegisterViewWithRegion(RegionNames.PeopleViewRegion, typeof(MediaServicesManager.Management.Views.PeopleView));
        }
    }
}
