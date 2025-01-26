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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kAI_ZilyaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kAI_ZilyaDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.kAI_ZilyaDataSet.Students);

        }

        private void studentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = dataGridViewTextBoxColumn2;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    ;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn6;
                    break;
                case 5:
                    Col = dataGridViewTextBoxColumn7;
                    break;
                case 6:
                    Col = dataGridViewTextBoxColumn8;
                    break;
                case 7:
                    Col = dataGridViewTextBoxColumn9;
                    break;
                case 8:
                    Col = dataGridViewTextBoxColumn10;
                    break;
                case 9:
                    Col = dataGridViewTextBoxColumn11;
                    break;
                case 10:
                    Col = dataGridViewTextBoxColumn12;
                    break;
            }

            if (radioButton1.Checked)
            {
                studentsDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                studentsDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentsBindingSource.Filter = "ФИО='" + comboBox1.Text + "'";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            studentsBindingSource.Filter = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i< studentsDataGridView.ColumnCount; i++)
                for (int j = 0; j < studentsDataGridView.RowCount; j++)
                {
                    studentsDataGridView[i, j].Style.BackColor = Color.White;
                    studentsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i=0; i<studentsDataGridView.ColumnCount; i++)
                for(int j =0; j<studentsDataGridView.RowCount - 1; j++)
                    if(studentsDataGridView[i,j].Value.ToString().Contains(textBox1.Text.Trim()))
                    {
                        studentsDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        studentsDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
