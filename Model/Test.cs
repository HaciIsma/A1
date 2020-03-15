using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace A1.Model
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public List<Question> Questions = new List<Question>();
    }
}
