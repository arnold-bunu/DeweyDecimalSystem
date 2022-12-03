using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalSystem.Forms
{
    public partial class IdentifyAreas : Form
    {
        public int flip;
        public int subjectNo;
        public int subSubjectNo;
        public string authorInitials;
        public Random rand = new Random();
        public String finalDewey;
        public List<String> callNum = new List<String>();
        public List<String> callNumDesc = new List<String>();
        public String answerChosen;
        public String answerOne, answerTwo, answerThree, answerFour;
        public String values1, values2, values3, values4;
        public int score;
        String[] answers = new string[4];
        public bool flipflop = false;

 


        public IdentifyAreas()
        {
            InitializeComponent();
            star1.Visible = false;
            star2.Visible = false;  //HIDES THE STARS
            star3.Visible = false;
            star4.Visible = false;
            // lblScore.Visible = false;
            start();
        }


        /// <summary>
        /// start game method
        /// </summary>
        public void start()
        {
            star1.Visible = false;
            star2.Visible = false;  //HIDES THE STARS
            star3.Visible = false;
            star4.Visible = false;
            lblScore.Visible = false;

            Random rand = new Random();
            for (int j = 0; j < 1; j++)
            {
                flip = rand.Next(2);
            }
            if (flip == 1)
            {

                for (int i = 0; i < 7; i++)
                {
                    callNum.Add(DeweyDefs.ElementAt(i).Key);  // ADDING THE CALL NUMBERS ALONG WITH THEIR DECRIPTIONS
                    callNumDesc.Add(DeweyDefs.ElementAt(i).Value);

                }

                callNum = Shuffle(callNum);
                callNumDesc = Shuffle(callNumDesc);             // SHUFFLING CALL NUMBERS SO THEY ARE NOT IN ORDER

                List<String> numGen = callNum.Distinct().ToList();
                List<String> strGen = callNumDesc.Distinct().ToList();        // ADDING TO CALL NUMBERS AND DEFINITIONS TO A LIST

                rndOne.Text = numGen[0];
                rndTwo.Text = numGen[1];
                rndThree.Text = numGen[2];
                rndFour.Text = numGen[3];


                defONE.Text = strGen[0];
                defTWO.Text = strGen[1];
                defTHREE.Text = strGen[2];
                defFOUR.Text = strGen[3];
                defFIVE.Text = strGen[4];
                defSIX.Text = strGen[5];
                defSEVEN.Text = strGen[6];
            } else
            {
                for (int i = 0; i < 7; i++)
                {
                    callNum.Add(DeweyDefs.ElementAt(i).Key);  // ADDING THE CALL NUMBERS ALONG WITH THEIR DECRIPTIONS
                    callNumDesc.Add(DeweyDefs.ElementAt(i).Value);

                }

                callNum = Shuffle(callNum);
                callNumDesc = Shuffle(callNumDesc);             // SHUFFLING CALL NUMBERS SO THEY ARE NOT IN ORDER

                List<String> numGen = callNum.Distinct().ToList();
                List<String> strGen = callNumDesc.Distinct().ToList();        // ADDING TO CALL NUMBERS AND DEFINITIONS TO A LIST

                rndOne.Text = strGen[0];
                rndTwo.Text = strGen[1];
                rndThree.Text = strGen[2];
                rndFour.Text = strGen[3];


                defONE.Text = numGen[0];
                defTWO.Text = numGen[1];
                defTHREE.Text = numGen[2];
                defFOUR.Text = numGen[3];
                defFIVE.Text = numGen[4];
                defSIX.Text = numGen[5];
                defSEVEN.Text = numGen[6];
            }
        }

        /// <summary>
        /// Dictionary 
        /// </summary>
        public Dictionary<String, String> DeweyDefs = new Dictionary<String, String>() {

            { "000", "Computer Science, Information, & General Works." },
             {"100", "Philosophy & Psychology."},
            { "200", "Religion."},
            {"300", "Social Sciences."},
            { "400", "Language."},
            { "500", "Science."},
            { "600", "Technology."},
            { "700", "Arts & Recreation."},
           { "800", "Literature."},
            { "900", "History & Geography."}

            };

       /// <summary>
       /// Shuffle the call numbers and descriptions
       /// </summary>
       /// <typeparam name="T"></typeparam>
       /// <param name="list"></param>
       /// <returns></returns>
        public static List<T> Shuffle<T>(List<T> list)
        {
            Random random = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                int k = random.Next(0, i);
                T value = list[k];
                list[k] = list[i];
                list[i] = value;
            }
            return list;
        }
        private void rndOne_Click(object sender, EventArgs e)
        {
            answerChosen = "ONE";
         //   MessageBox.Show("answe is " + answerChosen);
        }

        private void rndTwo_Click(object sender, EventArgs e)
        {
            answerChosen = "TWO";
        }

        private void rndThree_Click(object sender, EventArgs e)
        {
            answerChosen = "THREE";
        }

        private void rndFour_Click(object sender, EventArgs e)
        {
            answerChosen = "FOUR";
        }

        //===============================================================================================================================================
        private void defONE_Click(object sender, EventArgs e)
        {
            if (answerChosen != null)
            {
                ans1.Text = answerChosen;
            }

        }

        private void defTWO_Click(object sender, EventArgs e)
        {
            if (answerChosen != null)
            {
                ans2.Text = answerChosen;
            }
        }
        private void defTHREE_Click(object sender, EventArgs e)
        {
            if (answerChosen != null)
            {
                ans3.Text = answerChosen;
            }
        }

        private void defFOUR_Click(object sender, EventArgs e)
        {
            if (answerChosen != null)
            {
                ans4.Text = answerChosen;
            }
        }

        private void defFIVE_Click(object sender, EventArgs e)
        {
            if (answerChosen != null)
            {
                ans5.Text = answerChosen;
            }
        }

        private void defSIX_Click(object sender, EventArgs e)
        {
            if (answerChosen != null)
            {
                ans6.Text = answerChosen;
            }
        }

        private void defSEVEN_Click(object sender, EventArgs e)
        {
            if (answerChosen != null)
            {
                ans7.Text = answerChosen;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            start();
        }

        /// <summary>
        /// Submit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                btnCheck.Visible = false;
                int score = 0;
                if (flip == 1)
                {
                    String[] answersNames = { ans1.Text, ans2.Text, ans3.Text, ans4.Text, ans5.Text, ans6.Text, ans7.Text };
                    String[] answersVals = { defONE.Text, defTWO.Text, defTHREE.Text, defFOUR.Text, defFIVE.Text, defSIX.Text, defSEVEN.Text };
                    String[] vals = { "ONE", "TWO", "THREE", "FOUR" };


                    for (int i = 0; i < 7; i++)
                    {
                        if (answersNames[i] != null)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (answersNames[i] == vals[j])
                                {
                                    answers[j] = answersVals[i];   // LOOPING AND EQUATING ANSWERS TO VARIABLES
                                }
                            }
                        }
                    }

                    values1 = DeweyDefs[rndOne.Text];
                    values2 = DeweyDefs[rndTwo.Text];
                    values3 = DeweyDefs[rndThree.Text];     // ASSIGNING THE VARIABLES
                    values4 = DeweyDefs[rndFour.Text];

                    if (values1 == answers[0])
                    {
                        score = 100;
                        rndOne.BackColor = Color.Green;
                    }
                    else
                    {
                        rndOne.BackColor = Color.Red;
                    }

                    if (values2 == answers[1])
                    {
                        score = 200;
                        rndTwo.BackColor = Color.Green;
                    }
                    else
                    {
                        rndTwo.BackColor = Color.Red;
                    }

                    if (values3 == answers[2])
                    {
                        score = 300;
                        rndThree.BackColor = Color.Green;
                    }
                    else
                    {
                        rndThree.BackColor = Color.Red;
                    }
                    if (values4 == answers[3])
                    {
                        score = 400;
                        rndFour.BackColor = Color.Green;
                    }
                    else
                    {
                        rndFour.BackColor = Color.Red;
                    }
                }
                else   // ELSE STATEMENT TO CHECK THE FLIPPED START BUT IS NOT IN USE AS IT WAS CRASHING
                {
                    String[] answersNames = { ans1.Text, ans2.Text, ans3.Text, ans4.Text, ans5.Text, ans6.Text, ans7.Text };
                    String[] answersVals = { defONE.Text, defTWO.Text, defTHREE.Text, defFOUR.Text, defFIVE.Text, defSIX.Text, defSEVEN.Text };
                    String[] vals = { "ONE", "TWO", "THREE", "FOUR" };


                    for (int i = 0; i < 7; i++)
                    {
                        if (answersNames[i] != null)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (answersNames[i] == vals[j])
                                {
                                    answers[j] = answersVals[i];
                                }
                            }
                        }
                    }

                    values1 = extend.KeyByValue(DeweyDefs, rndOne.Text);
                    values2 = extend.KeyByValue(DeweyDefs, rndTwo.Text);
                    values3 = extend.KeyByValue(DeweyDefs, rndThree.Text);
                    values4 = extend.KeyByValue(DeweyDefs, rndFour.Text);

                    if (values1 == answers[0])
                    {
                        score = 100;
                        rndOne.BackColor = Color.Green;
                    }
                    else
                    {
                        rndOne.BackColor = Color.Red;
                    }
                    if (values2 == answers[1])
                    {
                        score = 200;
                        rndTwo.BackColor = Color.Green;
                    }
                    else
                    {
                        rndTwo.BackColor = Color.Red;
                    }
                    if (values3 == answers[2])
                    {
                        score = 300;
                        rndThree.BackColor = Color.Green;
                    }
                    else
                    {
                        rndThree.BackColor = Color.Red;
                    }
                    if (values4 == answers[3])
                    {
                        score = 400;
                        rndFour.BackColor = Color.Green;
                    }
                    else
                    {
                        rndFour.BackColor = Color.Red;
                    }
                }


                switch (score)    // KEEPS TRACK OF THE SCORE AS WELL AS THE AMOUNT OF STARS TO GIVE
                {
                    case 100:
                        star1.Visible = true;
                        lblScore.Visible = true;
                        lblScore.Text = "Score is " + score + ",Try harder";
                        break;

                    case 200:
                        star1.Visible = true;
                        star2.Visible = true;
                        lblScore.Visible = true;
                        lblScore.Text = "Score is " + score + ",Try harder";
                        break;
                    case 300:
                        star1.Visible = true;
                        star2.Visible = true;
                        star3.Visible = true;
                        lblScore.Visible = true;
                        lblScore.Text = "Score is " + score + ",Getting there";
                        break;
                    case 400:
                        star1.Visible = true;
                        star2.Visible = true;
                        star3.Visible = true;
                        star4.Visible = true;
                        lblScore.Visible = true;
                        lblScore.Text = "Score is " + score + ",Well done! All right";
                        break;
                }

            }
            catch
            {
                MessageBox.Show("Please choose one answer");
            }
        }


        /// <summary>
        /// Retry button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetry_Click(object sender, EventArgs e)
        {
            rndOne.BackColor = Color.Blue;
            rndTwo.BackColor = Color.Blue;
            rndThree.BackColor = Color.Blue;
            rndFour.BackColor = Color.Blue;
            ans1.Text = "";
            ans2.Text = "";
            ans3.Text = "";
            ans4.Text = "";
            ans5.Text = "";
            ans6.Text = "";
            ans7.Text = "";
            start();
        }

      



    }
}

public static class extend
{

    public static T KeyByValue<T, W>(this Dictionary<T, W> DeweyDedc, W val)
    {
        T key = default;
        foreach (KeyValuePair<T, W> pair in DeweyDedc)
        {
            if (EqualityComparer<W>.Default.Equals(pair.Value, val))
            {
                key = pair.Key;
                break;
            }
        }

        return key;
    }

}
