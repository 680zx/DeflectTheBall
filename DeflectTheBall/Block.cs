using System;
using System.Collections.Generic;
using System.Text;

namespace DeflectTheBall
{
    class Block
    {
        //Block's x coordinate specifies the leftmost corner; 
        //y coordinate means the height at which block will be
        //located; there are one-dimensional blocks only.
        private int[] _x = new int[3]; 
        private int _y;

        public int[] X => _x;
        public int Y => _y;

        public Block(int x, int y)
        {
            _x[0] = x;
            _x[1] = x + 1;
            _x[2] = x + 2;
            _y = y;
            Create();
        }

        public void Create()
        {
            //if (! isNear())
            //{
                foreach (int xCoord in _x)
                {
                    Console.SetCursorPosition(xCoord, _y);
                    Console.Write("-");
                }
            //}
        }

        public void Destroy()
        {
            foreach (int xCoord in _x)
            {
                Console.SetCursorPosition(xCoord, _y);
                Console.Write(" ");
            }
        }

        public void CreateTriangle()
        {
             
        }
        
        private bool isNear()
        {
            return false;
        }

    }
}