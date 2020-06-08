using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; 
using System.IO;

namespace File2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm //дезигн
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MetroStyleManager metroStyleManager1 = null; //графика метро
            this.StyleManager = metroStyleManager1; //графика метро

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1] == '\\') // удаляем хэш
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1); 
                while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

                }
            }
            else if (textBox1.Text[textBox1.Text.Length - 1] != '\\')
            {
                while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

                }
            }
        
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text); // путь дирректории отображается в текстбоксе
            DirectoryInfo[] dirs = dir.GetDirectories(); // Массив
            foreach (DirectoryInfo ssDir in dirs)
            {
                listBox1.Items.Add(ssDir); 
            }

            FileInfo[] files = dir.GetFiles(); // отображение файлов
           

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            {
                if (Path.GetExtension(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString())) == "") //открытие файла
                {
                    textBox1.Text = Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString());
                    listBox1.Items.Clear(); //типа очищает листбокс чтоб файлы новые показать
                    DirectoryInfo dir = new DirectoryInfo(textBox1.Text); // путь в текстбокс
                    DirectoryInfo[] dirs = dir.GetDirectories(); // массив
                    foreach (DirectoryInfo ssDir in dirs)
                    {
                        listBox1.Items.Add(ssDir); 
                    }

                    FileInfo[] files = dir.GetFiles(); 
                    foreach (FileInfo ssFile in files) // выводим файлы на экран
                    {
                        listBox1.Items.Add(ssFile);
                    }
                }
                else
                {
                    Process.Start(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString())); // Вывод
                }
            }
        }
    }
}