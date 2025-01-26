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
    public partial class EvaluationsForm : Form
    {
        public EvaluationsForm()
        {
            InitializeComponent();
        }

        private void evaluationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.evaluationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kAI_ZilyaDataSet);

        }

        private void EvaluationsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kAI_ZilyaDataSet.Evaluations". При необходимости она может быть перемещена или удалена.
            this.evaluationsTableAdapter.Fill(this.kAI_ZilyaDataSet.Evaluations);

        }

        private void iD_StudentLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
