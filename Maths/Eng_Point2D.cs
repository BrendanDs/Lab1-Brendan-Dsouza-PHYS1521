using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mathematics
{
    public class Eng_Point2D
    {
        // Properties
        public double X { get; set; }
        public double Y { get; set; }

        // Empty Constructor
        public Eng_Point2D()
        {
            X = 0;
            Y = 0;
        }//eom

        // Greedy Constructor
        public Eng_Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }//eom

        #region Class Methods
        public double SegmentLength(Eng_Point2D b)
        {
            return 0;
        }//eom

        public Eng_Point2D MidPoint(Eng_Point2D b)
        {
            return null;
        }//eom
        #endregion

        #region Overload Operators
        #region Complier Warning Fix
        // the following two methods are to remove the CS0660 and CS0661 compiler warnings
        #pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override bool Equals(object obj)
        {
            return true;
        }//eom
        #pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override int GetHashCode()
        {
            return 0;
        }//eom
        #endregion
        // the == and != must both be coded or you get a compile error
        public static bool operator ==(Eng_Point2D a, Eng_Point2D b)
        {
            return true;
        }//eom

        public static bool operator !=(Eng_Point2D a, Eng_Point2D b)
        {
            return true;
        }//eom

        // s * p
        public static Eng_Point2D operator *(double s, Eng_Point2D p)
        {
            return null;
        }//eom

        // p * s
        public static Eng_Point2D operator *(Eng_Point2D p, double s)
        {
            return null;
        }//eom
        #endregion
        public double Segment_Length(Eng_Point2D b)
        {
            return Math.Sqrt(Math.Pow(b.X - X, 2) + Math.Pow(b.Y - Y, 2));
        }

        public Eng_Point2D Mid_Point(Eng_Point2D b)
        {
            return new Eng_Point2D(0.5 * (X + b.X), 0.5 * (Y + b.Y));
        }

        public static bool operator ==(Eng_Point2D a, Eng_Point2D b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Eng_Point2D a, Eng_Point2D b)
        {
            return a.X != b.X || a.Y != b.Y;
        }

        public static Eng_Point2D operator *(double s, Eng_Point2D p)
        {
            return new Eng_Point2D(s * p.X, s * p.Y);
        }

        public static Eng_Point2D operator *(Eng_Point2D p, double s)
        {
            return new Eng_Point2D(p.X * s, p.Y * s);
        }
    }//eoc
}//eon
