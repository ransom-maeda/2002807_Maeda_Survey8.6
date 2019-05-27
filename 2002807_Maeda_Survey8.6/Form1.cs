using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_Survey8._6
{
    public partial class Form1 : Form
    {
        List<Question> Questions = new List<Question>();
        int[,] surveyData = new int[10, 5];
        int surveyIndex = 0;
        int index = 0;
        const int ALWAYS = 0,
            USUALLY = 1,
            SOMETIMES = 2,
            SELDOM = 3,
            NEVER = 4;
        int alwaysSelected = 0,
            usuallySelected = 0,
            sometimesSelected = 0,
            seldomSelected = 0,
            neverSelected = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Arial", 14);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float lineHeightFloat = (float)printFont.GetHeight();
            float column1Float = e.MarginBounds.Left;
            float yFloat = e.MarginBounds.Top;
            float column2Float = 200;
            float column3Float = 350f;
            float column4Float = 500f;
            float column5Float = 650f;
            string lineString;

            lineString = "Report";
            e.Graphics.DrawString(lineString,
                headingFont,
                Brushes.Black,
                column1Float, yFloat);
            yFloat += (lineHeightFloat * 2);

            e.Graphics.DrawString("Always",
                printFont,
                Brushes.Black,
                column1Float, yFloat);

            e.Graphics.DrawString("Usually",
                printFont,
                Brushes.Black,
                column2Float, yFloat);

            e.Graphics.DrawString("Sometimes",
                printFont,
                Brushes.Black,
                column3Float, yFloat);

            e.Graphics.DrawString("Seldom",
                printFont,
                Brushes.Black,
                column4Float, yFloat);

            e.Graphics.DrawString("Never",
                printFont,
                Brushes.Black,
                column5Float, yFloat);
            yFloat += (lineHeightFloat * 2);

            for(int index = 0; index <= surveyData.GetUpperBound(0); index++)
            {
                if (surveyData[index, ALWAYS] == 0) break;
                {
                    e.Graphics.DrawString(surveyData[index, ALWAYS].ToString(),
                        headingFont,
                        Brushes.Black,
                        column1Float, yFloat);

                    e.Graphics.DrawString(surveyData[index, USUALLY].ToString(),
                        headingFont,
                        Brushes.Black,
                        column2Float, yFloat);

                    e.Graphics.DrawString(surveyData[index, SOMETIMES].ToString(),
                        headingFont,
                        Brushes.Black,
                        column3Float, yFloat);

                    e.Graphics.DrawString(surveyData[index, SELDOM].ToString(),
                        headingFont,
                        Brushes.Black,
                        column4Float, yFloat);

                    e.Graphics.DrawString(surveyData[index, NEVER].ToString(),
                        headingFont,
                        Brushes.Black,
                        column5Float, yFloat);
                    yFloat += (lineHeightFloat * 2);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            noButtonSelected.Checked = true;
            noButtonSelected.Visible = false;
            Question q1 = new Question("How often do you get up before 7 am?");
            Question q2 = new Question("How often do you do sports before breakfast?");
            Question q3 = new Question("How often do you drive to work in your own car?");
            Question q4 = new Question("How often do you have lunch at work with colleagues?");
            Question q5 = new Question("How often are you late for class?");
            Question q6 = new Question("How often do you go home before you go to work out?");
            Question q7 = new Question("How often do you forget your writing utensils?");
            Question q8 = new Question("How often do you learn something new in class?");
            Question q9 = new Question("How often do you buy something from Starbucks?");
            Question q10 = new Question("How often do you  have a coffee or tea when you arrive at work?");

            Questions.Add(q1);
            Questions.Add(q2);
            Questions.Add(q3);
            Questions.Add(q4);
            Questions.Add(q5);
            Questions.Add(q6);
            Questions.Add(q7);
            Questions.Add(q8);
            Questions.Add(q9);
            Questions.Add(q10);

            labelQuestion.Text = "How often do you get up before 7 am?";
        }

        public Question GetQuestion()
        {
            index++;
            if (index >= Questions.Count) index = 0;
            return Questions[index];
        }

        private void next_Click(object sender, EventArgs e)
        {
            noButtonSelected.Checked = true;
            surveyData[surveyIndex, ALWAYS] = alwaysSelected;
            surveyData[surveyIndex, USUALLY] = usuallySelected;
            surveyData[surveyIndex, SOMETIMES] = sometimesSelected;
            surveyData[surveyIndex, SELDOM] = seldomSelected;
            surveyData[surveyIndex, NEVER] = neverSelected;
            surveyIndex++;
            if (surveyIndex >= 10) surveyIndex = 0;
            Question questions = GetQuestion();
            labelQuestion.Text = questions.question;
            if (noButtonSelected.Checked)
            {
                MessageBox.Show("Please select a button", "Error");
            }
            else
            {
                if (buttonAlways.Checked)
                {
                    alwaysSelected++;
                }
                else if (buttonUsually.Checked)
                {
                    usuallySelected++;
                }
                else if (buttonSometimes.Checked)
                {
                    sometimesSelected++;
                }
                else if (buttonSeldom.Checked)
                {
                    seldomSelected++;
                }
                else if (buttonNever.Checked)
                {
                    neverSelected++;
                }

            }
        }
        private void analysis_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
