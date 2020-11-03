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

class Solution {

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note) {
        
        List<string> manipulatedMagazine = new List<string>();
        
        foreach (string word in magazine) {
            manipulatedMagazine.Add(word);
            //Console.WriteLine("HAS : " + word);
        }
        
        bool hasAllWords = true;
        
        foreach (string word in note) {
            //Console.WriteLine("CHECKS:    " +  word);
            if (manipulatedMagazine.Contains(word)) {
                    manipulatedMagazine.Remove(word);
                    //Console.WriteLine("\tREMOVED: " + word);
            }
            else {
                hasAllWords = false;
            }
        }
        if (hasAllWords == true) {
              Console.WriteLine("Yes"); 
        }
              
        else { 
            Console.WriteLine("No");
        }   

    }

    static void Main(string[] args) {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
