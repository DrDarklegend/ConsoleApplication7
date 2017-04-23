using Forms;
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
    public partial class MainForm : Form
    {
        private List<IEmployeer> Employers;
        public MainForm()
        {
            
            InitializeComponent();
            iEmployeerBindingSource.DataSource = Employers = new List<IEmployeer>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            var Form = new AddForm();

            if (Form.ShowDialog() == DialogResult.OK)
            {
                var employeer = Form.Employeer;
                iEmployeerBindingSource.Add(employeer);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {

            if (iEmployeerBindingSource.DataSource != null)
            {
                iEmployeerBindingSource.RemoveCurrent();

            }
            else
            {
                MessageBox.Show("Error. Empty file");
            }
        }



        private void Modify_Click(object sender, EventArgs e)

        {
            var form = new AddForm();
            int index = iEmployeerBindingSource.IndexOf(iEmployeerBindingSource.Current);
            form.Employeer = (IEmployeer)iEmployeerBindingSource.Current;

            if (form.ShowDialog() == DialogResult.OK)
            {
                iEmployeerBindingSource.RemoveAt(index);
                var empl = form.Employeer;
                iEmployeerBindingSource.Insert(index, empl);

            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Employers.Count != 0)
            {
                var ofd = new SaveFileDialog
                {
                    Filter = @"dat files (*.dat)|*.dat",
                    RestoreDirectory = true
                };
                if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
                {
                    Serialization.Serialize(ofd.FileName, Employers);
                }
            }
            else
            {
                MessageBox.Show(@"Error. File can't be empty");
            }
        }

        private void openAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
            {
                Employers = Serialization.Deserialize(ofd.FileName);
                iEmployeerBindingSource.DataSource = Employers;
            }
        }
        private void Random_Click(object sender, EventArgs e)
        {
            iEmployeerBindingSource.Add(new PaymentOfSalary ("Artur", "Kun", 22, 30000, 0.2, 15));
            iEmployeerBindingSource.Add(new HourEmployeer("Ivan", "Viderhspan",20, 155,155));

        }
    }
}