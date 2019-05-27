namespace _2002807_Maeda_Survey8._6
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonAlways = new System.Windows.Forms.RadioButton();
            this.buttonUsually = new System.Windows.Forms.RadioButton();
            this.buttonSometimes = new System.Windows.Forms.RadioButton();
            this.buttonSeldom = new System.Windows.Forms.RadioButton();
            this.buttonNever = new System.Windows.Forms.RadioButton();
            this.next = new System.Windows.Forms.Button();
            this.noButtonSelected = new System.Windows.Forms.RadioButton();
            this.analysis = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(18, 9);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(49, 13);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question";
            // 
            // buttonAlways
            // 
            this.buttonAlways.AutoSize = true;
            this.buttonAlways.Location = new System.Drawing.Point(21, 90);
            this.buttonAlways.Name = "buttonAlways";
            this.buttonAlways.Size = new System.Drawing.Size(58, 17);
            this.buttonAlways.TabIndex = 1;
            this.buttonAlways.TabStop = true;
            this.buttonAlways.Text = "Always";
            this.buttonAlways.UseVisualStyleBackColor = true;
            // 
            // buttonUsually
            // 
            this.buttonUsually.AutoSize = true;
            this.buttonUsually.Location = new System.Drawing.Point(85, 90);
            this.buttonUsually.Name = "buttonUsually";
            this.buttonUsually.Size = new System.Drawing.Size(59, 17);
            this.buttonUsually.TabIndex = 2;
            this.buttonUsually.TabStop = true;
            this.buttonUsually.Text = "Usually";
            this.buttonUsually.UseVisualStyleBackColor = true;
            // 
            // buttonSometimes
            // 
            this.buttonSometimes.AutoSize = true;
            this.buttonSometimes.Location = new System.Drawing.Point(150, 90);
            this.buttonSometimes.Name = "buttonSometimes";
            this.buttonSometimes.Size = new System.Drawing.Size(76, 17);
            this.buttonSometimes.TabIndex = 3;
            this.buttonSometimes.TabStop = true;
            this.buttonSometimes.Text = "Sometimes";
            this.buttonSometimes.UseVisualStyleBackColor = true;
            // 
            // buttonSeldom
            // 
            this.buttonSeldom.AutoSize = true;
            this.buttonSeldom.Location = new System.Drawing.Point(232, 90);
            this.buttonSeldom.Name = "buttonSeldom";
            this.buttonSeldom.Size = new System.Drawing.Size(60, 17);
            this.buttonSeldom.TabIndex = 4;
            this.buttonSeldom.TabStop = true;
            this.buttonSeldom.Text = "Seldom";
            this.buttonSeldom.UseVisualStyleBackColor = true;
            // 
            // buttonNever
            // 
            this.buttonNever.AutoSize = true;
            this.buttonNever.Location = new System.Drawing.Point(298, 90);
            this.buttonNever.Name = "buttonNever";
            this.buttonNever.Size = new System.Drawing.Size(54, 17);
            this.buttonNever.TabIndex = 5;
            this.buttonNever.TabStop = true;
            this.buttonNever.Text = "Never";
            this.buttonNever.UseVisualStyleBackColor = true;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(12, 113);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(122, 43);
            this.next.TabIndex = 6;
            this.next.Text = "Next Question";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // noButtonSelected
            // 
            this.noButtonSelected.AutoSize = true;
            this.noButtonSelected.Location = new System.Drawing.Point(311, 139);
            this.noButtonSelected.Name = "noButtonSelected";
            this.noButtonSelected.Size = new System.Drawing.Size(63, 17);
            this.noButtonSelected.TabIndex = 7;
            this.noButtonSelected.TabStop = true;
            this.noButtonSelected.Text = "Invisible";
            this.noButtonSelected.UseVisualStyleBackColor = true;
            // 
            // analysis
            // 
            this.analysis.Location = new System.Drawing.Point(141, 113);
            this.analysis.Name = "analysis";
            this.analysis.Size = new System.Drawing.Size(120, 43);
            this.analysis.TabIndex = 8;
            this.analysis.Text = "Item Analysis";
            this.analysis.UseVisualStyleBackColor = true;
            this.analysis.Click += new System.EventHandler(this.analysis_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 168);
            this.Controls.Add(this.analysis);
            this.Controls.Add(this.noButtonSelected);
            this.Controls.Add(this.next);
            this.Controls.Add(this.buttonNever);
            this.Controls.Add(this.buttonSeldom);
            this.Controls.Add(this.buttonSometimes);
            this.Controls.Add(this.buttonUsually);
            this.Controls.Add(this.buttonAlways);
            this.Controls.Add(this.labelQuestion);
            this.Name = "Form1";
            this.Text = "Survey 8.6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton buttonAlways;
        private System.Windows.Forms.RadioButton buttonUsually;
        private System.Windows.Forms.RadioButton buttonSometimes;
        private System.Windows.Forms.RadioButton buttonSeldom;
        private System.Windows.Forms.RadioButton buttonNever;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.RadioButton noButtonSelected;
        private System.Windows.Forms.Button analysis;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

