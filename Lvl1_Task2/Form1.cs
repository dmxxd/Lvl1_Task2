using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lvl1_Task2
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSize.Text, out int n) && n > 0)
            {
                int[] array = new int[n];
                listBoxArray.Items.Clear();

                for (int i = 0; i < n; i++)
                {
                    array[i] = random.Next(1, 101);
                    listBoxArray.Items.Add($"array[{i}] = {array[i]}");
                }

                FindMinMax(array);
                btnCreate.Enabled = false;
                btnNewArray.Enabled = true;
            }
            else
            {
                MessageBox.Show("Введите корректное положительное число!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindMinMax(int[] array)
        {
            int max = array[0];
            int min = array[0];
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            lblMin.Text = $"Минимум: {min} (индекс {minIndex})";
            lblMax.Text = $"Максимум: {max} (индекс {maxIndex})";
        }

        private void btnNewArray_Click(object sender, EventArgs e)
        {
            txtSize.Clear();
            listBoxArray.Items.Clear();
            lblMin.Text = "Минимум:";
            lblMax.Text = "Максимум:";
            btnCreate.Enabled = true;
            btnNewArray.Enabled = false;
            txtSize.Focus();
        }
    }
}
