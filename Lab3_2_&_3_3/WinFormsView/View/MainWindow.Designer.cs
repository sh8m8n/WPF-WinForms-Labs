namespace WinFormsView.View
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StudentsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.StudentsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsChart
            // 
            chartArea5.Name = "ChartArea1";
            this.StudentsChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.StudentsChart.Legends.Add(legend5);
            this.StudentsChart.Location = new System.Drawing.Point(432, 13);
            this.StudentsChart.Name = "StudentsChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.StudentsChart.Series.Add(series5);
            this.StudentsChart.Size = new System.Drawing.Size(356, 334);
            this.StudentsChart.TabIndex = 1;
            this.StudentsChart.Text = "chart1";
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(682, 381);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(106, 35);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "Добавить";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(559, 381);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(106, 35);
            this.Update_btn.TabIndex = 4;
            this.Update_btn.Text = "Изменить";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(432, 381);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(106, 35);
            this.Delete_btn.TabIndex = 5;
            this.Delete_btn.Text = "Удалить";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // StudentsDataGrid
            // 
            this.StudentsDataGrid.AllowUserToAddRows = false;
            this.StudentsDataGrid.AllowUserToDeleteRows = false;
            this.StudentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGrid.Location = new System.Drawing.Point(13, 13);
            this.StudentsDataGrid.Name = "StudentsDataGrid";
            this.StudentsDataGrid.ReadOnly = true;
            this.StudentsDataGrid.Size = new System.Drawing.Size(413, 425);
            this.StudentsDataGrid.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentsDataGrid);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.StudentsChart);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart StudentsChart;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.DataGridView StudentsDataGrid;
    }
}