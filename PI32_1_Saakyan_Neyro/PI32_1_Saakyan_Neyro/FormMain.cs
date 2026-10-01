using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PI32_1_Saakyan_Neyro
{
    public partial class FormMain : Form
    {
        private double[] inputPixels; //массив входных данных
        public FormMain()
        {
            InitializeComponent();
            inputPixels = new double[15];//инициализируем массив при запуске программы
        }

        //обработчик события смены цвета кнопки при нажатии
        private void Change_color_button(object sender, EventArgs e)
        {
            //если кнопка белая
            if (((Button)sender).BackColor == Color.White)
            {
                ((Button)sender).BackColor = Color.Black;
                inputPixels[((Button)sender).TabIndex] = 1d;
            }
            //если кнопка черная
            else
            {
                ((Button)sender).BackColor = Color.White;
                inputPixels[((Button)sender).TabIndex]= 0d;
            }

        }

        //обработчик события добавления в файл обучения 
        private void buttonSaveTrainSample_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "train.txt"; 
            string tmpStr = numericUpDown_NecessaryOutput.Value.ToString();

            for (int i = 0; i < inputPixels.Length; i++)
            {
                tmpStr += " " + inputPixels[i].ToString();
            }
            tmpStr += "\n";

            File.AppendAllText(path, tmpStr);
            MessageBox.Show("успешно добавлено в обучение! train.txt");
        }

        //обработчик события добавления в файл теста
        private void buttonSaveTestSample_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "test.txt";
            string tmpStr = numericUpDown_NecessaryOutput.Value.ToString();

            for (int i = 0; i < inputPixels.Length; i++)
            {
                tmpStr += " " + inputPixels[i].ToString();
            }
            tmpStr += "\n";

            File.AppendAllText(path, tmpStr);
            MessageBox.Show("успешно добавлено в тест! test.txt");
        }



    }
}
