﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car1.color = "red";
            Car1.brand = "Toyota";

            //note: the currentspeed = 0 is definded the the construtor

            Car Car2 = new Car("green", "Honda");

            Car2.color = "green";
            Car2.brand = "Honda";

            Car1.Accelerate(20);
            Car2.Accelerate(20);
            Car2.Decelerate(10);

            Car1.DisplaySpeed();
            Car2.DisplaySpeed();

            Console.ReadKey();
        }
    }
}
