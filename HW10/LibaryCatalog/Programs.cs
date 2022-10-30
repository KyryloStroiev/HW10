using HW10.LibaryCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



var staff = new List<Staff>
        {
            new Staff(1, "User", "Userovih"),
            new Staff(2, "Kyrylo", "Stroiev"),
            new Staff(3,"Jon", "Bon")
        };
var AddStaff = @"C:\Users\User\Desktop\HM\HW10\HW10\LibaryCatalog\Staff.txt";
var outputArray = staff.Select(x => $"{x.Id}, {x.Name}, {x.LastName}").ToArray();
File.WriteAllLines(AddStaff, outputArray);


var bookadd = new List<BookAdd>
        {
            new BookAdd(1, "User", "Userovih"),
            new BookAdd(2, "Сяйво", "Стівен Кінг"),
            new BookAdd(3,"1984", "Джордж Орвелл")
        };
var AddBook = @"C:\Users\User\Desktop\HM\HW10\HW10\LibaryCatalog\Book.txt";
var outputArray2 = bookadd.Select(x => $"{x.Id}, {x.Name}, {x.Autor}").ToArray();
File.WriteAllLines(AddBook, outputArray2);

var visiting = new List<Visiting>
        {
            new Visiting(1, "User", "Userovih", 05358646),
            new Visiting(2, "Lana", "Olena", 01234578),
            new Visiting(3,"Mark", "Pork", 012565022)
        };
var AddVisiting = @"C:\Users\User\Desktop\HM\HW10\HW10\LibaryCatalog\Visiting.txt";
var outputArray3 = visiting.Select(x => $"{x.Id}, {x.Name}, {x.LastName}, +38{x.Phone}").ToArray();
File.WriteAllLines(AddVisiting, outputArray3);