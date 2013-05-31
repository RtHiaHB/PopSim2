namespace PopSim2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PopulationList = new System.Windows.Forms.ListBox();
            this.ThoughtBubble = new System.Windows.Forms.RichTextBox();
            this.PopulationMessages = new System.Windows.Forms.RichTextBox();
            this.DetailsBtn = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.DateText = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PopulationText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MalePop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FemPop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PopulationList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ThoughtBubble, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PopulationMessages, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DetailsBtn, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 126);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 204);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PopulationList
            // 
            this.PopulationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PopulationList.FormattingEnabled = true;
            this.PopulationList.Location = new System.Drawing.Point(275, 3);
            this.PopulationList.Name = "PopulationList";
            this.PopulationList.Size = new System.Drawing.Size(266, 81);
            this.PopulationList.TabIndex = 0;
            this.PopulationList.SelectedIndexChanged += new System.EventHandler(this.PopulationList_SelectedIndexChanged);
            // 
            // ThoughtBubble
            // 
            this.ThoughtBubble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThoughtBubble.Location = new System.Drawing.Point(275, 119);
            this.ThoughtBubble.Name = "ThoughtBubble";
            this.ThoughtBubble.Size = new System.Drawing.Size(266, 82);
            this.ThoughtBubble.TabIndex = 1;
            this.ThoughtBubble.Text = "";
            // 
            // PopulationMessages
            // 
            this.PopulationMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PopulationMessages.Location = new System.Drawing.Point(3, 3);
            this.PopulationMessages.Name = "PopulationMessages";
            this.tableLayoutPanel1.SetRowSpan(this.PopulationMessages, 3);
            this.PopulationMessages.Size = new System.Drawing.Size(266, 198);
            this.PopulationMessages.TabIndex = 2;
            this.PopulationMessages.Text = "";
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsBtn.Location = new System.Drawing.Point(272, 87);
            this.DetailsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.Size = new System.Drawing.Size(272, 29);
            this.DetailsBtn.TabIndex = 3;
            this.DetailsBtn.Text = "Details";
            this.DetailsBtn.UseVisualStyleBackColor = true;
            this.DetailsBtn.Click += new System.EventHandler(this.DetailsBtn_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NextButton.Location = new System.Drawing.Point(39, 39);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "&Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // DateText
            // 
            this.DateText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateText.Location = new System.Drawing.Point(169, 23);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(100, 44);
            this.DateText.TabIndex = 2;
            this.DateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 103);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(544, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // PopulationText
            // 
            this.PopulationText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PopulationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopulationText.Location = new System.Drawing.Point(275, 23);
            this.PopulationText.Name = "PopulationText";
            this.PopulationText.Size = new System.Drawing.Size(100, 44);
            this.PopulationText.TabIndex = 4;
            this.PopulationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Population";
            // 
            // MalePop
            // 
            this.MalePop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MalePop.Location = new System.Drawing.Point(380, 22);
            this.MalePop.Name = "MalePop";
            this.MalePop.Size = new System.Drawing.Size(100, 20);
            this.MalePop.TabIndex = 7;
            this.MalePop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Males";
            // 
            // FemPop
            // 
            this.FemPop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FemPop.Location = new System.Drawing.Point(380, 64);
            this.FemPop.Name = "FemPop";
            this.FemPop.Size = new System.Drawing.Size(100, 20);
            this.FemPop.TabIndex = 9;
            this.FemPop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Females";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveButton.Location = new System.Drawing.Point(182, 73);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoadButton.Location = new System.Drawing.Point(263, 73);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 12;
            this.LoadButton.Text = "&Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 330);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FemPop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MalePop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PopulationText);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PopSim2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox PopulationList;
        private System.Windows.Forms.RichTextBox ThoughtBubble;
        private System.Windows.Forms.RichTextBox PopulationMessages;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox DateText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox PopulationText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MalePop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FemPop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button DetailsBtn;

    }
}

