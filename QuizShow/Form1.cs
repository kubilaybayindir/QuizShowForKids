using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int QuestionNo { get; set; } = 0;
        public int CorrectNo { get; set; }=0;   
        public int WrongNo { get; set; } = 0;

        private void btn_Next_Click(object sender, EventArgs e)
        {
            QuestionNo++;
            PbCorrect.Visible = false;
            PbWrong.Visible = false;
            btn_A.Enabled = true; btn_B.Enabled= true; btn_C.Enabled = true; btn_D.Enabled = true;
            btn_Next.Enabled = false;
            switch (QuestionNo)
            {
                case 1:
                    Rtb_QuestionDs.Text = "What is half of 12 ?";
                    btn_A.Text = "2";
                    btn_B.Text = "3";
                    btn_C.Text = "4";
                    btn_D.Text = "6";
                    label1.Text = "6";
                    break;
                case 2:
                    Rtb_QuestionDs.Text = "What is a quarter of 8 ?";
                    btn_A.Text = "3";
                    btn_B.Text = "6";
                    btn_C.Text = "2";
                    btn_D.Text = "4";
                    label1.Text = "2";
                    break;

                case 3:
                    Rtb_QuestionDs.Text = "What is half of 6 ?";
                    btn_A.Text = "3";
                    btn_B.Text = "1";
                    btn_C.Text = "4";
                    btn_D.Text = "2";
                    label1.Text = "3";
                    break;

                case 4:
                    Rtb_QuestionDs.Text = "What is quarter of 20 ?";
                    btn_A.Text = "1";
                    btn_B.Text = "3";
                    btn_C.Text = "5";
                    btn_D.Text = "7";
                    label1.Text = "5";
                    break;

                case 5:
                    Rtb_QuestionDs.Text = "What is 4 times 8 ?";
                    btn_A.Text = "20";
                    btn_B.Text = "32";
                    btn_C.Text = "24";
                    btn_D.Text = "36";
                    label1.Text = "32";
                    break;
                default:
                    btn_Next.Text = "Result";
                    DialogResult dialogResult;
                    dialogResult = MessageBox.Show("Correct: " + CorrectNo.ToString() + "\n" + "Wrong: " + WrongNo.ToString() + "\n" + "Do you want to quit?", "Result", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.No)
                    {
                        QuestionNo = 0 ;
                        LblQuestion.Text = "Question:"  + "";
                        Rtb_QuestionDs.Text = "";
                        LblQuestion.Text = "";
                        LblCorrect.Text = "";
                        LblWrong.Text = "";
                    }
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Close();
                        Application.Exit();
                    }
                    break;
            }
            LblQuestion.Text = "Question: " + QuestionNo.ToString();
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false; btn_B.Enabled = false; btn_C.Enabled = false; btn_D.Enabled = false;
            btn_Next.Enabled = true;
            label2.Text = btn_A.Text;
            if (label1.Text == label2.Text)
            {
                CorrectNo++;
                PbCorrect.Visible = true;
                PbWrong.Visible = false;
                LblCorrect.Text = "Correct: " + CorrectNo.ToString();
            }
            else
            {
                WrongNo++;
                LblWrong.Text = "Wrong: " + WrongNo.ToString();
                PbCorrect.Visible = false;
                PbWrong.Visible = true;
            }
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false; btn_B.Enabled = false; btn_C.Enabled = false; btn_D.Enabled = false;
            btn_Next.Enabled = true;
            if (QuestionNo == 5)
            {
                CorrectNo++;
                PbCorrect.Visible = true;
                PbWrong.Visible = false;
                LblCorrect.Text = "Correct: " + CorrectNo.ToString();
            }
            else
            {
                WrongNo++;
                LblWrong.Text = "Wrong: " + WrongNo.ToString();
                PbCorrect.Visible = false;
                PbWrong.Visible = true;
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false; btn_B.Enabled = false; btn_C.Enabled = false; btn_D.Enabled = false;
            btn_Next.Enabled = true;
            if (QuestionNo == 2 || QuestionNo == 4)
            {
                CorrectNo++;
                PbCorrect.Visible = true;
                PbWrong.Visible = false;
                LblCorrect.Text = "Correct: " + CorrectNo.ToString();
            }
            else
            {
                WrongNo++;
                LblWrong.Text = "Wrong: " + WrongNo.ToString();
                PbCorrect.Visible = false;
                PbWrong.Visible = true;
            }
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false; btn_B.Enabled = false; btn_C.Enabled = false; btn_D.Enabled = false;
            btn_Next.Enabled = true;
            if (QuestionNo == 1)
            {
                CorrectNo++;
                PbCorrect.Visible = true;
                PbWrong.Visible = false;
                LblCorrect.Text = "Correct: " + CorrectNo.ToString();
            }
            else
            {
                WrongNo++;
                LblWrong.Text = "Wrong: " + WrongNo.ToString();
                PbCorrect.Visible = false;
                PbWrong.Visible = true;
            }
        }
    }
}
