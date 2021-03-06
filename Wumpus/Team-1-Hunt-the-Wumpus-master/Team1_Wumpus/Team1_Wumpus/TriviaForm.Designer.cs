﻿namespace Team1_Wumpus
{
    partial class TriviaForm
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
            this.labelCorrectIncorrect = new System.Windows.Forms.Label();
            this.buttonAnswer3 = new System.Windows.Forms.RadioButton();
            this.buttonAnswer2 = new System.Windows.Forms.RadioButton();
            this.buttonAnswer1 = new System.Windows.Forms.RadioButton();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.noButtonChecked = new System.Windows.Forms.RadioButton();
            this.button3Questions = new System.Windows.Forms.Button();
            this.button5Questions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCorrectIncorrect
            // 
            this.labelCorrectIncorrect.AutoSize = true;
            this.labelCorrectIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectIncorrect.Location = new System.Drawing.Point(284, 223);
            this.labelCorrectIncorrect.Name = "labelCorrectIncorrect";
            this.labelCorrectIncorrect.Size = new System.Drawing.Size(161, 20);
            this.labelCorrectIncorrect.TabIndex = 13;
            this.labelCorrectIncorrect.Text = "correct or incorrect";
            // 
            // buttonAnswer3
            // 
            this.buttonAnswer3.AutoSize = true;
            this.buttonAnswer3.Location = new System.Drawing.Point(376, 111);
            this.buttonAnswer3.Name = "buttonAnswer3";
            this.buttonAnswer3.Size = new System.Drawing.Size(69, 17);
            this.buttonAnswer3.TabIndex = 12;
            this.buttonAnswer3.TabStop = true;
            this.buttonAnswer3.Text = "Answer 3";
            this.buttonAnswer3.UseVisualStyleBackColor = true;
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.AutoSize = true;
            this.buttonAnswer2.Location = new System.Drawing.Point(237, 111);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(69, 17);
            this.buttonAnswer2.TabIndex = 11;
            this.buttonAnswer2.TabStop = true;
            this.buttonAnswer2.Text = "Answer 2";
            this.buttonAnswer2.UseVisualStyleBackColor = true;
            // 
            // buttonAnswer1
            // 
            this.buttonAnswer1.AutoSize = true;
            this.buttonAnswer1.Location = new System.Drawing.Point(98, 111);
            this.buttonAnswer1.Name = "buttonAnswer1";
            this.buttonAnswer1.Size = new System.Drawing.Size(69, 17);
            this.buttonAnswer1.TabIndex = 10;
            this.buttonAnswer1.TabStop = true;
            this.buttonAnswer1.Text = "Answer 1";
            this.buttonAnswer1.UseVisualStyleBackColor = true;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(95, 27);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(49, 13);
            this.labelQuestion.TabIndex = 9;
            this.labelQuestion.Text = "Question";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(90, 235);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(146, 43);
            this.check.TabIndex = 8;
            this.check.Text = "Check Answer";
            this.check.UseVisualStyleBackColor = true;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(90, 185);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(146, 44);
            this.next.TabIndex = 7;
            this.next.Text = "Next Question";
            this.next.UseVisualStyleBackColor = true;
            // 
            // noButtonChecked
            // 
            this.noButtonChecked.AutoSize = true;
            this.noButtonChecked.Location = new System.Drawing.Point(403, 134);
            this.noButtonChecked.Name = "noButtonChecked";
            this.noButtonChecked.Size = new System.Drawing.Size(63, 17);
            this.noButtonChecked.TabIndex = 14;
            this.noButtonChecked.TabStop = true;
            this.noButtonChecked.Text = "Invisible";
            this.noButtonChecked.UseVisualStyleBackColor = true;
            // 
            // button3Questions
            // 
            this.button3Questions.Location = new System.Drawing.Point(13, 76);
            this.button3Questions.Name = "button3Questions";
            this.button3Questions.Size = new System.Drawing.Size(75, 23);
            this.button3Questions.TabIndex = 15;
            this.button3Questions.Text = "3 Questions";
            this.button3Questions.UseVisualStyleBackColor = true;
            this.button3Questions.Click += new System.EventHandler(this.button3Questions_Click);
            // 
            // button5Questions
            // 
            this.button5Questions.Location = new System.Drawing.Point(12, 105);
            this.button5Questions.Name = "button5Questions";
            this.button5Questions.Size = new System.Drawing.Size(75, 23);
            this.button5Questions.TabIndex = 16;
            this.button5Questions.Text = "5 Questions";
            this.button5Questions.UseVisualStyleBackColor = true;
            this.button5Questions.Click += new System.EventHandler(this.button5Questions_Click);
            // 
            // TriviaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 332);
            this.Controls.Add(this.button5Questions);
            this.Controls.Add(this.button3Questions);
            this.Controls.Add(this.noButtonChecked);
            this.Controls.Add(this.labelCorrectIncorrect);
            this.Controls.Add(this.buttonAnswer3);
            this.Controls.Add(this.buttonAnswer2);
            this.Controls.Add(this.buttonAnswer1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.check);
            this.Controls.Add(this.next);
            this.Name = "TriviaForm";
            this.Text = "TriviaForm";
            this.Load += new System.EventHandler(this.TriviaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCorrectIncorrect;
        private System.Windows.Forms.RadioButton buttonAnswer3;
        private System.Windows.Forms.RadioButton buttonAnswer2;
        private System.Windows.Forms.RadioButton buttonAnswer1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.RadioButton noButtonChecked;
        private System.Windows.Forms.Button button3Questions;
        private System.Windows.Forms.Button button5Questions;
    }
}