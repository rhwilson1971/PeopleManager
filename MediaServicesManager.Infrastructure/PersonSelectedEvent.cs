using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Prism.Events;
using MediaServicesManager.Data;

namespace MediaServicesManager.Infrastructure
{
    public class PersonSelectedEvent : CompositePresentationEvent<Person>
    {
    }
}
