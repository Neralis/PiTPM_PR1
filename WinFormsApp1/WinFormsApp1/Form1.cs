using System.Reflection.Metadata;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) > Convert.ToInt32(textBox3.Text) && Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) > Convert.ToInt32(textBox1.Text) && Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox3.Text) > Convert.ToInt32(textBox2.Text))
                {

                    if (textBox1.Text == textBox2.Text && textBox1.Text == textBox3.Text)
                    {
                        label2.Text = "Тип треугольника по сторонам: Равносторонний";
                    }
                    else if (textBox1.Text == textBox2.Text || textBox1.Text == textBox3.Text || textBox2.Text == textBox3.Text)
                    {
                        label2.Text = "Тип треугольника по сторонам: Равнобедренный";
                    }
                    else if (textBox1.Text != textBox2.Text && textBox1.Text != textBox3.Text && textBox2.Text != textBox3.Text)
                    {
                        label2.Text = "Тип треугольника по сторонам: Разносторонний";
                    }

                    int P = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text);
                    label4.Text = "Периметр: " + P;

                    double p = P / 2;

                    double S = Math.Sqrt(p * (p - Convert.ToInt32(textBox1.Text)) * (p - Convert.ToInt32(textBox2.Text)) * (p - Convert.ToInt32(textBox3.Text)));
                    label5.Text = "Площадь: " + S;
                }
                else
                {
                    MessageBox.Show("Треугольника НЕ СУЩЕСТВУЕТ!!!!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверные данные!");
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные данные!");
            }
        }

        private void buttonKor_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);

                double discriminant = disck(a, b, c);

                if (discriminant > 0)
                {
                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    label10.Text = $"У уравнения два различных корня: {root1} и {root2}";
                }
                else if (discriminant == 0)
                {
                    double root = -b / (2 * a);

                    label10.Text = $"У уравнения один корень (корень кратности 2): {root}";
                }
                else
                {
                    label10.Text = "У уравнения нет действительных корней, есть два комплексных корня.";
                }
            }
            catch (FormatException)
            {
                label10.Text = "Ошибка ввода данных. Введите корректные числовые значения.";
            }
            catch (Exception ex)
            {
                label10.Text = $"Произошла ошибка: {ex.Message}";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";

        }

        private void buttonFAQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнили студенты группы Ип5-21 Софронов Евгений и Никитин Константин");

        }
       
        private void buttonDis_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);

                double discriminant = disck(a, b, c);

                label11.Text = Convert.ToString(discriminant); 
               
            }
            catch (FormatException)
            {
                label10.Text = "Ошибка ввода данных. Введите корректные числовые значения.";
            }
            catch (Exception ex)
            {
                label10.Text = $"Произошла ошибка: {ex.Message}";
            }


        }
        private double disck(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }
}
