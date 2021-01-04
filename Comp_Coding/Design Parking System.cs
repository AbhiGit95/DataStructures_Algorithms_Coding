using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Design_Parking_System
    {
        Dictionary<int, int> car_map;
        public Design_Parking_System(int big, int medium, int small)
        {
            car_map = new Dictionary<int, int>();
            car_map.Add(1, big);
            car_map.Add(2, medium);
            car_map.Add(3, small);
        }

        public bool AddCar(int carType)
        {
            if (car_map[carType] > 0)
            {
                car_map[carType] -= 1;
                return true;
            }
            else
                return false;
        }
    }
}
