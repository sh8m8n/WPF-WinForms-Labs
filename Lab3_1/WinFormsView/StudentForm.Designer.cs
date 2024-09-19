namespace WinFormsView
{
    partial class StudentForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.SpecialityTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Специальность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(350, 267);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "OK";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Location = new System.Drawing.Point(278, 157);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(242, 22);
            this.GroupTextBox.TabIndex = 9;
            // 
            // SpecialityTextBox
            // 
            this.SpecialityTextBox.Location = new System.Drawing.Point(278, 115);
            this.SpecialityTextBox.Name = "SpecialityTextBox";
            this.SpecialityTextBox.Size = new System.Drawing.Size(242, 22);
            this.SpecialityTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(278, 79);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(242, 22);
            this.NameTextBox.TabIndex = 7;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.GroupTextBox);
            this.Controls.Add(this.SpecialityTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.TextBox SpecialityTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}