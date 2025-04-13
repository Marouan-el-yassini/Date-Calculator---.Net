using System.Windows.Forms;

namespace DateNaissance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClientDate_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
                if (dateTimePicker1.Value < dateTimePicker2.Value)
                {
                    MessageBox.Show("Invalide");
                }
                else
                {
                    MessageBox.Show("Valide");
                    int years = dateTimePicker1.Value.Year - dateTimePicker2.Value.Year;
                    int months = dateTimePicker1.Value.Month - dateTimePicker2.Value.Month;
                    int day = dateTimePicker1.Value.Day - dateTimePicker2.Value.Day;
                if (day < 0)
                {
                    day += DateTime.DaysInMonth(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month-1);
                    months--;
                }
                if (months < 0)
                {
                    months += 12;
                    years--;
                }
                MessageBox.Show($"Vous avez {years} ans, {months} mois et {day} jours.");
            }
            
        }
    }
}
