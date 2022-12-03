using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalSystem
{
    internal class FindingCallClass
    {
       
        public static int current;
        public static int tier1;
        public static int tier2;
        public static int tier3;
        public static int scoreTrack;
    
        public static List<int> possibleAns = new List<int>();

        public static string? answerCall;
        public static string? answerDesc;
        public static Random random = new Random();
        static Node root;

        /// <summary>
        /// Generating questions for the labels
        /// </summary>
        /// <returns></returns>
        public static string lblQuestion()
        {

            possibleAns.Clear();

            while (possibleAns.Count < 4)
            {
                int rand = random.Next(0, 10);
                if (!possibleAns.Contains(rand))
                {
                    possibleAns.Add(rand);
                }
            }
            possibleAns.Sort();



            int ran = random.Next(0, 4);
            tier1 = possibleAns[ran];
            tier2 = random.Next(0, 4);
            tier3 = random.Next(0, 4);

           ///  answerCall = "110"; // 110:Metaphysics
            //answerCall = "Metaphysics";

           answerCall = root.Child[tier1].Child[tier2].Child[tier3].callNumbers;
           answerDesc = root.Child[tier1].Child[tier2].Child[tier3].callNUmDef;

            return answerDesc;
        }
        /// <summary>
        /// Generates answers for the buttons
        /// </summary>
        /// <returns></returns>
        public static List<string> Questions()
        {
            List<string> questions = new List<string>();



            if (current == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    questions.Add(root.Child[possibleAns[i]].callNumbers + " " + root.Child[possibleAns[i]].callNUmDef);
                }
            }
            else if (current == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    questions.Add(root.Child[tier1].Child[i].callNumbers + " " + root.Child[tier1].Child[i].callNUmDef);
                }
            }
            else if (current == 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    questions.Add(root.Child[tier1].Child[tier2].Child[i].callNumbers + " " + root.Child[tier1].Child[tier2].Child[i].callNUmDef);
                }
            }

            return questions;
        }
        /// <summary>
        /// Method to populate the tree
        /// </summary>
        public static void PopulateTree()
        {
            current = 0;
            root = AddNode("Root", "Node");

           
            string filePath = Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory)).FullName).FullName + @"\Numbers\callNum2.txt";


           
            // string[] lines = File.ReadAllLines(filePath);
            string[] lines = File.ReadAllLines(filePath);

            int lineCount = 0;

            
            for (int i = 0; i < 10; i++)
            {
                string[] tier1 = lines[lineCount++].Split(':');
                root.Child.Add(AddNode(tier1[0], tier1[1]));

                for (int j = 0; j < 4; j++)
                {
                    string[] tier2 = lines[lineCount++].Split(':');
                    root.Child[i].Child.Add(AddNode(tier2[0], tier2[1]));
                    for (int k = 0; k < 4; k++)
                    {
                        string[] tier3 = lines[lineCount++].Split(':');
                        root.Child[i].Child[j].Child.Add(AddNode(tier3[0], tier3[1]));
                    }
                }
            }

        }
        /// <summary>
        /// Method to keep track of scores 
        /// </summary>
        //public void showScores()
        //{
        //    if (scoreTrack == 0)
        //    {
        //        lblScore.Visible = true;
                
        //    }
        //    else if (scoreTrack == 1)
        //    {
        //        MessageBox.Show("You got 1 out 3 correct!");
        //    }
        //    else if (scoreTrack == 2)
        //    {
        //        MessageBox.Show("You got 1 out 3 correct!");
        //    }
        //    else if (FindingCallClass.scoreTrack == 3)
        //    {
        //        MessageBox.Show("All correct! what a star!");
        //    }
        //}


        /// <summary>
        /// Button tocheck the answers
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        public static bool Check(string choice)
        {
            
            if (current == 0)
            {
                current++;
                if (choice.Equals(root.Child[tier1].callNumbers + " " + root.Child[tier1].callNUmDef))
                { 
                    scoreTrack++;
                    return true; }
            }
            else if (current == 1)
            {
                current++;
                if (choice.Equals(root.Child[tier1].Child[tier2].callNumbers + " " + root.Child[tier1].Child[tier2].callNUmDef))
                {
                    scoreTrack++;
                    return true; }
            }
            else if (current == 2)
            {
                current++;
                if (choice.Equals(root.Child[tier1].Child[tier2].Child[tier3].callNumbers + " " + root.Child[tier1].Child[tier2].Child[tier3].callNUmDef))
                {
                    scoreTrack++;
                    return true; }

            } else
            {
                  current = 0;
            }
            return false;


        }
        /// <summary>
        /// Node class 
        /// </summary>
        public class Node
        {
            public string callNumbers;
            public string callNUmDef;

            public List<Node> Child = new List<Node>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CallNumber"></param>
        /// <param name="Definition"></param>
        /// <returns></returns>
        public static Node AddNode(string CallNumber, string Definition)
        {
            Node TempNode = new Node();
            TempNode.callNumbers = CallNumber;
            TempNode.callNUmDef = Definition;

            return TempNode;
        }

    }




}
