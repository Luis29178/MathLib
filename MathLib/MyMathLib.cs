using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathLib
{
    public class MyMathlib
    {
        float x;
        float y;

        public MyMathlib()
        {
            x = 0.0f;
            y = 0.0f;
        }

        public MyMathlib(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        // Smallest positive value greater than 0
        public float Epsilon
        {
            get
            {
                return float.Epsilon;
            }
        }

        // Not a number
        public float NaN
        {
            get
            {
                return float.NaN;
            }
        }

        public float Add()
        {
            return x + y;
        }

        public float Subtract()
        {
            return x - y;
        }

        // Behavior 1: return 12.0 times 3.0 == 36.0
        // Behavior 2: if x and y are float.PositiveInfinty then throw NotFiniteNumberException
        public float Multiply()
        {
            float result = x * y;

            if (float.IsPositiveInfinity(result))
            {
                throw new NotFiniteNumberException();
            }

            return result;
        }


        // Behavior 1: return 10.0 divided by 2.0 == 5.0
        // Behavior 2: if x == float.MinValue and y == float.MinValue throw NotFiniteNumberException 
        // Behavior 3: if y == 0 throw DivideByZero exception
        public float Divide()
        {
            if (x == float.MinValue && y == float.MinValue)
            {
                throw new NotFiniteNumberException();
            }

            if (y == 0.0)
            {
                throw new DivideByZeroException();
            }

            return x / y;
        }
    }
}