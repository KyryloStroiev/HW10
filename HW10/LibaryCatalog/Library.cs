using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.LibaryCatalog;

public  class Library
{
    public int Id;
    public string Name;
    public Library(int id, string name)
    {
        Id = id;
        Name = name;
    }
    static void Main()
    {
        var library = new Library(234, "Generaly Library");
    }
 
};
