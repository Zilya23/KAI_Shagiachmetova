
namespace KAI_Shagiachmetova
{
    partial class EvaluationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluationsForm));
            System.Windows.Forms.Label iD_StudentLabel;
            System.Windows.Forms.Label date_Exam1Label;
            System.Windows.Forms.Label iD_Subjects1Label;
            System.Windows.Forms.Label evaluations1Label;
            System.Windows.Forms.Label date_Exam2Label;
            System.Windows.Forms.Label iD_Subjects2Label;
            System.Windows.Forms.Label evaluations2Label;
            System.Windows.Forms.Label average_ScoreLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.kAI_ZilyaDataSet = new KAI_Shagiachmetova.KAI_ZilyaDataSet();
            this.evaluationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluationsTableAdapter = new KAI_Shagiachmetova.KAI_ZilyaDataSetTableAdapters.EvaluationsTableAdapter();
            this.tableAdapterManager = new KAI_Shagiachmetova.KAI_ZilyaDataSetTableAdapters.TableAdapterManager();
            this.evaluationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.evaluationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_StudentTextBox = new System.Windows.Forms.TextBox();
            this.date_Exam1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_Subjects1TextBox = new System.Windows.Forms.TextBox();
            this.evaluations1TextBox = new System.Windows.Forms.TextBox();
            this.date_Exam2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_Subjects2TextBox = new System.Windows.Forms.TextBox();
            this.evaluations2TextBox = new System.Windows.Forms.TextBox();
            this.average_ScoreTextBox = new System.Windows.Forms.TextBox();
            iD_StudentLabel = new System.Windows.Forms.Label();
            date_Exam1Label = new System.Windows.Forms.Label();
            iD_Subjects1Label = new System.Windows.Forms.Label();
            evaluations1Label = new System.Windows.Forms.Label();
            date_Exam2Label = new System.Windows.Forms.Label();
            iD_Subjects2Label = new System.Windows.Forms.Label();
            evaluations2Label = new System.Windows.Forms.Label();
            average_ScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kAI_ZilyaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationsBindingNavigator)).BeginInit();
            this.evaluationsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(134, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица \"Оценки\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kAI_ZilyaDataSet
            // 
            this.kAI_ZilyaDataSet.DataSetName = "KAI_ZilyaDataSet";
            this.kAI_ZilyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evaluationsBindingSource
            // 
            this.evaluationsBindingSource.DataMember = "Evaluations";
            this.evaluationsBindingSource.DataSource = this.kAI_ZilyaDataSet;
            // 
            // evaluationsTableAdapter
            // 
            this.evaluationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EvaluationsTableAdapter = this.evaluationsTableAdapter;
            this.tableAdapterManager.SpecialtiesTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KAI_Shagiachmetova.KAI_ZilyaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // evaluationsBindingNavigator
            // 
            this.evaluationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.evaluationsBindingNavigator.BindingSource = this.evaluationsBindingSource;
            this.evaluationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.evaluationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.evaluationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.evaluationsBindingNavigatorSaveItem});
            this.evaluationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.evaluationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.evaluationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.evaluationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.evaluationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.evaluationsBindingNavigator.Name = "evaluationsBindingNavigator";
            this.evaluationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.evaluationsBindingNavigator.Size = new System.Drawing.Size(501, 25);
            this.evaluationsBindingNavigator.TabIndex = 4;
            this.evaluationsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // evaluationsBindingNavigatorSaveItem
            // 
            this.evaluationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.evaluationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("evaluationsBindingNavigatorSaveItem.Image")));
            this.evaluationsBindingNavigatorSaveItem.Name = "evaluationsBindingNavigatorSaveItem";
            this.evaluationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.evaluationsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.evaluationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.evaluationsBindingNavigatorSaveItem_Click);
            // 
            // iD_StudentLabel
            // 
            iD_StudentLabel.AutoSize = true;
            iD_StudentLabel.Location = new System.Drawing.Point(121, 109);
            iD_StudentLabel.Name = "iD_StudentLabel";
            iD_StudentLabel.Size = new System.Drawing.Size(77, 13);
            iD_StudentLabel.TabIndex = 4;
            iD_StudentLabel.Text = "Код студента:";
            iD_StudentLabel.Click += new System.EventHandler(this.iD_StudentLabel_Click);
            // 
            // iD_StudentTextBox
            // 
            this.iD_StudentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evaluationsBindingSource, "ID_Student", true));
            this.iD_StudentTextBox.Location = new System.Drawing.Point(204, 106);
            this.iD_StudentTextBox.Name = "iD_StudentTextBox";
            this.iD_StudentTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_StudentTextBox.TabIndex = 5;
            // 
            // date_Exam1Label
            // 
            date_Exam1Label.AutoSize = true;
            date_Exam1Label.Location = new System.Drawing.Point(100, 132);
            date_Exam1Label.Name = "date_Exam1Label";
            date_Exam1Label.Size = new System.Drawing.Size(98, 13);
            date_Exam1Label.TabIndex = 5;
            date_Exam1Label.Text = "Дата экзамена 1:";
            // 
            // date_Exam1DateTimePicker
            // 
            this.date_Exam1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.evaluationsBindingSource, "Date_Exam1", true));
            this.date_Exam1DateTimePicker.Location = new System.Drawing.Point(204, 132);
            this.date_Exam1DateTimePicker.Name = "date_Exam1DateTimePicker";
            this.date_Exam1DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_Exam1DateTimePicker.TabIndex = 6;
            // 
            // iD_Subjects1Label
            // 
            iD_Subjects1Label.AutoSize = true;
            iD_Subjects1Label.Location = new System.Drawing.Point(107, 158);
            iD_Subjects1Label.Name = "iD_Subjects1Label";
            iD_Subjects1Label.Size = new System.Drawing.Size(90, 13);
            iD_Subjects1Label.TabIndex = 6;
            iD_Subjects1Label.Text = "Код предмета 1:";
            // 
            // iD_Subjects1TextBox
            // 
            this.iD_Subjects1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evaluationsBindingSource, "ID_Subjects1", true));
            this.iD_Subjects1TextBox.Location = new System.Drawing.Point(204, 158);
            this.iD_Subjects1TextBox.Name = "iD_Subjects1TextBox";
            this.iD_Subjects1TextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_Subjects1TextBox.TabIndex = 7;
            // 
            // evaluations1Label
            // 
            evaluations1Label.AutoSize = true;
            evaluations1Label.Location = new System.Drawing.Point(140, 187);
            evaluations1Label.Name = "evaluations1Label";
            evaluations1Label.Size = new System.Drawing.Size(57, 13);
            evaluations1Label.TabIndex = 8;
            evaluations1Label.Text = "Оценка 1:";
            // 
            // evaluations1TextBox
            // 
            this.evaluations1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evaluationsBindingSource, "Evaluations1", true));
            this.evaluations1TextBox.Location = new System.Drawing.Point(204, 184);
            this.evaluations1TextBox.Name = "evaluations1TextBox";
            this.evaluations1TextBox.Size = new System.Drawing.Size(200, 20);
            this.evaluations1TextBox.TabIndex = 9;
            // 
            // date_Exam2Label
            // 
            date_Exam2Label.AutoSize = true;
            date_Exam2Label.Location = new System.Drawing.Point(100, 216);
            date_Exam2Label.Name = "date_Exam2Label";
            date_Exam2Label.Size = new System.Drawing.Size(98, 13);
            date_Exam2Label.TabIndex = 10;
            date_Exam2Label.Text = "Дата экзамена 2:";
            // 
            // date_Exam2DateTimePicker
            // 
            this.date_Exam2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.evaluationsBindingSource, "Date_Exam2", true));
            this.date_Exam2DateTimePicker.Location = new System.Drawing.Point(204, 210);
            this.date_Exam2DateTimePicker.Name = "date_Exam2DateTimePicker";
            this.date_Exam2DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_Exam2DateTimePicker.TabIndex = 11;
            // 
            // iD_Subjects2Label
            // 
            iD_Subjects2Label.AutoSize = true;
            iD_Subjects2Label.Location = new System.Drawing.Point(108, 239);
            iD_Subjects2Label.Name = "iD_Subjects2Label";
            iD_Subjects2Label.Size = new System.Drawing.Size(90, 13);
            iD_Subjects2Label.TabIndex = 12;
            iD_Subjects2Label.Text = "Код предмета 2:";
            // 
            // iD_Subjects2TextBox
            // 
            this.iD_Subjects2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evaluationsBindingSource, "ID_Subjects2", true));
            this.iD_Subjects2TextBox.Location = new System.Drawing.Point(204, 236);
            this.iD_Subjects2TextBox.Name = "iD_Subjects2TextBox";
            this.iD_Subjects2TextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_Subjects2TextBox.TabIndex = 13;
            // 
            // evaluations2Label
            // 
            evaluations2Label.AutoSize = true;
            evaluations2Label.Location = new System.Drawing.Point(140, 265);
            evaluations2Label.Name = "evaluations2Label";
            evaluations2Label.Size = new System.Drawing.Size(57, 13);
            evaluations2Label.TabIndex = 14;
            evaluations2Label.Text = "Оценка 2:";
            // 
            // evaluations2TextBox
            // 
            this.evaluations2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evaluationsBindingSource, "Evaluations2", true));
            this.evaluations2TextBox.Location = new System.Drawing.Point(204, 262);
            this.evaluations2TextBox.Name = "evaluations2TextBox";
            this.evaluations2TextBox.Size = new System.Drawing.Size(200, 20);
            this.evaluations2TextBox.TabIndex = 15;
            // 
            // average_ScoreLabel
            // 
            average_ScoreLabel.AutoSize = true;
            average_ScoreLabel.Location = new System.Drawing.Point(118, 291);
            average_ScoreLabel.Name = "average_ScoreLabel";
            average_ScoreLabel.Size = new System.Drawing.Size(80, 13);
            average_ScoreLabel.TabIndex = 16;
            average_ScoreLabel.Text = "Средний балл:";
            // 
            // average_ScoreTextBox
            // 
            this.average_ScoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evaluationsBindingSource, "Average_Score", true));
            this.average_ScoreTextBox.Location = new System.Drawing.Point(204, 288);
            this.average_ScoreTextBox.Name = "average_ScoreTextBox";
            this.average_ScoreTextBox.Size = new System.Drawing.Size(200, 20);
            this.average_ScoreTextBox.TabIndex = 17;
            // 
            // EvaluationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 399);
            this.Controls.Add(average_ScoreLabel);
            this.Controls.Add(this.average_ScoreTextBox);
            this.Controls.Add(evaluations2Label);
            this.Controls.Add(this.evaluations2TextBox);
            this.Controls.Add(iD_Subjects2Label);
            this.Controls.Add(this.iD_Subjects2TextBox);
            this.Controls.Add(date_Exam2Label);
            this.Controls.Add(this.date_Exam2DateTimePicker);
            this.Controls.Add(evaluations1Label);
            this.Controls.Add(this.evaluations1TextBox);
            this.Controls.Add(iD_Subjects1Label);
            this.Controls.Add(this.iD_Subjects1TextBox);
            this.Controls.Add(date_Exam1Label);
            this.Controls.Add(this.date_Exam1DateTimePicker);
            this.Controls.Add(iD_StudentLabel);
            this.Controls.Add(this.iD_StudentTextBox);
            this.Controls.Add(this.evaluationsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "EvaluationsForm";
            this.Text = "Таблица \"Оценки\"";
            this.Load += new System.EventHandler(this.EvaluationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kAI_ZilyaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationsBindingNavigator)).EndInit();
            this.evaluationsBindingNavigator.ResumeLayout(false);
            this.evaluationsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private KAI_ZilyaDataSet kAI_ZilyaDataSet;
        private System.Windows.Forms.BindingSource evaluationsBindingSource;
        private KAI_ZilyaDataSetTableAdapters.EvaluationsTableAdapter evaluationsTableAdapter;
        private KAI_ZilyaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator evaluationsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton evaluationsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_StudentTextBox;
        private System.Windows.Forms.DateTimePicker date_Exam1DateTimePicker;
        private System.Windows.Forms.TextBox iD_Subjects1TextBox;
        private System.Windows.Forms.TextBox evaluations1TextBox;
        private System.Windows.Forms.DateTimePicker date_Exam2DateTimePicker;
        private System.Windows.Forms.TextBox iD_Subjects2TextBox;
        private System.Windows.Forms.TextBox evaluations2TextBox;
        private System.Windows.Forms.TextBox average_ScoreTextBox;
    }
}