namespace Lab2_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTxtBox_ProgramBuffer = new System.Windows.Forms.RichTextBox();
            this.richTxtBox_FileBuffer = new System.Windows.Forms.RichTextBox();
            this.btn_toFileBuffer = new System.Windows.Forms.Button();
            this.btn_toProgramBuffer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_StringCount = new System.Windows.Forms.TextBox();
            this.btn_GenerateText = new System.Windows.Forms.Button();
            this.btn_ClearProgramBuffer = new System.Windows.Forms.Button();
            this.btn_SaveToFile = new System.Windows.Forms.Button();
            this.btn_LoadFromFile = new System.Windows.Forms.Button();
            this.btn_ClearFileBuffer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Программный буфер";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Файловый Буфер";
            // 
            // richTxtBox_ProgramBuffer
            // 
            this.richTxtBox_ProgramBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTxtBox_ProgramBuffer.Location = new System.Drawing.Point(16, 30);
            this.richTxtBox_ProgramBuffer.Name = "richTxtBox_ProgramBuffer";
            this.richTxtBox_ProgramBuffer.Size = new System.Drawing.Size(350, 350);
            this.richTxtBox_ProgramBuffer.TabIndex = 2;
            this.richTxtBox_ProgramBuffer.Text = "";
            // 
            // richTxtBox_FileBuffer
            // 
            this.richTxtBox_FileBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtBox_FileBuffer.Location = new System.Drawing.Point(472, 30);
            this.richTxtBox_FileBuffer.Name = "richTxtBox_FileBuffer";
            this.richTxtBox_FileBuffer.Size = new System.Drawing.Size(350, 350);
            this.richTxtBox_FileBuffer.TabIndex = 3;
            this.richTxtBox_FileBuffer.Text = "";
            // 
            // btn_toFileBuffer
            // 
            this.btn_toFileBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_toFileBuffer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_toFileBuffer.BackgroundImage")));
            this.btn_toFileBuffer.Location = new System.Drawing.Point(378, 28);
            this.btn_toFileBuffer.Name = "btn_toFileBuffer";
            this.btn_toFileBuffer.Size = new System.Drawing.Size(80, 63);
            this.btn_toFileBuffer.TabIndex = 4;
            this.btn_toFileBuffer.UseVisualStyleBackColor = true;
            this.btn_toFileBuffer.Click += new System.EventHandler(this.btn_toFileBuffer_Click);
            // 
            // btn_toProgramBuffer
            // 
            this.btn_toProgramBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_toProgramBuffer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_toProgramBuffer.BackgroundImage")));
            this.btn_toProgramBuffer.Location = new System.Drawing.Point(378, 97);
            this.btn_toProgramBuffer.Name = "btn_toProgramBuffer";
            this.btn_toProgramBuffer.Size = new System.Drawing.Size(80, 63);
            this.btn_toProgramBuffer.TabIndex = 5;
            this.btn_toProgramBuffer.UseVisualStyleBackColor = true;
            this.btn_toProgramBuffer.Click += new System.EventHandler(this.btn_toProgramBuffer_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество строк для генерации";
            // 
            // txtbox_StringCount
            // 
            this.txtbox_StringCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbox_StringCount.Location = new System.Drawing.Point(16, 410);
            this.txtbox_StringCount.Name = "txtbox_StringCount";
            this.txtbox_StringCount.Size = new System.Drawing.Size(172, 20);
            this.txtbox_StringCount.TabIndex = 7;
            // 
            // btn_GenerateText
            // 
            this.btn_GenerateText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_GenerateText.Location = new System.Drawing.Point(16, 436);
            this.btn_GenerateText.Name = "btn_GenerateText";
            this.btn_GenerateText.Size = new System.Drawing.Size(172, 23);
            this.btn_GenerateText.TabIndex = 8;
            this.btn_GenerateText.Text = "Сгенерировать";
            this.btn_GenerateText.UseVisualStyleBackColor = true;
            this.btn_GenerateText.Click += new System.EventHandler(this.btn_GenerateText_Click);
            // 
            // btn_ClearProgramBuffer
            // 
            this.btn_ClearProgramBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ClearProgramBuffer.Location = new System.Drawing.Point(195, 407);
            this.btn_ClearProgramBuffer.Name = "btn_ClearProgramBuffer";
            this.btn_ClearProgramBuffer.Size = new System.Drawing.Size(171, 52);
            this.btn_ClearProgramBuffer.TabIndex = 9;
            this.btn_ClearProgramBuffer.Text = "Очистить программный буфер";
            this.btn_ClearProgramBuffer.UseVisualStyleBackColor = true;
            this.btn_ClearProgramBuffer.Click += new System.EventHandler(this.btn_ClearProgramBuffer_Click);
            // 
            // btn_SaveToFile
            // 
            this.btn_SaveToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveToFile.Location = new System.Drawing.Point(472, 436);
            this.btn_SaveToFile.Name = "btn_SaveToFile";
            this.btn_SaveToFile.Size = new System.Drawing.Size(175, 23);
            this.btn_SaveToFile.TabIndex = 10;
            this.btn_SaveToFile.Text = "Сохранить в файл";
            this.btn_SaveToFile.UseVisualStyleBackColor = true;
            this.btn_SaveToFile.Click += new System.EventHandler(this.btn_SaveToFile_Click);
            // 
            // btn_LoadFromFile
            // 
            this.btn_LoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LoadFromFile.Location = new System.Drawing.Point(472, 407);
            this.btn_LoadFromFile.Name = "btn_LoadFromFile";
            this.btn_LoadFromFile.Size = new System.Drawing.Size(175, 23);
            this.btn_LoadFromFile.TabIndex = 11;
            this.btn_LoadFromFile.Text = "Загрузить из файла";
            this.btn_LoadFromFile.UseVisualStyleBackColor = true;
            this.btn_LoadFromFile.Click += new System.EventHandler(this.btn_LoadFromFile_Click);
            // 
            // btn_ClearFileBuffer
            // 
            this.btn_ClearFileBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearFileBuffer.Location = new System.Drawing.Point(653, 407);
            this.btn_ClearFileBuffer.Name = "btn_ClearFileBuffer";
            this.btn_ClearFileBuffer.Size = new System.Drawing.Size(175, 52);
            this.btn_ClearFileBuffer.TabIndex = 12;
            this.btn_ClearFileBuffer.Text = "Очистить файловый буфер";
            this.btn_ClearFileBuffer.UseVisualStyleBackColor = true;
            this.btn_ClearFileBuffer.Click += new System.EventHandler(this.btn_ClearFileBuffer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 471);
            this.Controls.Add(this.btn_ClearFileBuffer);
            this.Controls.Add(this.btn_LoadFromFile);
            this.Controls.Add(this.btn_SaveToFile);
            this.Controls.Add(this.btn_ClearProgramBuffer);
            this.Controls.Add(this.btn_GenerateText);
            this.Controls.Add(this.txtbox_StringCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_toProgramBuffer);
            this.Controls.Add(this.btn_toFileBuffer);
            this.Controls.Add(this.richTxtBox_FileBuffer);
            this.Controls.Add(this.richTxtBox_ProgramBuffer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Перегонный аппарат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTxtBox_ProgramBuffer;
        private System.Windows.Forms.RichTextBox richTxtBox_FileBuffer;
        private System.Windows.Forms.Button btn_toFileBuffer;
        private System.Windows.Forms.Button btn_toProgramBuffer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_StringCount;
        private System.Windows.Forms.Button btn_GenerateText;
        private System.Windows.Forms.Button btn_ClearProgramBuffer;
        private System.Windows.Forms.Button btn_SaveToFile;
        private System.Windows.Forms.Button btn_LoadFromFile;
        private System.Windows.Forms.Button btn_ClearFileBuffer;
    }
}

