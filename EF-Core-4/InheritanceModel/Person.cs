using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_4.InheritanceModel
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
