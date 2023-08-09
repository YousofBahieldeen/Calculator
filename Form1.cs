using System.Runtime.InteropServices;
using System.Web;

namespace Calc_lesson_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            Result_OA.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_BN_Click(object sender, EventArgs e)
        {

        }

        private void Subtract_Click(object sender, EventArgs e)
        {

        }

        private void Multiplying_Click(object sender, EventArgs e)
        {

        }

        private void Dividing_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Adding Section
            if (selectedSign.SelectedItem.ToString() == "Add")
            {
                int firstNumber = int.Parse(firstNo.Text.ToString());
                int secondNumber = int.Parse(secondNo.Text.ToString());

                int totalAdded = firstNumber + secondNumber;
                Result_OA.Enabled = false;
                Result_OA.Text = totalAdded.ToString();

            }
            // Subtracting Section
            if (selectedSign.SelectedItem.ToString() == "Subtract")
            {

                int firstNumber = int.Parse(firstNo.Text.ToString());
                int secondNumber = int.Parse(secondNo.Text.ToString());

                int totalSubtracted = firstNumber - secondNumber;
                Result_OA.Enabled = false;
                Result_OA.Text = totalSubtracted.ToString();


            }
            // Multiplying Section
            if (selectedSign.SelectedItem.ToString() == "Multiply")
            {
                int firstNumber = int.Parse(firstNo.Text.ToString());
                int secondNumber = int.Parse(secondNo.Text.ToString());

                int totalMultiplyied = firstNumber * secondNumber;
                Result_OA.Enabled = false;
                Result_OA.Text = totalMultiplyied.ToString();


            }
            // Dividing Section
            if (selectedSign.SelectedItem.ToString() == "Divide")
            {
                int firstNumber = int.Parse(firstNo.Text.ToString());
                int secondNumber = int.Parse(secondNo.Text.ToString());

                float totalDivided = firstNumber / (float)secondNumber;
                Result_OA.Enabled = false;
                Result_OA.Text = totalDivided.ToString();


            }
        }

        private void Result_OA_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}