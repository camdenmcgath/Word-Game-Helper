using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//contains functions for permutates, calculate button, show all combos checkbox
namespace WordHelper
{
    public partial class frmMain : Form
    {
        private static List<string> GetCharacterPermutations(List<string> masterList, char[] list, int k, int m)
        {
            //we've reached the end of our recursion, and have our permutation
            if (k == m)
            {
                //take each substring of 1, 2, ... up to N characters
                //if the substring is not already in our master list, we'll add it
                try
                {
                    string splicingStr = string.Join("", list.ToArray());
                    for (int i = 0; i < splicingStr.Length; i++)
                    {
                        if (!masterList.Contains(splicingStr.Substring(0, i + 1)))
                        {
                            Log.Information(splicingStr.Substring(0, i + 1));
                            masterList.Add(splicingStr.Substring(0, i + 1));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.Information(ex.Message, "Thrown in GetCharacterPermutations.");
                    MessageBox.Show(ex.Message);
                    return masterList;
                }
            }
            else
            {
                try
                {
                    for (int i = k; i <= m; i++)
                    {
                        //swap to change the permutation being chacked
                        Swap(ref list[k], ref list[i]);
                        GetCharacterPermutations(masterList, list, k + 1, m);
                        Swap(ref list[k], ref list[i]);
                    }
                }
                catch (Exception ex)
                {
                    Log.Information(ex.Message, "Thrown in GetCharacterPermutations.");
                    MessageBox.Show(ex.Message);
                    return masterList;
                }
            }
            return masterList; // this is our final list
        }
        public static List<string> GetArrayPermutations(char[] list)
        {
            Log.Information("Array permutations:");

            List<string> masterList = new List<string>();
            int listLength = list.Length - 1;
            masterList = GetCharacterPermutations(masterList, list, 0, listLength);
            return masterList;
        }
        //overload to pass a string instead of an array if so prefferred
        public static List<string> GetArrayPermutations(string listStr)
        {
            char[] list = listStr.ToCharArray();
            return GetArrayPermutations(list);
        }
        private static void Swap(ref char a, ref char b)
        {
            // this is a fast swap using bitwise operators
            if (a == b) return;
            // this is kind of sneaky
            // we calculate the XOR between the two numbers, store in a
            a ^= b;
            // then apply that XOR to b generate the original number a, b is now a
            b ^= a;
            // then apply that XOR to a to generate the original number b, a is now b
            a ^= b;
        }
    }
}
