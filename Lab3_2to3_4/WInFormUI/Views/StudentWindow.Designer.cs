namespace WinFormsUI.Views
{
    partial class StudentWindow
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
            this.Ok_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_txtBox = new System.Windows.Forms.TextBox();
            this.Spec_txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Group_txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ok_btn
            // 
            this.Ok_btn.Location = new System.Drawing.Point(153, 244);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(75, 23);
            this.Ok_btn.TabIndex = 0;
            this.Ok_btn.Text = "OK";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // Name_txtBox
            // 
            this.Name_txtBox.Location = new System.Drawing.Point(46, 45);
            this.Name_txtBox.Name = "Name_txtBox";
            this.Name_txtBox.Size = new System.Drawing.Size(261, 20);
            this.Name_txtBox.TabIndex = 2;
            // 
            // Spec_txtBox
            // 
            this.Spec_txtBox.Location = new System.Drawing.Point(46, 108);
            this.Spec_txtBox.Name = "Spec_txtBox";
            this.Spec_txtBox.Size = new System.Drawing.Size(261, 20);
            this.Spec_txtBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Специализация";
            // 
            // Group_txtBox
            // 
            this.Group_txtBox.Location = new System.Drawing.Point(46, 169);
            this.Group_txtBox.Name = "Group_txtBox";
            this.Group_txtBox.Size = new System.Drawing.Size(261, 20);
            this.Group_txtBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Группа";
            // 
            // StudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 335);
            this.Controls.Add(this.Group_txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Spec_txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_txtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ok_btn);
            this.Name = "StudentWindow";
            this.Text = "StudentWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_txtBox;
        private System.Windows.Forms.TextBox Spec_txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Group_txtBox;
        private System.Windows.Forms.Label label3;
    }
}