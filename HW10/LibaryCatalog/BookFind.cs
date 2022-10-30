using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.LibaryCatalog;

public class BookFind
{
    public void Main()
    {
        var findBook = @"C:\Users\User\Desktop\HM\HW10\HW10\LibaryCatalog\Book.txt";
        var InputArray = File.ReadAllLines (findBook);
    }
    
}
