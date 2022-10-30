using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.LibaryCatalog;

public class Staff
{
    public int Id;
    public string Name;
    public string LastName;
    public Staff(int id, string name, string lastName)
    {
        Id = id;
        Name = name;
        LastName = lastName;
    }
 
}
