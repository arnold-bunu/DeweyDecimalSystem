using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalSystem
{
     public class numbers
    {
        public static int subjectNo;
        public static int subSubjectNo;
        public static string authorInitials;
        public static List<String> callNum = new List<String>();
        public static List<String> sortedCallNum = new List<String>();
        public static Random rand = new Random();
        public static String finalDewey;

        //*********************************************************GENERATE CALL NUMBER METHOD - USED TO RANDOMLY GENERATE 10 CALL NUMBERS****************************************************************************************************
        public static void generateCallNumber()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[3];
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                subjectNo = rand.Next(100, 999);   // GENERATES 3 RANDOM DIGITS 
                subSubjectNo = rand.Next(10, 99); // GENERATES 2 RANDOM DIGITS

                for (int k = 0; k < 3; k++)
                {
                    stringChars[k] = chars[random.Next(chars.Length)];  //GENERATES 3 RANDOM LETTERS

                }
                var myRandomUpperCase = new String(stringChars);
                finalDewey = subjectNo + "." + subSubjectNo + "  " + myRandomUpperCase;  // CONCATENATING MY DEWY DECIMAL 
                callNum.Add(finalDewey);        // ADDING CALL NUMBERS TO A LIST


            }
        }

        //*********************************************************QUICK SORT METHOD USED TO SORT THE LIST****************************************************************************************************
        //
        public static void sortCall(List<String> arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    sortCall(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    sortCall(arr, pivot + 1, right);
                }
            }
        }

        public static int Partition(List<String> arr, int start, int end)
        {
            int pivot = end;
            int i = start, j = end;
            string temp;
            while (i < j)
            {
                while (i < end && string.Compare(arr[i], arr[pivot]) < 0)
                    i++;
                while (j > start && string.Compare(arr[j], arr[pivot]) > 0)
                    j--;

                if (i < j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            temp = arr[pivot];
            arr[pivot] = arr[j];
            arr[j] = temp;
            return j;
        }
    }
}
