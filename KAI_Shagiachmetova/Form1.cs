﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CpecialitesForm cpecialitesForm = new CpecialitesForm();
            cpecialitesForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EvaluationsForm evaluationsForm = new EvaluationsForm();
            evaluationsForm.Show();
        }
    }
}
