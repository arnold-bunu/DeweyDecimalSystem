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
    public partial class FindingCallNumbers : Form
    {
        public FindingCallNumbers()
        {
            InitializeComponent();
            lblScore.Visible = false;
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            Start();
        }

        /// <summary>
        /// Start method
        /// </summary>
        private void Start()
        {
            FindingCallClass.scoreTrack = 0;
            FindingCallClass.PopulateTree();
            lblQuestion.Text = FindingCallClass.lblQuestion();
            answerButtons();


        }
        /// <summary>
        /// Populating answer buttons
        /// </summary>
        private void answerButtons()
        {
            List<string> questions = FindingCallClass.Questions();
            btnAns1.Text = questions[0];
            btnAns2.Text = questions[1];
            btnAns3.Text = questions[2];
            btnAns4.Text = questions[3];
        }


        private void btnAns1_Click(object sender, EventArgs e)
        {
            if (FindingCallClass.Check(btnAns1.Text))
            {
                MessageBox.Show("well done ! correct");
            } else
            {
                MessageBox.Show("Try harder");
            } 
            if (FindingCallClass.current > 2)
            {
                showScores();
                Start();
                
            }
            answerButtons();
        }

        private void btnAns2_Click(object sender, EventArgs e)
        {
            if (FindingCallClass.Check(btnAns1.Text))
            {
                MessageBox.Show("well done ! correct");
            }
            else
            {
                MessageBox.Show("Try harder");
            }
            if (FindingCallClass.current > 2)
            {
                showScores();
                Start();
            }
            answerButtons();
        }

        private void btnAns3_Click(object sender, EventArgs e)
        {
            if (FindingCallClass.Check(btnAns1.Text))
            {
                MessageBox.Show("well done ! correct");
            }
            else
            {
                MessageBox.Show("Try harder");
            }
            if (FindingCallClass.current > 2)
            {
                showScores();
                Start();
            }
            answerButtons();

        }

        private void btnAns4_Click(object sender, EventArgs e)
        {
            if (FindingCallClass.Check(btnAns1.Text))
            {
                MessageBox.Show("well done ! correct");
            }
            else
            {
                MessageBox.Show("Try harder");
            }
            if (FindingCallClass.current > 2)
            {
                showScores();
                Start();
            }
            answerButtons();

        }
        /// <summary>
        /// Method to keep track of scores 
        /// </summary>
        public  void showScores()
        {
            if (FindingCallClass.scoreTrack == 0)
            {
                lblScore.Visible = true;

            }
            else if (FindingCallClass.scoreTrack == 1)
            {
                lblScore.Visible = true;
                star1.Visible = true;
            }
            else if (FindingCallClass.scoreTrack == 2)
            {
                lblScore.Visible = true;
                star1.Visible = true;
                star2.Visible = true;

            }
            else if (FindingCallClass.scoreTrack == 3)
            {
                lblScore.Visible = true;
                star1.Visible = true;
                star2.Visible = true;
                star3.Visible = true;
            }
        }
    }

   

}
