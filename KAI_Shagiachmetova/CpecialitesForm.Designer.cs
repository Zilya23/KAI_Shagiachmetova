
namespace KAI_Shagiachmetova
{
    partial class CpecialitesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CpecialitesForm));
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.kAI_ZilyaDataSet = new KAI_Shagiachmetova.KAI_ZilyaDataSet();
            this.specialtiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialtiesTableAdapter = new KAI_Shagiachmetova.KAI_ZilyaDataSetTableAdapters.SpecialtiesTableAdapter();
            this.tableAdapterManager = new KAI_Shagiachmetova.KAI_ZilyaDataSetTableAdapters.TableAdapterManager();
            this.specialtiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.specialtiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            titleLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kAI_ZilyaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingNavigator)).BeginInit();
            this.specialtiesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(140, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица \"Специальности\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kAI_ZilyaDataSet
            // 
            this.kAI_ZilyaDataSet.DataSetName = "KAI_ZilyaDataSet";
            this.kAI_ZilyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialtiesBindingSource
            // 
            this.specialtiesBindingSource.DataMember = "Specialties";
            this.specialtiesBindingSource.DataSource = this.kAI_ZilyaDataSet;
            // 
            // specialtiesTableAdapter
            // 
            this.specialtiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EvaluationsTableAdapter = null;
            this.tableAdapterManager.SpecialtiesTableAdapter = this.specialtiesTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KAI_Shagiachmetova.KAI_ZilyaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specialtiesBindingNavigator
            // 
            this.specialtiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.specialtiesBindingNavigator.BindingSource = this.specialtiesBindingSource;
            this.specialtiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.specialtiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.specialtiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.specialtiesBindingNavigatorSaveItem});
            this.specialtiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.specialtiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.specialtiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.specialtiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.specialtiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.specialtiesBindingNavigator.Name = "specialtiesBindingNavigator";
            this.specialtiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.specialtiesBindingNavigator.Size = new System.Drawing.Size(525, 25);
            this.specialtiesBindingNavigator.TabIndex = 2;
            this.specialtiesBindingNavigator.Text = "bindingNavigator1";
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
            // specialtiesBindingNavigatorSaveItem
            // 
            this.specialtiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.specialtiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("specialtiesBindingNavigatorSaveItem.Image")));
            this.specialtiesBindingNavigatorSaveItem.Name = "specialtiesBindingNavigatorSaveItem";
            this.specialtiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.specialtiesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.specialtiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.specialtiesBindingNavigatorSaveItem_Click);
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(29, 110);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(166, 13);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Наименование специальности:";
            titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialtiesBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(201, 107);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(273, 20);
            this.titleTextBox.TabIndex = 3;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(55, 161);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(140, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Описание специальности:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialtiesBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(201, 158);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(273, 20);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // CpecialitesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 236);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.specialtiesBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "CpecialitesForm";
            this.Text = "Таблица \"Специальности\"";
            this.Load += new System.EventHandler(this.CpecialitesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kAI_ZilyaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingNavigator)).EndInit();
            this.specialtiesBindingNavigator.ResumeLayout(false);
            this.specialtiesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private KAI_ZilyaDataSet kAI_ZilyaDataSet;
        private System.Windows.Forms.BindingSource specialtiesBindingSource;
        private KAI_ZilyaDataSetTableAdapters.SpecialtiesTableAdapter specialtiesTableAdapter;
        private KAI_ZilyaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator specialtiesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton specialtiesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}