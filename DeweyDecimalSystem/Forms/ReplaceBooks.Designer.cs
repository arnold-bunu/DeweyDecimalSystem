namespace DeweyDecimalSystem.Forms
{
    partial class ReplaceBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceBooks));
            this.lbxRanGenCallNum = new System.Windows.Forms.ListBox();
            this.lbxCorrect = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.pbUpbtn = new System.Windows.Forms.PictureBox();
            this.pbDownbtn = new System.Windows.Forms.PictureBox();
            this.lblshowScore = new System.Windows.Forms.Label();
            this.starCount = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxRanGenCallNum
            // 
            this.lbxRanGenCallNum.FormattingEnabled = true;
            this.lbxRanGenCallNum.ItemHeight = 15;
            this.lbxRanGenCallNum.Location = new System.Drawing.Point(88, 52);
            this.lbxRanGenCallNum.Name = "lbxRanGenCallNum";
            this.lbxRanGenCallNum.Size = new System.Drawing.Size(155, 184);
            this.lbxRanGenCallNum.TabIndex = 0;
            // 
            // lbxCorrect
            // 
            this.lbxCorrect.FormattingEnabled = true;
            this.lbxCorrect.ItemHeight = 15;
            this.lbxCorrect.Location = new System.Drawing.Point(422, 52);
            this.lbxCorrect.Name = "lbxCorrect";
            this.lbxCorrect.Size = new System.Drawing.Size(151, 184);
            this.lbxCorrect.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Fuchsia;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerate.Location = new System.Drawing.Point(266, 125);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(124, 26);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.BackColor = System.Drawing.Color.Fuchsia;
            this.btnTryAgain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTryAgain.Location = new System.Drawing.Point(266, 157);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(124, 23);
            this.btnTryAgain.TabIndex = 3;
            this.btnTryAgain.Text = "TRY AGAIN";
            this.btnTryAgain.UseVisualStyleBackColor = false;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Fuchsia;
            this.btnDone.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDone.Location = new System.Drawing.Point(266, 280);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(124, 54);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pbUpbtn
            // 
            this.pbUpbtn.Image = ((System.Drawing.Image)(resources.GetObject("pbUpbtn.Image")));
            this.pbUpbtn.Location = new System.Drawing.Point(282, 52);
            this.pbUpbtn.Name = "pbUpbtn";
            this.pbUpbtn.Size = new System.Drawing.Size(94, 67);
            this.pbUpbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpbtn.TabIndex = 5;
            this.pbUpbtn.TabStop = false;
            this.pbUpbtn.Click += new System.EventHandler(this.pbUpbtn_Click);
            // 
            // pbDownbtn
            // 
            this.pbDownbtn.Image = ((System.Drawing.Image)(resources.GetObject("pbDownbtn.Image")));
            this.pbDownbtn.Location = new System.Drawing.Point(282, 186);
            this.pbDownbtn.Name = "pbDownbtn";
            this.pbDownbtn.Size = new System.Drawing.Size(96, 64);
            this.pbDownbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDownbtn.TabIndex = 6;
            this.pbDownbtn.TabStop = false;
            this.pbDownbtn.Click += new System.EventHandler(this.pbDownbtn_Click);
            // 
            // lblshowScore
            // 
            this.lblshowScore.AutoSize = true;
            this.lblshowScore.Location = new System.Drawing.Point(452, 280);
            this.lblshowScore.Name = "lblshowScore";
            this.lblshowScore.Size = new System.Drawing.Size(38, 15);
            this.lblshowScore.TabIndex = 7;
            this.lblshowScore.Text = "label1";
            this.lblshowScore.Click += new System.EventHandler(this.lblshowScore_Click);
            // 
            // starCount
            // 
            this.starCount.AutoSize = true;
            this.starCount.Location = new System.Drawing.Point(452, 319);
            this.starCount.Name = "starCount";
            this.starCount.Size = new System.Drawing.Size(38, 15);
            this.starCount.TabIndex = 8;
            this.starCount.Text = "label2";
            // 
            // star1
            // 
            this.star1.Image = ((System.Drawing.Image)(resources.GetObject("star1.Image")));
            this.star1.Location = new System.Drawing.Point(422, 351);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(60, 55);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star1.TabIndex = 9;
            this.star1.TabStop = false;
            // 
            // star5
            // 
            this.star5.Image = ((System.Drawing.Image)(resources.GetObject("star5.Image")));
            this.star5.Location = new System.Drawing.Point(686, 351);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(60, 55);
            this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star5.TabIndex = 10;
            this.star5.TabStop = false;
            // 
            // star4
            // 
            this.star4.Image = ((System.Drawing.Image)(resources.GetObject("star4.Image")));
            this.star4.Location = new System.Drawing.Point(620, 351);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(60, 55);
            this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star4.TabIndex = 11;
            this.star4.TabStop = false;
            // 
            // star3
            // 
            this.star3.Image = ((System.Drawing.Image)(resources.GetObject("star3.Image")));
            this.star3.Location = new System.Drawing.Point(554, 351);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(60, 55);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star3.TabIndex = 12;
            this.star3.TabStop = false;
            // 
            // star2
            // 
            this.star2.Image = ((System.Drawing.Image)(resources.GetObject("star2.Image")));
            this.star2.Location = new System.Drawing.Point(488, 351);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(60, 55);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star2.TabIndex = 13;
            this.star2.TabStop = false;
            // 
            // ReplaceBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.starCount);
            this.Controls.Add(this.lblshowScore);
            this.Controls.Add(this.pbDownbtn);
            this.Controls.Add(this.pbUpbtn);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnTryAgain);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lbxCorrect);
            this.Controls.Add(this.lbxRanGenCallNum);
            this.Name = "ReplaceBooks";
            this.Text = "ReplaceBooks";
            ((System.ComponentModel.ISupportInitialize)(this.pbUpbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxRanGenCallNum;
        private ListBox lbxCorrect;
        private Button btnGenerate;
        private Button btnTryAgain;
        private Button btnDone;
        private PictureBox pbUpbtn;
        private PictureBox pbDownbtn;
        private Label lblshowScore;
        private Label starCount;
        private PictureBox star1;
        private PictureBox star5;
        private PictureBox star4;
        private PictureBox star3;
        private PictureBox star2;
    }
}