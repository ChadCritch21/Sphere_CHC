/**
* This class models a sphere object
* @author Chad Critchelow
* @version 1.0
* Program Project 1 Sphere_CHC
* SP20
*/
using System;

namespace SphereConsoleApp
{
    class Program
    {
        static void Main(string[] args)//Main method to test the sphere class
        {
            Sphere sphere = new Sphere();//creating a new object of the sphere class

            sphere.setDiameter(12.5);//setting the diameter of my new sphere object

            Console.WriteLine("This sphere has a measured diameter of " + sphere.getDiameter() + " inches.");//returning measurements and caluclations to better test the sphere class.
            Console.WriteLine("The calculated surface area of this sphere is " + Math.Round(sphere.getSurfaceArea(), 2) + " square inches.");
            Console.WriteLine("The calulated volume of this sphere is " + Math.Round(sphere.getVolume(), 2) + " cubic inches.");
            Console.WriteLine("The shape will formally be saved in the Math database as : " + sphere.ToString() + " where the diameter is measured in inches.");
        }
    }
}
