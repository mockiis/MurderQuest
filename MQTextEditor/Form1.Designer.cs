namespace MQTextEditor
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
            this.NewBtn = new System.Windows.Forms.Button();
            this.DialogsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DialogTextBox = new System.Windows.Forms.TextBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.DataBox = new System.Windows.Forms.GroupBox();
            this.Stats4LBL = new System.Windows.Forms.Label();
            this.Stats4Box = new System.Windows.Forms.TextBox();
            this.Stats3LBL = new System.Windows.Forms.Label();
            this.Stats3Box = new System.Windows.Forms.TextBox();
            this.Stats2LBL = new System.Windows.Forms.Label();
            this.Stats2Box = new System.Windows.Forms.TextBox();
            this.Stats1LBL = new System.Windows.Forms.Label();
            this.Stats1Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NextTextBox = new System.Windows.Forms.TextBox();
            this.DataBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(250, 25);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 23);
            this.NewBtn.TabIndex = 0;
            this.NewBtn.Text = "New file";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // DialogsComboBox
            // 
            this.DialogsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DialogsComboBox.FormattingEnabled = true;
            this.DialogsComboBox.Location = new System.Drawing.Point(9, 206);
            this.DialogsComboBox.Name = "DialogsComboBox";
            this.DialogsComboBox.Size = new System.Drawing.Size(121, 21);
            this.DialogsComboBox.TabIndex = 1;
            this.DialogsComboBox.SelectedIndexChanged += new System.EventHandler(this.DialogsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Dialog";
            // 
            // DialogTextBox
            // 
            this.DialogTextBox.Location = new System.Drawing.Point(6, 277);
            this.DialogTextBox.Multiline = true;
            this.DialogTextBox.Name = "DialogTextBox";
            this.DialogTextBox.Size = new System.Drawing.Size(466, 120);
            this.DialogTextBox.TabIndex = 3;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(331, 25);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Load file";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(412, 25);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save File";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Enabled = false;
            this.OkBtn.Location = new System.Drawing.Point(414, 413);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 3;
            this.OkBtn.Text = "Ok/next";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // DataBox
            // 
            this.DataBox.Controls.Add(this.Stats4LBL);
            this.DataBox.Controls.Add(this.Stats4Box);
            this.DataBox.Controls.Add(this.Stats3LBL);
            this.DataBox.Controls.Add(this.Stats3Box);
            this.DataBox.Controls.Add(this.Stats2LBL);
            this.DataBox.Controls.Add(this.Stats2Box);
            this.DataBox.Controls.Add(this.Stats1LBL);
            this.DataBox.Controls.Add(this.Stats1Box);
            this.DataBox.Controls.Add(this.label3);
            this.DataBox.Controls.Add(this.label2);
            this.DataBox.Controls.Add(this.NextTextBox);
            this.DataBox.Controls.Add(this.OkBtn);
            this.DataBox.Controls.Add(this.label1);
            this.DataBox.Controls.Add(this.DialogTextBox);
            this.DataBox.Controls.Add(this.DialogsComboBox);
            this.DataBox.Enabled = false;
            this.DataBox.Location = new System.Drawing.Point(12, 54);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(496, 467);
            this.DataBox.TabIndex = 7;
            this.DataBox.TabStop = false;
            this.DataBox.Text = "Data";
            // 
            // Stats4LBL
            // 
            this.Stats4LBL.AutoSize = true;
            this.Stats4LBL.Location = new System.Drawing.Point(124, 71);
            this.Stats4LBL.Name = "Stats4LBL";
            this.Stats4LBL.Size = new System.Drawing.Size(34, 13);
            this.Stats4LBL.TabIndex = 14;
            this.Stats4LBL.Text = "sanity";
            // 
            // Stats4Box
            // 
            this.Stats4Box.Location = new System.Drawing.Point(124, 87);
            this.Stats4Box.Name = "Stats4Box";
            this.Stats4Box.Size = new System.Drawing.Size(100, 20);
            this.Stats4Box.TabIndex = 13;
            // 
            // Stats3LBL
            // 
            this.Stats3LBL.AutoSize = true;
            this.Stats3LBL.Location = new System.Drawing.Point(121, 25);
            this.Stats3LBL.Name = "Stats3LBL";
            this.Stats3LBL.Size = new System.Drawing.Size(18, 13);
            this.Stats3LBL.TabIndex = 12;
            this.Stats3LBL.Text = "str";
            // 
            // Stats3Box
            // 
            this.Stats3Box.Location = new System.Drawing.Point(121, 41);
            this.Stats3Box.Name = "Stats3Box";
            this.Stats3Box.Size = new System.Drawing.Size(100, 20);
            this.Stats3Box.TabIndex = 11;
            // 
            // Stats2LBL
            // 
            this.Stats2LBL.AutoSize = true;
            this.Stats2LBL.Location = new System.Drawing.Point(6, 71);
            this.Stats2LBL.Name = "Stats2LBL";
            this.Stats2LBL.Size = new System.Drawing.Size(19, 13);
            this.Stats2LBL.TabIndex = 10;
            this.Stats2LBL.Text = "Int";
            // 
            // Stats2Box
            // 
            this.Stats2Box.Location = new System.Drawing.Point(6, 87);
            this.Stats2Box.Name = "Stats2Box";
            this.Stats2Box.Size = new System.Drawing.Size(100, 20);
            this.Stats2Box.TabIndex = 9;
            // 
            // Stats1LBL
            // 
            this.Stats1LBL.AutoSize = true;
            this.Stats1LBL.Location = new System.Drawing.Point(6, 25);
            this.Stats1LBL.Name = "Stats1LBL";
            this.Stats1LBL.Size = new System.Drawing.Size(26, 13);
            this.Stats1LBL.TabIndex = 8;
            this.Stats1LBL.Text = "Age";
            // 
            // Stats1Box
            // 
            this.Stats1Box.Location = new System.Drawing.Point(6, 41);
            this.Stats1Box.Name = "Stats1Box";
            this.Stats1Box.Size = new System.Drawing.Size(100, 20);
            this.Stats1Box.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dialog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Next Dialog";
            // 
            // NextTextBox
            // 
            this.NextTextBox.Location = new System.Drawing.Point(310, 207);
            this.NextTextBox.Name = "NextTextBox";
            this.NextTextBox.Size = new System.Drawing.Size(156, 20);
            this.NextTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 533);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.NewBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DataBox.ResumeLayout(false);
            this.DataBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.ComboBox DialogsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DialogTextBox;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.GroupBox DataBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NextTextBox;
        private System.Windows.Forms.Label Stats4LBL;
        private System.Windows.Forms.TextBox Stats4Box;
        private System.Windows.Forms.Label Stats3LBL;
        private System.Windows.Forms.TextBox Stats3Box;
        private System.Windows.Forms.Label Stats2LBL;
        private System.Windows.Forms.TextBox Stats2Box;
        private System.Windows.Forms.Label Stats1LBL;
        private System.Windows.Forms.TextBox Stats1Box;
    }
}

