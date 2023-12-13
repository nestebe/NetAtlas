using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAtlas.Core.Models
{
    public enum Width
    {
        Half,
        HalfLeft,
        HalfRight,
        Full,
        Fill
    }

    public class Field
    {
        public int Id { get; set; }
        public string Collection { get; set; }
        public string Group { get; set; }
        public bool Hidden { get; set; }
        public string Interface { get; set; }
        public string Display { get; set; }
        public Dictionary<string, object> Options { get; set; }
        public Dictionary<string, object> DisplayOptions { get; set; }
        public bool Readonly { get; set; }
        public bool Required { get; set; }
        public int? Sort { get; set; }
        public Width? Width { get; set; }
        public string Note { get; set; }
        public object Validation { get; set; }
        public string ValidationMessage { get; set; }
    }

}
