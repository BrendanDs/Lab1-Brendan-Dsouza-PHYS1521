/*
Add this file to your Mathematics folder of the Engine project!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mathematics
{
    public class Eng_Vector2D
    {
        //1.a - Properties (component form of a vector).
        public double x
        { get { return x; } set { x = value; } }

        public double y
        { get { return y; } set { y = value; } }

        public double Distance
        { get { return Math.Sqrt((x * x) + (y * y)); } }

        //1.b - Empty Constructor.
        public double Vector2D()
        { return x = 0; y = 0; }
        //1.c - Non-empty constructor.
        public double Vector2D(double x, double y)
        { { return this.x = x; this.y = y; } }
            
    #region Class Methods
    // 2.a - Magnitude of a 2D vector; DO NOT use Math.Pow()
    public double Magnitude(Eng_Vector2D a)
        {
            { return Math.Sqrt((a.x * a.x) + (a.y * a.y)); }
           
        }//end of Magnitude

        //2.b - The Dot Product of two 2D vectors.
        public double DotProduct(Eng_Vector2D a,Eng_Vector2D b)
        {
            return ((a.x * a.x) + (a.y * a.y));
        }//end of DotProduct

        //2.c – The angle between two 2D vectors.
        //      [MUST use the Functions.ToDegrees() method to return the angle in degrees]
        public double AngleBetweenVectors(Eng_Vector2D a, Eng_Vector2D b)
        {
            double x = a.x - b.x;
            double y = a.y - b.y;
            return Math.Atan2(y, x);
            
        }//end of AngleBetweenVectors

        //2.d – To Normalize a 2D vector.
        public void Normalize()
        {
			
	}//end of Normalize
        #endregion

        #region Overload Operators
        #region Complier Warning Fix
        // the following two methods are to remove the CS0660 and CS0661 compiler warnings
        #pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override bool Equals(object obj)
        {
            return true;
        }//eom
	#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override int GetHashCode()
        {
            return 0;
        }//eom
        #endregion
        //Complete the following overload operators
        //3.a - Adding two 2D vectors.
	public static Eng_Vector2D operator +(Eng_Vector2D a, Eng_Vector2D b)
        {
            return null;
        }//eom

	//3.b - Subtracting two 2D vectors.
        public static Eng_Vector2D operator -(Eng_Vector2D a, Eng_Vector2D b)
        {
            return null;
        }//eom

        //3.c.1 - Multiplying a 2D vector by a scalar (s * v)
        public static Eng_Vector2D operator *(double s, Eng_Vector2D v)
        {
            return null;
        }//eom

        //3.c.2 - Multiplying a 2D vector by a scalar (v * s)
        public static Eng_Vector2D operator *(Eng_Vector2D v, double s)
        {
            return null;
        }//eom
        
	//3.d - Equality of two 2D vectors.
	public static bool operator ==(Eng_Vector2D a, Eng_Vector2D b)
        {
            return true;
        }//eom	 

        //3.e - Inequality of two 2D vectors
        public static bool operator !=(Eng_Vector2D a, Eng_Vector2D b)
        {
            return true;
        }//eom
        #endregion
    }//eoc
}//eom
