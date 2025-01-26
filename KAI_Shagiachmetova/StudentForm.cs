using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAI_Shagiachmetova
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kAI_ZilyaDataSet);

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kAI_ZilyaDataSet.Specialties". При необходимости она может быть перемещена или удалена.
            this.specialtiesTableAdapter.Fill(this.kAI_ZilyaDataSet.Specialties);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kAI_ZilyaDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.kAI_ZilyaDataSet.Students);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            studentsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            studentsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Validate();
            studentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(kAI_ZilyaDataSet);
            MessageBox.Show("Успешно сохранено!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
