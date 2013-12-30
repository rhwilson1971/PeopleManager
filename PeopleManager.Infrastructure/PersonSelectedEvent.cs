using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Prism.Events;
using PeopleManager.Data;

namespace PeopleManager.Infrastructure
{
    public class PersonSelectedEvent : CompositePresentationEvent<Person>
    {
    }
}
