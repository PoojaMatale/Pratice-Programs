using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Constructor
{
    public  class Book
    {
        private int id;
        private string name;
        private string author;

        public Book(int id,string name,string author)
        {
            this.id = id;
            this.name = name;
            this.author = author;
        }
        public string display()
        {
            return $"{id},{name},{author}";
        }
    }
    
    
      




        
    
}
