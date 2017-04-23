using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worker;
namespace WindowsFormsApplication1
{
    public partial class AddForm : Form
    {

        private IEmployeer _employeer;
        /// <summary>
        /// Создание,изменение элемента
        /// </summary>
        public IEmployeer Employeer
        {
            get
            {
                if (EmployeerOfSallaryComboBox.SelectedIndex == 0)
                {

                    var paymentOfSalary = new PaymentOfSalary
                    {
                        Name = Convert.ToString(NameTextbox.Text),
                        Surname = Convert.ToString(SurnameTextBox.Text),
                        Age = Convert.ToInt32(AgeTextBox.Text),
                        MonthCost = Convert.ToInt32(SalaryTextBox.Text),
                        Rate = Convert.ToDouble(RateTextBox.Text),
                        Experience = Convert.ToInt32(ExperienceTextBox.Text)
                    };
                    _employeer = paymentOfSalary;

                }
                else if (EmployeerOfSallaryComboBox.SelectedIndex == 1)
                {
                    var hourWorked = new HourEmployeer
                    {
                        Name = Convert.ToString(NameTextbox.Text),
                        Surname = Convert.ToString(SurnameTextBox.Text),
                        Age = Convert.ToInt32(AgeTextBox.Text),
                        HourCost = Convert.ToInt32(HourCostTextBox.Text),
                        HoursWorked = Convert.ToInt32(HourWorkedTextBox.Text)
                    };
                    _employeer = hourWorked;
                }
                return _employeer;
            }


            set
            {
                if (value is PaymentOfSalary)
                {
                    EmployeerOfSallaryComboBox.SelectedIndex = 0;
                    var empl = new PaymentOfSalary();

                    empl = (PaymentOfSalary)value;
                    NameTextbox.Text = empl.Name;
                    SurnameTextBox.Text = empl.Surname;
                    AgeTextBox.Text = Convert.ToString(empl.Age);
                    SalaryTextBox.Text = Convert.ToString(empl.MonthCost);
                    RateTextBox.Text = Convert.ToString(empl.Rate);
                    ExperienceTextBox.Text = Convert.ToString(empl.Experience);
                }
                else if (value is HourEmployeer)
                {

                }


            }

        }


        public AddForm()
        {
            InitializeComponent();


        }

        private void Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Selectandemployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}

