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
    public partial class CpecialitesForm : Form
    {
        public CpecialitesForm()
        {
            InitializeComponent();
        }

        private void specialtiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specialtiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kAI_ZilyaDataSet);

        }

        private void CpecialitesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kAI_ZilyaDataSet.Specialties". При необходимости она может быть перемещена или удалена.
            this.specialtiesTableAdapter.Fill(this.kAI_ZilyaDataSet.Specialties);

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
