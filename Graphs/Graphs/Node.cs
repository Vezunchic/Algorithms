using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Node
    {
        public int Value { get; set; }
        public List<Edge> Edges { get; set; } //исходящие связи
        
    }
}
