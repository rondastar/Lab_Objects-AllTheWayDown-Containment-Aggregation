using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Objects_AllTheWayDown_Containment_Aggregation
{
    internal class EyewearDepartment
    { 
        List<Sunglasses> _inventorySunglasses; 

        public EyewearDepartment()
        {
            _inventorySunglasses = new List<Sunglasses>(); // containment
        }

        internal List<Sunglasses> InventorySunglasses { get => _inventorySunglasses; }



        public void AddSunglasses(Sunglasses sunglasses)
        {
            InventorySunglasses.Add(sunglasses);
        }
    }

}
