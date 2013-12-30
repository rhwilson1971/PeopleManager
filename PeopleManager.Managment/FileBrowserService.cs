using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.Management
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFileBrowserService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="defaultPath"></param>
        /// <returns></returns>
        string OpenBrowserDialog(string defaultPath);
    }

    [Export(typeof(IFileBrowserService))]
    public class FileBrowserService : IFileBrowserService
    {
        public string OpenBrowserDialog(string defaultPath)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = defaultPath;
            
            ofd.OpenFile();

            return ofd.FileName;
        }
    }
}
