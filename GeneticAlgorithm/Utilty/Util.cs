using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Util
    {
        public bool[] joinArrays(bool[] arr1, bool[] arr2)
        {
            bool[] joinedArray = new bool[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                joinedArray[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                joinedArray[arr1.Length + i] = arr2[i];
            }
            return joinedArray;
        }
        public (bool[] arr1, bool[] arr2) seperateArrays(bool[] arr, int arr1Length, int arr2Length)
        {
            bool[] arr1 = new bool[arr1Length];
            bool[] arr2 = new bool[arr2Length];

            for(int i = 0; i< arr1Length; i++)
            {
                arr1[i] = arr[i];
            }
            for(int i = arr1Length; i < arr1Length + arr2Length; i++)
            {
                arr2[i - arr1Length] = arr[i];
            }

            return (arr1, arr2);
        }
    }
}