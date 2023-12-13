using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAtlas.Core.Models
{
    public class Collection
    {
  
        public string Id { get; set; }
        public  string Name { get; set; }
        public bool Singleton { get; set; }
        //public List<Field> Fields { get; set; }
    }
}
