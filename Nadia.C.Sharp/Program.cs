﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Jint;
using Nadia.C.Sharp.FactValueFolder;
using Nadia.C.Sharp.NodeFolder;
using Nadia.C.Sharp.RuleParserFolder;

namespace Nadia.C.Sharp
{
    class Test1
    {
        static void Main(string[] args)
        {
            //string datePattern = @"([0-2]?[0-9]|3[0-1])/(0?[0-9]|1[0-2])/([0-9][0-9])?[0-9][0-9]|([0-9][0-9])?[0-9][0-9]/(0?[0-9]|1[0-2])/([0-2]?[0-9]|3[0-1])";
            //string equationInString = "12/12/2018 - 11/11/2017";

            //MatchCollection dateMatcher = Regex.Matches(equationInString, datePattern);
            //List<DateTime> dateTimeList = new List<DateTime>();
            //if (dateMatcher.Count > 0)
            //{
            //    foreach (Match match in dateMatcher)
            //    {
            //        Console.WriteLine(match.Value);
            //    }

            //}

            //Jint.Engine scriptEngine = new Jint.Engine();
            //Console.WriteLine("this: "+ scriptEngine.Execute("\'this is good\'>= \'what is this\'").GetCompletionValue());
            //TestClass.Testing_for_ALL_Node_Lines_and_features_10();

            //TestClass.Testing_Whole_Features_Of_ValueConclusionLine_ComparisonLine_and_ExprConclusionLine_9();

            //TestClass.Testing_Whole_Features_Of_ValueConclusionLIne_and_ComparisonLine_8();
            //TestClass.Tesing_Full_ValueConclusion_Comparison_7();
            //TestClass.Testing_ValueConclusionLine_6();
            //TestClass.Testing_Inference_For_NotKnownManOpPo_5();
            //TestClass.Testing_For_Reading_NotKnownMandatoryPossiblyAndOptionally_4();
            TestClass.WeddingPlanner_Inference_Test_3();
            //TestClass.TopoSortingTest_2();

            String parentText = "FIXED a name of the first person IS \"John Smith\"";
            //parentText = "FIXED the first integer AS NUMBER IS 34";
            //parentText = "FIXED premium account type AS LIST";
            Regex regex = new Regex("^(FIXED)(.*)((AS|IS)\\s+.*)");
            
            Match match = regex.Match(parentText); ;

            

            if (match.Success)
            {
                String variableName = match.Groups[2].ToString().Trim();
                Console.WriteLine(variableName);
            }
                    //TestClass.Testing();
        }
    }
}
