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
    public partial class ReplaceBooks : Form
    {
        //public int subjectNo;
        //public int subSubjectNo;
        //public string authorInitials;
        //public List<String> callNum = new List<String>();
        //public List<String> sortedCallNum = new List<String>();
        //public Random rand = new Random();
        //public String finalDewey;

        public ReplaceBooks()
        {
            InitializeComponent();
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;
            star5.Visible = false;
            lbxCorrect.Visible = false;
            starCount.Visible = false;
            lblshowScore.Visible = false;

        }

        private void lblshowScore_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Button to generate numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnGenerate_Click(object sender, EventArgs e)
        {
            lbxRanGenCallNum.Items.Clear();
            for (int b = 0; b < 10; b++)
            {
                numbers.generateCallNumber();

                lbxRanGenCallNum.Items.Add(numbers.callNum[b]); // ADDS CALL NUMBERS TO THE LISTBOX
            }
        }
        /// <summary>
        /// Move numbers up or down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbUpbtn_Click(object sender, EventArgs e)
        {
            if (lbxRanGenCallNum.SelectedIndex == -1)
            {
                MessageBox.Show("No call number has been selected, please select one to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // ERROR MESSAGE TO BE SHOWN IF NO CALL NUMBER IS GENERATED
            }
            else
            {
                int newIndex = lbxRanGenCallNum.SelectedIndex - 1;

                if (newIndex < 0)
                    return;
                object selectedItem = lbxRanGenCallNum.SelectedItem;

                lbxRanGenCallNum.Items.Remove(selectedItem);
                lbxRanGenCallNum.Items.Insert(newIndex, selectedItem);
                lbxRanGenCallNum.SetSelected(newIndex, true);
            }
        }

        /// <summary>
        /// Button to move numbers down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbDownbtn_Click(object sender, EventArgs e)
        {
            if (lbxRanGenCallNum.SelectedIndex == -1)
            {
                MessageBox.Show("No call number has been selected, please select one to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // ERROR MESSAGE TO BE SHOWN IF NOTHING IS SELECTED 
            }
            else
            {
                int newIndex = lbxRanGenCallNum.SelectedIndex + 1;

                if (newIndex >= lbxRanGenCallNum.Items.Count)
                    return;
                object selectedItem = lbxRanGenCallNum.SelectedItem;

                lbxRanGenCallNum.Items.Remove(selectedItem);
                lbxRanGenCallNum.Items.Insert(newIndex, selectedItem);
                lbxRanGenCallNum.SetSelected(newIndex, true);
            }
        }

        /// <summary>
        /// Done button to submit 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                lbxCorrect.Visible = true;
                int points = 0;
                btnGenerate.Visible = false;

                numbers.sortCall(numbers.callNum, 0, 9);   // SORTING THE CALL NUMBERS 
                lbxCorrect.Items.Clear();

                for (int i = 0; i < 10; i++)
                {
                    lbxCorrect.Items.Add(numbers.callNum[i]).ToString();  // ADDING THE CORRECT CALL NUMBERS TO A LIST BOX
                }
                for (int j = 0; j < 10; j++)
                {
                    if (lbxRanGenCallNum.Items[j].ToString() == lbxCorrect.Items[j].ToString())   // COMPARES THE TWO LIST BOXES 
                    {
                        points++;
                    }
                    String showScore = "you got " + points + " correct!";
                    lblshowScore.Text = showScore;
                    lblshowScore.Visible = true;
                }
                // THE NEXT NESTED IF OUPUTS USER SCORES AND STARS 
                if (points > 0 && points <= 2)
                {
                    starCount.Visible = true;
                    String oneStar = "You scored 1 out of 5 stars, keep pushing!";
                    star1.Visible = true;
                    starCount.Text = oneStar;
                }
                else if (points > 2 && points <= 4)
                {
                    starCount.Visible = true;
                    String twoStar = "You scored 2 out of 5 stars, keep pushing!";
                    star1.Visible = true;
                    star2.Visible = true;
                    starCount.Text = twoStar;
                }
                else if (points > 4 && points <= 6)
                {
                    starCount.Visible = true;
                    String threeStar = "You scored 3 out of 5 stars, getting there!";
                    star1.Visible = true;
                    star2.Visible = true;
                    star3.Visible = true;
                    starCount.Text = threeStar;
                }
                else if (points > 6 && points <= 8)
                {
                    starCount.Visible = true;
                    String fourStar = "You scored 4 out of 5 stars, almost perfect!";
                    star1.Visible = true;
                    star2.Visible = true;
                    star3.Visible = true;
                    star4.Visible = true;
                    starCount.Text = fourStar;
                }
                else if (points > 8 && points <= 10)
                {
                    starCount.Visible = true;
                    String fiveStar = "You scored 5 out of 5 stars, well done!";
                    star1.Visible = true;
                    star2.Visible = true;
                    star3.Visible = true;
                    star4.Visible = true;
                    star5.Visible = true;
                    starCount.Text = fiveStar;
                }
            }

            catch
            {
                MessageBox.Show("Please generate some call numbers first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // EXCEPTION CATCHING
            }
        }

        /// <summary>
        /// Try again button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            this.Refresh();
            lbxRanGenCallNum.Items.Clear();
            lbxCorrect.Items.Clear();
            numbers.callNum.Clear();
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;
            star5.Visible = false;
            lbxCorrect.Visible = false;
            starCount.Visible = false;
            lblshowScore.Visible = false;

            for (int b = 0; b < 10; b++)
            {
                numbers.generateCallNumber();
                lbxRanGenCallNum.Items.Add(numbers.callNum[b]);
            }
        }
    }
}
