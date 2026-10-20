using System.Reflection.Emit;

namespace University_Admission
{
    public partial class Form1 : Form
    {
        string Age = "";
        string Grade = "";
        string Specialization = "";
        public Form1()
        {
            InitializeComponent();
            label6.Visible = false;
            label7.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Grade = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Age = textBox2.Text;

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Specialization = comboBox1.SelectedItem.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Grade != "")
            {
                int grade = Convert.ToInt32(Grade);
                if (grade < 0 || grade > 20)
                {
                    MessageBox.Show("You are not eligible for admission. Grade must be between 0 and 20.");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please enter your grade.");
                return;

            }

            if (Specialization == "")
            {
                MessageBox.Show("Please select a specialization.");
                return;
            }

            if (Age != "")
            {
                double age = Convert.ToDouble(Age);
                if (age < 18 || age > 30)
                {
                    MessageBox.Show("You are not eligible for admission. Age must be between 18 and 30.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter your age.");
                return;
            }


            label6.Visible = true;
            label7.Visible = true;

            if (Convert.ToInt32(Grade) >= 12 && Convert.ToInt32(Age) <= 25 && Specialization == "Computer Science")
            {
                label7.Text = "Grade : " + Grade + " \nAge :" + Age + "\nSpeciality :" + Specialization;
                label6.Text = "You are admitted!";
                label6.BackColor = Color.Green;
            }
            else
            {
                if (Convert.ToInt32(Grade) < 12)
                {
                    label7.Text = "Grade : " + Grade + " \nAge :" + Age + "\nSpeciality :" + Specialization;
                    label6.Text = "You are Rejected!";
                    label6.BackColor = Color.Red;
                }
                else
                {
                    label7.Text = "Grade : " + Grade + " \nAge :" + Age + "\nSpeciality :" + Specialization;
                    label6.Text = "You are in the Waiting List";
                    label6.BackColor = Color.Yellow;
                }
                if (Convert.ToInt32(Age) > 25 && Convert.ToInt32(Grade) >= 12)
                {
                    label7.Text = "Grade : " + Grade + " \nAge :" + Age + "\nSpeciality :" + Specialization;
                    label6.Text = "You are in the Waiting List \n( Due to Age )";
                    label6.BackColor = Color.Yellow;
                }
            }
        }
        
    }
}
