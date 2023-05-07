using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Objects_AllTheWayDown_Containment_Aggregation
{
    internal class Lenses
    {
        int? _UVProtection;
        string _color;

        public Lenses(int? uVProtection, string color)
        {
            _UVProtection = uVProtection;
            _color = color;
        }
        public int? UVProtection { get => _UVProtection; set => _UVProtection = value; }
        public string Color { get => _color; set => _color = value; }
    }
}
