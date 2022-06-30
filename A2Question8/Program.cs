using System;

namespace A2Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //original array elements are printed
            Console.WriteLine("The Elements of the original array are: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            //new array elements  
            int[] newArray = Test(myArray); //function called and myArray is input. Result is newArray

            //print newArray
            Console.WriteLine("\n\nArray after cumulatively adding elements: ");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }

        }


        //this function cumulatively adds numbers, returns array.
        static int[] Test(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                //current index is equal to current + last
                nums[i] = nums[i] + nums[i - 1];
            }
            //an array is returned from this as our input is also an array
            return nums;
        }
    }
}
