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
                        label2.Text = "��� ������������ �� ��������: ��������������";
                    }
                    else if (textBox1.Text == textBox2.Text || textBox1.Text == textBox3.Text || textBox2.Text == textBox3.Text)
                    {
                        label2.Text = "��� ������������ �� ��������: ��������������";
                    }
                    else if (textBox1.Text != textBox2.Text && textBox1.Text != textBox3.Text && textBox2.Text != textBox3.Text)
                    {
                        label2.Text = "��� ������������ �� ��������: ��������������";
                    }

                    int P = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text);
                    label4.Text = "��������: " + P;

                    double p = P / 2;

                    double S = Math.Sqrt(p * (p - Convert.ToInt32(textBox1.Text)) * (p - Convert.ToInt32(textBox2.Text)) * (p - Convert.ToInt32(textBox3.Text)));
                    label5.Text = "�������: " + S;
                }
                else
                {
                    MessageBox.Show("������������ �� ����������!!!!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("�������� ������!");
            }
            catch (Exception)
            {
                MessageBox.Show("�������� ������!");
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

                    label10.Text = $"� ��������� ��� ��������� �����: {root1} � {root2}";
                }
                else if (discriminant == 0)
                {
                    double root = -b / (2 * a);

                    label10.Text = $"� ��������� ���� ������ (������ ��������� 2): {root}";
                }
                else
                {
                    label10.Text = "� ��������� ��� �������������� ������, ���� ��� ����������� �����.";
                }
            }
            catch (FormatException)
            {
                label10.Text = "������ ����� ������. ������� ���������� �������� ��������.";
            }
            catch (Exception ex)
            {
                label10.Text = $"��������� ������: {ex.Message}";
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
            MessageBox.Show("��������� �������� ������ ��5-21 �������� ������� � ������� ����������");

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
                label10.Text = "������ ����� ������. ������� ���������� �������� ��������.";
            }
            catch (Exception ex)
            {
                label10.Text = $"��������� ������: {ex.Message}";
            }


        }
        private double disck(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }
}
