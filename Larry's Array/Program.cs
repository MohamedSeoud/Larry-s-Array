using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the larrysArray function below.
    static string larrysArray(int[] A)
    {
        string ret = "NO";
        int nonstoredElements = 0;
        for (int i = 0; i < A.Length; i++) 
        {
            if (A[i] != i + 1)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] == i + 1) { break; }
                    if (A[j] == i + 1)
                    {
                        if (j - i >= 2)
                        {
                            int temp = A[j - 2];
                            A[j - 2] = A[j];
                            A[j] = temp;
                            int temp2 = A[j];
                            A[j] = A[j - 1];
                            A[j - 1] = temp2;
                            j = i;
                        }
                        else 
                        {
                            if (j + 1 < A.Length)
                            {
                                int temp = A[j - 1];
                                A[j - 1] = A[j];
                                A[j] = temp;
                                int temp2 = A[j + 1];
                                A[j + 1] = A[j];
                                A[j] = temp2;
                                break;
                            }
                        }
                    }
                }
            }
        }
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] != i + 1)
            { nonstoredElements++; break; }
        }
        if (nonstoredElements == 0) { ret = "YES"; }
        return ret;
    }

    static void Main(string[] args)
    {
      //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp))
            ;
            string result = larrysArray(A);

     //       textWriter.WriteLine(result);
        }

       // textWriter.Flush();
    //    textWriter.Close();
    }
}
