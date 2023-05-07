using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_Objects_AllTheWayDown_Containment_Aggregation.Sunglasses;

namespace Lab_Objects_AllTheWayDown_Containment_Aggregation
{
    internal class Frames
    {
        string _color;
        float _widthInInches;
        string _brand;

        public Frames(string color, float widthInInches, string brand)
        {
            _color = color;
            _widthInInches = widthInInches;
            _brand = brand;
        }

        public string Color { get => _color; set => _color = value; }
        public float WidthInInches { get => _widthInInches; set => _widthInInches = value; }
        public string Brand { get => _brand; set => _brand = value; }
    } // class
} // namespace
