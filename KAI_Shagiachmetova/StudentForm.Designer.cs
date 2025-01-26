
namespace KAI_Shagiachmetova
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label date_Of_BirthLabel;
            System.Windows.Forms.Label parentsLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label pasport_numLabel;
            System.Windows.Forms.Label credit_Card_NumberLabel;
            System.Windows.Forms.Label date_Of_ReceiptLabel;
            System.Windows.Forms.Label groupLabel;
            System.Windows.Forms.Label courseLabel;
            System.Windows.Forms.Label iD_SpecialtiesLabel;
            System.Windows.Forms.Label full_Time_EducationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.kAI_ZilyaDataSet = new KAI_Shagiachmetova.KAI_ZilyaDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new KAI_Shagiachmetova.KAI_ZilyaDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new KAI_Shagiachmetova.KAI_ZilyaDataSetTableAdapters.TableAdapterManager();
            this.specialtiesTableAdapter = new KAI_Shagiachmetova.KAI_ZilyaDataSetTableAdapters.SpecialtiesTableAdapter();
            this.studentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.date_Of_ReceiptDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.full_Time_EducationCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.courseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.parentsComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.specialtiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button8 = new System.Windows.Forms.Button();
            fIOLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            date_Of_BirthLabel = new System.Windows.Forms.Label();
            parentsLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            pasport_numLabel = new System.Windows.Forms.Label();
            credit_Card_NumberLabel = new System.Windows.Forms.Label();
            date_Of_ReceiptLabel = new System.Windows.Forms.Label();
            groupLabel = new System.Windows.Forms.Label();
            courseLabel = new System.Windows.Forms.Label();
            iD_SpecialtiesLabel = new System.Windows.Forms.Label();
            full_Time_EducationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kAI_ZilyaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).BeginInit();
            this.studentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(295, 102);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(37, 13);
            fIOLabel.TabIndex = 3;
            fIOLabel.Text = "ФИО:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(302, 138);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(30, 13);
            genderLabel.TabIndex = 4;
            genderLabel.Text = "Пол:";
            // 
            // date_Of_BirthLabel
            // 
            date_Of_BirthLabel.AutoSize = true;
            date_Of_BirthLabel.Location = new System.Drawing.Point(243, 167);
            date_Of_BirthLabel.Name = "date_Of_BirthLabel";
            date_Of_BirthLabel.Size = new System.Drawing.Size(89, 13);
            date_Of_BirthLabel.TabIndex = 6;
            date_Of_BirthLabel.Text = "Дата рождения:";
            // 
            // parentsLabel
            // 
            parentsLabel.AutoSize = true;
            parentsLabel.Location = new System.Drawing.Point(274, 196);
            parentsLabel.Name = "parentsLabel";
            parentsLabel.Size = new System.Drawing.Size(58, 13);
            parentsLabel.TabIndex = 8;
            parentsLabel.Text = "Родители:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(291, 225);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(41, 13);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "Адрес:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(277, 251);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 13);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Телефон:";
            // 
            // pasport_numLabel
            // 
            pasport_numLabel.AutoSize = true;
            pasport_numLabel.Location = new System.Drawing.Point(218, 277);
            pasport_numLabel.Name = "pasport_numLabel";
            pasport_numLabel.Size = new System.Drawing.Size(114, 13);
            pasport_numLabel.TabIndex = 14;
            pasport_numLabel.Text = "Паспортные данные:";
            // 
            // credit_Card_NumberLabel
            // 
            credit_Card_NumberLabel.AutoSize = true;
            credit_Card_NumberLabel.Location = new System.Drawing.Point(245, 303);
            credit_Card_NumberLabel.Name = "credit_Card_NumberLabel";
            credit_Card_NumberLabel.Size = new System.Drawing.Size(87, 13);
            credit_Card_NumberLabel.TabIndex = 16;
            credit_Card_NumberLabel.Text = "Номер зачетки:";
            // 
            // date_Of_ReceiptLabel
            // 
            date_Of_ReceiptLabel.AutoSize = true;
            date_Of_ReceiptLabel.Location = new System.Drawing.Point(229, 332);
            date_Of_ReceiptLabel.Name = "date_Of_ReceiptLabel";
            date_Of_ReceiptLabel.Size = new System.Drawing.Size(103, 13);
            date_Of_ReceiptLabel.TabIndex = 18;
            date_Of_ReceiptLabel.Text = "Дата поступления:";
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new System.Drawing.Point(287, 353);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(45, 13);
            groupLabel.TabIndex = 20;
            groupLabel.Text = "Группа:";
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Location = new System.Drawing.Point(295, 382);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new System.Drawing.Size(34, 13);
            courseLabel.TabIndex = 22;
            courseLabel.Text = "Курс:";
            // 
            // iD_SpecialtiesLabel
            // 
            iD_SpecialtiesLabel.AutoSize = true;
            iD_SpecialtiesLabel.Location = new System.Drawing.Point(220, 405);
            iD_SpecialtiesLabel.Name = "iD_SpecialtiesLabel";
            iD_SpecialtiesLabel.Size = new System.Drawing.Size(109, 13);
            iD_SpecialtiesLabel.TabIndex = 24;
            iD_SpecialtiesLabel.Text = "Код специальности:";
            // 
            // full_Time_EducationLabel
            // 
            full_Time_EducationLabel.AutoSize = true;
            full_Time_EducationLabel.Location = new System.Drawing.Point(202, 436);
            full_Time_EducationLabel.Name = "full_Time_EducationLabel";
            full_Time_EducationLabel.Size = new System.Drawing.Size(127, 13);
            full_Time_EducationLabel.TabIndex = 26;
            full_Time_EducationLabel.Text = "Очная форма обучения:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(263, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица \"Студенты\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kAI_ZilyaDataSet
            // 
            this.kAI_ZilyaDataSet.DataSetName = "KAI_ZilyaDataSet";
            this.kAI_ZilyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.kAI_ZilyaDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EvaluationsTableAdapter = null;
            this.tableAdapterManager.SpecialtiesTableAdapter = this.specialtiesTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KAI_Shagiachmetova.KAI_ZilyaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specialtiesTableAdapter
            // 
            this.specialtiesTableAdapter.ClearBeforeFill = true;
            // 
            // studentsBindingNavigator
            // 
            this.studentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentsBindingNavigator.BindingSource = this.studentsBindingSource;
            this.studentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentsBindingNavigatorSaveItem});
            this.studentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentsBindingNavigator.Name = "studentsBindingNavigator";
            this.studentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.studentsBindingNavigator.TabIndex = 3;
            this.studentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // studentsBindingNavigatorSaveItem
            // 
            this.studentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsBindingNavigatorSaveItem.Image")));
            this.studentsBindingNavigatorSaveItem.Name = "studentsBindingNavigatorSaveItem";
            this.studentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.studentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentsBindingNavigatorSaveItem_Click);
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(340, 99);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(240, 20);
            this.fIOTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(340, 222);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(240, 20);
            this.addressTextBox.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(340, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // date_Of_ReceiptDateTimePicker
            // 
            this.date_Of_ReceiptDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsBindingSource, "Date_Of_Receipt", true));
            this.date_Of_ReceiptDateTimePicker.Location = new System.Drawing.Point(340, 326);
            this.date_Of_ReceiptDateTimePicker.Name = "date_Of_ReceiptDateTimePicker";
            this.date_Of_ReceiptDateTimePicker.Size = new System.Drawing.Size(240, 20);
            this.date_Of_ReceiptDateTimePicker.TabIndex = 19;
            // 
            // groupTextBox
            // 
            this.groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Group", true));
            this.groupTextBox.Location = new System.Drawing.Point(340, 353);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(240, 20);
            this.groupTextBox.TabIndex = 21;
            // 
            // full_Time_EducationCheckBox
            // 
            this.full_Time_EducationCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.studentsBindingSource, "Full_Time_Education", true));
            this.full_Time_EducationCheckBox.Location = new System.Drawing.Point(340, 431);
            this.full_Time_EducationCheckBox.Name = "full_Time_EducationCheckBox";
            this.full_Time_EducationCheckBox.Size = new System.Drawing.Size(104, 24);
            this.full_Time_EducationCheckBox.TabIndex = 27;
            this.full_Time_EducationCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(525, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(424, 501);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(324, 501);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "Последняя";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(424, 530);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 34;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(340, 251);
            this.maskedTextBox1.Mask = "+7 (999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(240, 20);
            this.maskedTextBox1.TabIndex = 35;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(340, 277);
            this.maskedTextBox2.Mask = "0000-000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(240, 20);
            this.maskedTextBox2.TabIndex = 36;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(340, 300);
            this.maskedTextBox3.Mask = "00000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(240, 20);
            this.maskedTextBox3.TabIndex = 37;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // courseNumericUpDown
            // 
            this.courseNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsBindingSource, "Course", true));
            this.courseNumericUpDown.Location = new System.Drawing.Point(340, 379);
            this.courseNumericUpDown.Name = "courseNumericUpDown";
            this.courseNumericUpDown.Size = new System.Drawing.Size(240, 20);
            this.courseNumericUpDown.TabIndex = 38;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.genderComboBox.Location = new System.Drawing.Point(340, 135);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(240, 21);
            this.genderComboBox.TabIndex = 39;
            // 
            // parentsComboBox
            // 
            this.parentsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Parents", true));
            this.parentsComboBox.FormattingEnabled = true;
            this.parentsComboBox.Items.AddRange(new object[] {
            "Отец и Мать",
            "Отец",
            "Мать",
            "Опекун",
            "Нет"});
            this.parentsComboBox.Location = new System.Drawing.Point(340, 193);
            this.parentsComboBox.Name = "parentsComboBox";
            this.parentsComboBox.Size = new System.Drawing.Size(240, 21);
            this.parentsComboBox.TabIndex = 40;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentsBindingSource, "ID_Specialties", true));
            this.comboBox1.DataSource = this.specialtiesBindingSource;
            this.comboBox1.DisplayMember = "Title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(340, 406);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.ValueMember = "ID_Specialties";
            // 
            // specialtiesBindingSource
            // 
            this.specialtiesBindingSource.DataMember = "Specialties";
            this.specialtiesBindingSource.DataSource = this.kAI_ZilyaDataSet;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(324, 530);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 42;
            this.button8.Text = "Таблица";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.parentsComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.courseNumericUpDown);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(full_Time_EducationLabel);
            this.Controls.Add(this.full_Time_EducationCheckBox);
            this.Controls.Add(iD_SpecialtiesLabel);
            this.Controls.Add(courseLabel);
            this.Controls.Add(groupLabel);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(date_Of_ReceiptLabel);
            this.Controls.Add(this.date_Of_ReceiptDateTimePicker);
            this.Controls.Add(credit_Card_NumberLabel);
            this.Controls.Add(pasport_numLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(parentsLabel);
            this.Controls.Add(date_Of_BirthLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(genderLabel);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(this.studentsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "Таблица \"Студенты\"";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kAI_ZilyaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).EndInit();
            this.studentsBindingNavigator.ResumeLayout(false);
            this.studentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private KAI_ZilyaDataSet kAI_ZilyaDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private KAI_ZilyaDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private KAI_ZilyaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker date_Of_ReceiptDateTimePicker;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.CheckBox full_Time_EducationCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private KAI_ZilyaDataSetTableAdapters.SpecialtiesTableAdapter specialtiesTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.NumericUpDown courseNumericUpDown;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox parentsComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource specialtiesBindingSource;
        private System.Windows.Forms.Button button8;
    }
}