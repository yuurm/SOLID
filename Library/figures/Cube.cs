﻿using System;
using Library.figures.@abstract;

namespace Library.figures
{
    public partial class Cube
    {
        private double _a;
        
        public Cube(int figureId, double a) 
        {
            _a = a;
        }

        public double Area => 6 * _a * _a;
     

        public FigureType FigureType => FigureType.Cube;
        public int FigureId { get; }

        public int TestMethod()
        {
            return -100;
        }

        public int GetAnglesCount()
        {
            return 8;
        }

        public double Volume => Math.Pow(_a, 3);

    }
}