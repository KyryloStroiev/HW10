using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.LibaryCatalog;

public class Visiting

{
    public int Id;
    public string Name;
    public string LastName;
    public int Phone;
    public Visiting(int id, string name, string lastName, int phone)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Phone = phone;
    }
}
