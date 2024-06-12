using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Lab2_7
{
    public partial class Form1 : Form
    {
        FileBuffer fileBuffer;

        public Form1()
        {
            fileBuffer = new FileBuffer("text");
            InitializeComponent();
        }

        private async void btn_GenerateText_Click(object sender, EventArgs e)
        {
            BlockProgramBufferUI();

            int strCount;
            if(int.TryParse(txtbox_StringCount.Text, out strCount))
            {
                string text = await ProgramBuffer.GenerateTextAsync(strCount);
                richTxtBox_ProgramBuffer.Text += text;
            }

            UnBlockProgramBufferUI();
        }

        // Загрузки/выгрузки
        private async void btn_LoadFromFile_Click(object sender, EventArgs e)
        {
            BlockFileBufferUI();

            richTxtBox_FileBuffer.Text = await fileBuffer.LoadAsync();

            UnBlockFileBufferUI();
        }

        private async void btn_SaveToFile_Click(object sender, EventArgs e)
        {
            BlockFileBufferUI();

            string fileBufferText = richTxtBox_FileBuffer.Text; // Чтобы избежать обращения к текстбоксу из другого потока
            await Task.Run(() => fileBuffer.Save(fileBufferText));

            UnBlockFileBufferUI();
        }

        //Очистки
        private void btn_ClearProgramBuffer_Click(object sender, EventArgs e)
        {
            richTxtBox_ProgramBuffer.Text = string.Empty;
        }

        private void btn_ClearFileBuffer_Click(object sender, EventArgs e)
        {
            richTxtBox_FileBuffer.Text = string.Empty;
        }

        //Перемещения
        private void btn_toFileBuffer_Click(object sender, EventArgs e)
        {
            richTxtBox_FileBuffer.Text += richTxtBox_ProgramBuffer.Text;
            richTxtBox_ProgramBuffer.Text = string.Empty;
        }

        private void btn_toProgramBuffer_Click(object sender, EventArgs e)
        {
            richTxtBox_ProgramBuffer.Text += richTxtBox_FileBuffer.Text;
            richTxtBox_FileBuffer.Text = string.Empty;
        }

        //Блокироваки частей интерфейса

        private void BlockProgramBufferUI()
        {
            richTxtBox_ProgramBuffer.Enabled = false;
            btn_ClearProgramBuffer.Enabled = false;
            btn_GenerateText.Enabled = false;
            txtbox_StringCount.Enabled = false;
        }

        private void UnBlockProgramBufferUI()
        {
            richTxtBox_ProgramBuffer.Enabled = true;
            btn_ClearProgramBuffer.Enabled = true;
            btn_GenerateText.Enabled = true;
            txtbox_StringCount.Enabled = true;
        }

        private void BlockFileBufferUI()
        {
            richTxtBox_FileBuffer.Enabled = false;
            btn_ClearFileBuffer.Enabled = false;
            btn_LoadFromFile.Enabled = false;
            btn_SaveToFile.Enabled = false;
        }
        private void UnBlockFileBufferUI()
        {
            richTxtBox_FileBuffer.Enabled = true;
            btn_ClearFileBuffer.Enabled = true;
            btn_LoadFromFile.Enabled = true;
            btn_SaveToFile.Enabled = true;
        }
    }
}
