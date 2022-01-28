namespace GetActivityIdeas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.activitiesListBox = new System.Windows.Forms.ListBox();
            this.addNewActivityBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 461);
            this.panel1.TabIndex = 0;
            // 
            // activitiesListBox
            // 
            this.activitiesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activitiesListBox.FormattingEnabled = true;
            this.activitiesListBox.ItemHeight = 15;
            this.activitiesListBox.Location = new System.Drawing.Point(0, 0);
            this.activitiesListBox.Name = "activitiesListBox";
            this.activitiesListBox.Size = new System.Drawing.Size(304, 405);
            this.activitiesListBox.TabIndex = 0;
            // 
            // addNewActivityBtn
            // 
            this.addNewActivityBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNewActivityBtn.Location = new System.Drawing.Point(0, 0);
            this.addNewActivityBtn.Name = "addNewActivityBtn";
            this.addNewActivityBtn.Size = new System.Drawing.Size(304, 52);
            this.addNewActivityBtn.TabIndex = 0;
            this.addNewActivityBtn.Text = "New";
            this.addNewActivityBtn.UseVisualStyleBackColor = true;
            this.addNewActivityBtn.Click += new System.EventHandler(this.addNewActivityBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.activitiesListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.addNewActivityBtn);
            this.splitContainer1.Size = new System.Drawing.Size(304, 461);
            this.splitContainer1.SplitterDistance = 405;
            this.splitContainer1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ListBox activitiesListBox;
        private Button addNewActivityBtn;
        private SplitContainer splitContainer1;
    }
}