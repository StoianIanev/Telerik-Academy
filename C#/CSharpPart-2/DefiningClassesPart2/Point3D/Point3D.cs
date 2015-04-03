using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace Point3D
{
    public class Point3D
    {
        // Task 1- Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.

        public struct strPoint3D
        {
            private double pointX;
            private double pointY;
            private double pointZ;

            public strPoint3D(double pointX,double pointY,double pointZ)
            {
                this.pointX=pointX;
                this.pointY=pointY;
                this.pointZ=pointZ;
            }

            public double PointX
            {
                get { return this.pointX; }
                set { this.pointX = value; }
            }
            public double PointY
            {
                get { return this.pointY; }
                set { this.pointY = value; }
            }
            public double PointZ
            {
                get { return this.pointZ; }
                set { this.pointZ = value; }
            }

            // Task 2- Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.

           static readonly strPoint3D pointO = new strPoint3D(0,0,0);

            public strPoint3D PointO
            {
                get { return pointO; }
            }
            
            public override string ToString()
            {
                return string.Format("Point x = {0}, Point y = {1}, Point z = {2}", pointX, pointY, pointZ);
            }


            // Task 3- Write a static class with a static method to calculate the distance between two points in the 3D space.

           public static class CalculateDistance
           {
                public static double DistanceBetweenTwoPoints(strPoint3D point1 , strPoint3D point2)
                {
                    double distance = 0;
                    distance = point1.pointX - point2.pointX;

                    distance += point1.pointY - point2.pointY;
                    distance += point1.pointZ - point2.pointZ;

                    distance = Math.Sqrt(distance);

                    return distance;
           
                }
            }

           // Task 4-  Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

            public static class Path
            {
                List<Point3D> points = new List<Point3D>();

            }

            public static class PathStorage
            {
                public static void SavePath(string fileName)
                {
                    try
                    {
                        StreamWriter writer = new StreamWriter(fileName);

                        using (writer)
                        {
                            
                        }
                    }
                    catch (FileNotFoundException)
                    {

                        Console.WriteLine("Can not find file: {0}",fileName);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Console.WriteLine("Invalid directory in the file path!");
                    }
                    catch(IOException)
                    {
                        Console.WriteLine("Can not open the file: {0}",fileName);
                    }
                }
                public static void LoadPath(string fileName)
                {
                    try
                    {
                        StreamReader reader = new StreamReader(fileName);
                        using (reader)
                        {
                            Console.WriteLine(reader.ReadToEnd());
                        }

                    }
                    catch (FileNotFoundException)
                    {

                        Console.WriteLine("Can not find file: {0}", fileName);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Console.WriteLine("Invalid directory in the file path!");
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Can not open the file: {0}", fileName);
                    }
                }

            }

        }

        
    }
    

}
