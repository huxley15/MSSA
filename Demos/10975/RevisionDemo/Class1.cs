using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionDemo
{
    class Movie
    {
        //other way
        public string Title { get; set; }  //private field created
        private int id; //field
        public int MovieId
        {
            get
            {
                return this.id
            }
            set
            {
                this.id = value;
            }
        }
        public Movie(int id)
        {
            this.id = id; 
        }
    }
}
