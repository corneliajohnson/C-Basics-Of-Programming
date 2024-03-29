﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    //structors use the keyword struct instead of class
    // a structor can have fields, properties and methods just like a class
    //does not support inheritance
    //can not intialize field at the point of decloration 

    struct Vector
    {
        private int _x;
        private int _y;
        private int _z;


        public Vector(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public int Z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }

        public void DisplayVector()
        {
            Console.WriteLine($"{_x}{_y}{_z}");
        }
    }
}
