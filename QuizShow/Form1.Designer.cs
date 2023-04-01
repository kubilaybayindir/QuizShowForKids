namespace QuizShow
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Rtb_QuestionDs = new System.Windows.Forms.RichTextBox();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.PbWrong = new System.Windows.Forms.PictureBox();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.LblCorrect = new System.Windows.Forms.Label();
            this.PbCorrect = new System.Windows.Forms.PictureBox();
            this.LblWrong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // Rtb_QuestionDs
            // 
            this.Rtb_QuestionDs.BackColor = System.Drawing.SystemColors.Info;
            this.Rtb_QuestionDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rtb_QuestionDs.Location = new System.Drawing.Point(13, 13);
            this.Rtb_QuestionDs.Name = "Rtb_QuestionDs";
            this.Rtb_QuestionDs.Size = new System.Drawing.Size(473, 153);
            this.Rtb_QuestionDs.TabIndex = 0;
            this.Rtb_QuestionDs.Text = "";
            // 
            // btn_A
            // 
            this.btn_A.BackColor = System.Drawing.Color.Gray;
            this.btn_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_A.Location = new System.Drawing.Point(13, 187);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(96, 38);
            this.btn_A.TabIndex = 1;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = false;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_B
            // 
            this.btn_B.BackColor = System.Drawing.Color.Gray;
            this.btn_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_B.Location = new System.Drawing.Point(138, 187);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(96, 38);
            this.btn_B.TabIndex = 2;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = false;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_D
            // 
            this.btn_D.BackColor = System.Drawing.Color.Gray;
            this.btn_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_D.Location = new System.Drawing.Point(388, 187);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(96, 38);
            this.btn_D.TabIndex = 4;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = false;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.Gray;
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_C.Location = new System.Drawing.Point(263, 187);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(96, 38);
            this.btn_C.TabIndex = 3;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Next.Location = new System.Drawing.Point(513, 110);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(198, 37);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "Next Question";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // PbWrong
            // 
            this.PbWrong.Image = ((System.Drawing.Image)(resources.GetObject("PbWrong.Image")));
            this.PbWrong.Location = new System.Drawing.Point(632, 162);
            this.PbWrong.Name = "PbWrong";
            this.PbWrong.Size = new System.Drawing.Size(79, 63);
            this.PbWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbWrong.TabIndex = 8;
            this.PbWrong.TabStop = false;
            this.PbWrong.Visible = false;
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblQuestion.Location = new System.Drawing.Point(509, 16);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(77, 20);
            this.LblQuestion.TabIndex = 9;
            this.LblQuestion.Text = "Question:";
            // 
            // LblCorrect
            // 
            this.LblCorrect.AutoSize = true;
            this.LblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCorrect.Location = new System.Drawing.Point(509, 47);
            this.LblCorrect.Name = "LblCorrect";
            this.LblCorrect.Size = new System.Drawing.Size(65, 20);
            this.LblCorrect.TabIndex = 10;
            this.LblCorrect.Text = "Correct:";
            // 
            // PbCorrect
            // 
            this.PbCorrect.Image = ((System.Drawing.Image)(resources.GetObject("PbCorrect.Image")));
            this.PbCorrect.Location = new System.Drawing.Point(513, 162);
            this.PbCorrect.Name = "PbCorrect";
            this.PbCorrect.Size = new System.Drawing.Size(79, 63);
            this.PbCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCorrect.TabIndex = 11;
            this.PbCorrect.TabStop = false;
            this.PbCorrect.Visible = false;
            // 
            // LblWrong
            // 
            this.LblWrong.AutoSize = true;
            this.LblWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblWrong.Location = new System.Drawing.Point(509, 78);
            this.LblWrong.Name = "LblWrong";
            this.LblWrong.Size = new System.Drawing.Size(60, 20);
            this.LblWrong.TabIndex = 12;
            this.LblWrong.Text = "Wrong:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 237);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblWrong);
            this.Controls.Add(this.PbCorrect);
            this.Controls.Add(this.LblCorrect);
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.PbWrong);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.Rtb_QuestionDs);
            this.Name = "Form1";
            this.Text = "Basic Quiz Show";
            ((System.ComponentModel.ISupportInitialize)(this.PbWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtb_QuestionDs;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.PictureBox PbWrong;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.Label LblCorrect;
        private System.Windows.Forms.PictureBox PbCorrect;
        private System.Windows.Forms.Label LblWrong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

