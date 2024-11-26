namespace WinFormsUI.Views
{
    partial class MainWindowView
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
            StudentsDataGrid = new DataGridView();
            Chart_txtBox = new RichTextBox();
            Delete_btn = new Button();
            Update_btn = new Button();
            Add_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // StudentsDataGrid
            // 
            StudentsDataGrid.AllowUserToAddRows = false;
            StudentsDataGrid.AllowUserToDeleteRows = false;
            StudentsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsDataGrid.Location = new Point(12, 12);
            StudentsDataGrid.Name = "StudentsDataGrid";
            StudentsDataGrid.ReadOnly = true;
            StudentsDataGrid.Size = new Size(424, 420);
            StudentsDataGrid.TabIndex = 0;
            // 
            // Chart_txtBox
            // 
            Chart_txtBox.Location = new Point(442, 12);
            Chart_txtBox.Name = "Chart_txtBox";
            Chart_txtBox.Size = new Size(346, 320);
            Chart_txtBox.TabIndex = 1;
            Chart_txtBox.Text = "";
            // 
            // Delete_btn
            // 
            Delete_btn.Location = new Point(442, 363);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(102, 47);
            Delete_btn.TabIndex = 2;
            Delete_btn.Text = "Удалить";
            Delete_btn.UseVisualStyleBackColor = true;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Update_btn
            // 
            Update_btn.Location = new Point(565, 363);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(102, 47);
            Update_btn.TabIndex = 3;
            Update_btn.Text = "Изменить";
            Update_btn.UseVisualStyleBackColor = true;
            Update_btn.Click += Update_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.Location = new Point(687, 363);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(102, 47);
            Add_btn.TabIndex = 4;
            Add_btn.Text = "Добавить";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // MainWindowView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Add_btn);
            Controls.Add(Update_btn);
            Controls.Add(Delete_btn);
            Controls.Add(Chart_txtBox);
            Controls.Add(StudentsDataGrid);
            Name = "MainWindowView";
            Text = "MainWindowView";
            ((System.ComponentModel.ISupportInitialize)StudentsDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView StudentsDataGrid;
        private RichTextBox Chart_txtBox;
        private Button Delete_btn;
        private Button Update_btn;
        private Button Add_btn;
    }
}