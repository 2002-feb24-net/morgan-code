using System;

namespace MultiArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // you can make an array that would contain any type
            // you can make an array of arrays

            // for example, for two dimensional image data
            //this is an "array of array" sometimes called jagged array
            string[][] image = new string[4][];
            image[0] = new string[] {"black", "black", "black", "black"};
            image[1] = new string[] {"black", "red", "red", "black"};
            image[2] = new string[] {"black", "red", "red", "black"};
            image[3] = new string[] {"black", "black", "black", "black"};
            string topRightCorner = image[0][3]; // the fourth item in the first array

                        
                        
                        
            //this is something different, it does enforce "rectangular" multi-dimensional arrays           
            string[,] image2 = new string[4, 3]
            {
                {"black", "black", "black"},
                {"black", "red", "red"},
                {"black", "red", "red"},
                {"black", "black", "black"}
            };
            string topRightCorner2 = image[0][3]; // the fourth item in the first array
        }
    }
}
