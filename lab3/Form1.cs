using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Resources.ResXFileRef;
using System.IO;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] bytesContent;
        long[] result;
        byte[] resultBytes;
        string ext;
        private void PrintText(TextBox textBox, byte[] bytes)
        {
            textBox.Text = "";
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                stringBuilder.Append(bytes[i]);
                stringBuilder.Append('\t');
            }
            textBox.Text += stringBuilder.ToString();
        }
        private string GetExtension(string fileName)
        {
            string ext = "";
            bool extFlag = false;
            for (int i = 0; i < fileName.Length; i++)
            {
                if (fileName[i] == '.')
                    extFlag = true;
                if (extFlag)
                    ext += fileName[i];
            }
            return ext;
        }

        private void button2_Click(object sender, EventArgs e) //импорт файла с любым расширением
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    byte[] fileContent = File.ReadAllBytes(filePath);
                    bytesContent = fileContent;
                    ext = GetExtension(openFileDialog.FileName);

                    PrintText(plainText, bytesContent);
                }
            }
        }

        private void PrintEncoded(TextBox textBox, long[] blocks, int left = 0, int right = 0)
        {// выводит первые left и последние right значений
            textBox.Text = "";
            for (int i = 0; i < left; i++)
            {
                textBox.Text += blocks[i] + "\t";
            }
            textBox.Text += "..." + "\t";
            for (int i = blocks.Length - right; i < blocks.Length; i++)
            {
                textBox.Text += blocks[i] + "\t";
            }
        }

        private string GetAllNums(long[] nums)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < nums.Length; i++)
            {
                stringBuilder.Append(nums[i] + "\t");
            }
            return stringBuilder.ToString();
        }

        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                bytes[i] = (byte)str[i];
            }
            return bytes;
        }

        private byte[] GetContentBytes(TextBox textBox)
        {
            {
                string[] contentStr = plainText.Text.Split(new string[] { "\t ", "\t", " "}, StringSplitOptions.RemoveEmptyEntries);

                byte[] content = new byte[contentStr.Length];
                for (int i = 0; i < content.Length; i++)
                {
                    content[i] = Convert.ToByte(contentStr[i]);
                }
                return content;
            }
            
        }

        private List<long> GetContentNums(TextBox textBox)
        {
            string[] contentStr = plainText.Text.Split(new string[] { "\t ", "\t", " " }, StringSplitOptions.RemoveEmptyEntries);

            List<long> content = new List<long>();
            for (int i = 0; i < contentStr.Count(); i++)
            {
                content.Add(Convert.ToInt64(contentStr[i]));
            }
            return content;
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            int p = int.Parse(PText.Text);
            int q = int.Parse(QText.Text);
            int b = int.Parse(BText.Text);
            long n = p * q;
            if (Rabin.CorrectNum(p) && Rabin.CorrectNum(q) && MathOperations.CheckPrime(p) && MathOperations.CheckPrime(q) && b < n && p > 255 && q > 255)
            {
                byte[] content = GetContentBytes(plainText);
                Rabin rabin = new Rabin(p, q, b, n, content);
                long[] result = rabin.GetEncoodedBytes();
                this.result = result;
                PrintEncoded(cipherText, result, 50, 50);
            }
            else
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK);
            }
        }


        private void exportButton_Click(object sender, EventArgs e)  // экспорт дефолтного файла

        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".enc файлы (*.*)|*.*";
            saveFileDialog.DefaultExt = ext;
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    File.WriteAllBytes(fileName, resultBytes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void importEnc_Click(object sender, EventArgs e) // импорт зашифрованного файла 
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileContent = File.ReadAllText(filePath);

                    plainText.Text = fileContent;
                }
            }
        }

        private void exportEnc_Click(object sender, EventArgs e) // экспорт зашифрованного файла
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".enc файлы (*.*)|*.*";
            string ext = ".enc";
            saveFileDialog.DefaultExt = ext;
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    File.WriteAllBytes(fileName, GetBytes(GetAllNums(result)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            int p = int.Parse(PText.Text);
            int q = int.Parse(QText.Text);
            int b = int.Parse(BText.Text);
            long n = p * q;
            if (Rabin.CorrectNum(p) && Rabin.CorrectNum(q) && MathOperations.CheckPrime(p) && MathOperations.CheckPrime(q) && b < n && p > 255 && q > 255)
            {
                List<long> blocks = GetContentNums(plainText);
                Rabin rabin = new Rabin(p, q, b, n, blocks);
                byte[] result = rabin.GetDecodedBytes();
                resultBytes = result;
                PrintText(cipherText, resultBytes);
            }
            else
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
