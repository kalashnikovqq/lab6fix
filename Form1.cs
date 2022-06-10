using System;
using System.Windows.Forms;

namespace lab6fix
{
    public partial class Form1 : Form
    {
        double a, b, c, h, l, x, y, x0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_a.Text = "5";
            textBox_b.Text = "5";
            textBox_c.Text = "5";
            textBox_x.Text = "1";
            chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
            comboBox1.SelectedIndex = 0;
        }

        //Очистка графика
        private void ClearGraph()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Проверка ввода
            if (textBox_a.Text == "" || textBox_b.Text == "" || textBox_x.Text == "")
            {
                MessageBox.Show("Введите значения");
                return;
            }

            a = Convert.ToInt32(textBox_a.Text);
            b = Convert.ToInt32(textBox_b.Text);
            x = Convert.ToInt32(textBox_x.Text);
            h = 0.1;
            l = 2;
            x0 = 1;

            //y = x * a + b
            if (comboBox1.SelectedIndex == 0)
            {
                ClearGraph();
                y = x0 * a + b;
                chart1.Series[1].Points.AddXY(x0, y);
                while (x <= l)
                {
                    y = x * a + b;
                    chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            //y = a * sin(x*b) + c
            if (comboBox1.SelectedIndex == 1)
            {
                if (textBox_c.Text == "")
                {
                    MessageBox.Show("Введите значение C");
                }
                else
                {
                    c = Convert.ToDouble(textBox_c.Text);
                    ClearGraph();
                    y = a * Math.Sin(x0 * b) + c;
                    chart1.Series[1].Points.AddXY(x0, y);
                    while (x <= l)
                    {


                        y = a * Math.Sin(x * b) + c;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            //y = a * cos(x * b + c)
            if (comboBox1.SelectedIndex == 2)
            {
                if (textBox_c.Text == "")
                {
                    MessageBox.Show("Введите значение C");
                }
                else
                {
                    c = Convert.ToDouble(textBox_c.Text);
                    ClearGraph();
                    y = a * Math.Cos(x0 * b + c);
                    chart1.Series[1].Points.AddXY(x0, y);
                    while (x <= l)
                    {
                        y = a * Math.Cos(x * b + c);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            //y = a * tg(x * b) + c
            if (comboBox1.SelectedIndex == 3)
            {
                if (textBox_c.Text == "")
                {
                    MessageBox.Show("Введите значение C");
                }
                else
                {
                    c = Convert.ToDouble(textBox_c.Text);
                    ClearGraph();
                    y = a * Math.Tan(x0 * b) + c;
                    chart1.Series[1].Points.AddXY(x0, y);
                    while (x <= l)
                    {
                        y = a * Math.Tan(x * b) + c;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            //y = a * ctg(x * b + c)
            if (comboBox1.SelectedIndex == 4)
            {
                if (textBox_c.Text == "")
                {
                    MessageBox.Show("Введите значение C");
                }
                else
                {
                    c = Convert.ToDouble(textBox_c.Text);
                    ClearGraph();
                    y = a * (1 / Math.Tan(x0 * b + c));
                    chart1.Series[1].Points.AddXY(x0, y);
                    while (x <= l)
                    {
                        y = a * (1 / Math.Tan(x * b + c));
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            //y = b * x^a
            if (comboBox1.SelectedIndex == 5)
            {
                if (textBox_c.Text == "")
                {
                    MessageBox.Show("Введите значение C");
                }
                else
                {
                    c = Convert.ToDouble(textBox_c.Text);
                    ClearGraph();
                    y = b * Math.Pow(x0, a);
                    chart1.Series[1].Points.AddXY(x0, y);
                    while (x <= l)
                    {
                        y = b * Math.Pow(x, a);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            //y = a^(x + b)
            if (comboBox1.SelectedIndex == 6)
            {
                if (textBox_c.Text == "")
                {
                    MessageBox.Show("Введите значение C");
                }
                else
                {
                    c = Convert.ToDouble(textBox_c.Text);
                    ClearGraph();
                    y = Math.Pow(a, (x0 + b));
                    chart1.Series[1].Points.AddXY(x0, y);
                    while (x <= l)
                    {
                        y = Math.Pow(a, (x + b));
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            //y = ((sin(x) + a * x)/((x-(x)^1/2)+1))^b/x
            if (comboBox1.SelectedIndex == 7)
            {
                if (textBox_c.Text == "")
                {
                    MessageBox.Show("Введите значение C");
                }
                else
                {
                    c = Convert.ToDouble(textBox_c.Text);
                    ClearGraph();
                    y = Math.Pow(((Math.Sin(x0) + a * x0) / ((x0 - Math.Pow((x0), 1 / 2)) + 1)), b / x0);
                    chart1.Series[1].Points.AddXY(x0, y);
                    while (x <= l)
                    {
                        y = Math.Pow(((Math.Sin(x) + a * x) / ((x - Math.Pow((x), 1 / 2)) + 1)), b / x);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
        }
    }
}
