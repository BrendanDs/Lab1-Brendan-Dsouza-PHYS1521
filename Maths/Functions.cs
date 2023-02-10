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
    public class Functions
    {
        // Listing 1: Sample Tuple<> Method
        public static Tuple<double, double> CalculateTuple(double val1, double val2)
        {
            // do some calculations
            double result1 = val1 * val2;
            double result2 = val1 / val2;
            return new Tuple<double, double>(result1, result2);
        }//eom
        public class Trigometry
        {
            //Convert Radians To Degrees
            public static double Con_RadToDeg(double radians)
            {
                double degrees = (180 / Math.PI) * radians;
                return (degrees);
            }
            //Convert Degrees To Radians
            public static double Con_DegToRad(double degrees)
            {
                double radians = (Math.PI / 180) * degrees;
                return (radians);
            }
           
            //Finding the side "Opposite"
            public static double Sin_The_hypo(double theta, double hypo)
            {
                double opp = Math.Sin(theta) * hypo;
                return opp;
            }
            public static double Cos_The_hypo(double theta, double adj)
            {
                double opp = adj / Math.Cos(theta);
                return opp;
            }
            public static double Tan_The_hypo(double theta, double hypo)
            {
                double opp = Math.Tan(theta) * hypo;
                return opp;
            }
            //Finding the side "Adjacent"
            public static double Tan_The_opp(double theta, double opp)
            {
                double adj = opp / Math.Tan(theta);
                return adj;
            }
            public static double Sin_The_opp(double theta, double opp)
            {
                double adj = opp / Math.Sin(theta);
                return adj;
            }
            public static double Cos_Theta_hypo(double theta, double hypo)
            {
                double adj = Math.Cos(theta) * hypo;
                return adj;
            }
            //Finding the "Hypotenuse"
            public static double Sin_Theta_opp(double theta, double opp)
            {
                double hypo = opp / Math.Sin(theta);
                return hypo;
            }
            public static double Cos_The_adj(double theta, double adj)
            {
                double hypo = adj / Math.Cos(theta);
                return hypo;
            }
            
            //Finding the Tangent
            public static double Opp_The_Adj(double opp, double adj)
            {
                double theta = Math.Atan(opp / adj);
                return theta;
            }
         
            /*
                This class DOES NOT have any Properties or Constructors!
            */
            #region Class Variabbles
            private static double pi = Math.PI;
        #endregion

        #region Methods for later use (reserved for Lab 3)
        
        #endregion

        #region General Math
        // Complete the following methods
        //1.a - A method to convert degrees to radians
        public static double ToRadians(double degrees)
        {
            return 0;
        }//eom

        //1.b - A method to convert radians to degrees
        public static double ToDegrees(double radians)
        {
            return 0;
        }//eom
        #endregion

        #region Solve Right Triangles
        // Complete the following methods
        //1.c - A method to solve a right triangle given an angle in degrees and the hypotenuse;
	//      returns a Tuple<double, double> for the missing sides (adjacent, opposite).
        public static Tuple<double,double> CalculateAdjacentOpposite(double theta, double hypotenuse)
        {
            return new Tuple<double, double>(0, 0);
        }//eom
        
        //1.d – A method to solve a right triangle given an angle in degrees and the side opposite;
	//      returns a Tuple<double, double> for the missing sides (adjacent, hypotenuse).
         public static Tuple<double, double> CalculateAdjacentHypotenuse(double theta, double opposite)
        {
            return new Tuple<double, double>(0, 0);
        }//eom

        //1.e – A method to solve a right triangle given an angle in degrees and the side adjacent;
	//      returns a Tuple<double, double> for the missing sides (opposite, hypotenuse).
        public static Tuple<double, double> CalculateOppositeHypotenuse(double theta, double adjacent)
        {
            return new Tuple<double, double>(0, 0);
        }//eom

        //1.f – A method to solve a right triangle given side opposite and side adjacent;
	//      returns a Tuple<double, double> for the missing side and the angle in degrees.
        public static Tuple<double, double> CalculateHypotenuseTheta(double opposite, double adjacent)
        {
            return new Tuple<double, double>(0, 0);
        }//eom

        //1.g – A method to solve a right triangle given side opposite and hypotenuse;
	//      returns a Tuple<double, double> for the missing side and the angle in degrees.
        public static Tuple<double, double> CalculateAdjacentTheta(double opposite, double hypotenuse)
        {
            return new Tuple<double, double>(0, 0);
        }//eom

        //1.h – A method to solve a right triangle given side adjacent and hypotenuse;
	//      returns a Tuple<double, double> for the missing side and the angle in degrees.
        public static Tuple<double, double> CalculateOppositeTheta(double adjacent, double hypotenuse)
        {
            return new Tuple<double, double>(0, 0);
        }//eom
        #endregion

        #region More math functions (reserved for Lab 4)

        #endregion
    }//eoc
}//eon
