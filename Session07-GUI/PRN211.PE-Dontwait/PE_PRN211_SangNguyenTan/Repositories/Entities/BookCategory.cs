using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class BookCategory
    {
        //backing fill public propfull + tab tab
        //public private int myVar;

        //public int MyProperty
        //{
        //	get { return myVar; }
        //	set { myVar = value; }
        //}

        //public prop + tab
        public int BookCategoryId { get; set; }
        public string BookGenreType { get; set; }
        public string Description { get; set; } 

    }
}
