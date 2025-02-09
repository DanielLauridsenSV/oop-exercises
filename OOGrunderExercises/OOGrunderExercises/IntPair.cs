﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOGrunderExercises
{
    class IntPair
    {
        private int _value1;
        private int _value2;
        private double _average;

        public int Value1
        {
            get
            {
                return _value1;
            }
            set
            {
                _value1 = value;
                RecomputeAverage();
            }
        }

        public int Value2
        {
            get
            {
                return _value2;
            }
            set
            {
                _value2 = value;
                RecomputeAverage();
            }
        }

        public double Average
        {
            get
            {
                return _average;
            }
        }

        public IntPair(int value1, int value2)
        {
            _value1 = value1;
            _value2 = value2;
            RecomputeAverage();
        }

        private void RecomputeAverage()
        {
            _average = (_value1 + _value2) / 2.0;
        }

        public int GetValue1()
        {
            return _value1;
        }
        public int GetValue2()
        {
            return _value2;
        }
        public double GetAverage()
        {
            return _average;
        }


        public void SetValue1(int value1)
        {
            _value1 = value1;
            RecomputeAverage();
        }
        public void SetValue2(int value2)
        {
            _value2 = value2;
            RecomputeAverage();
        }

    }
}
