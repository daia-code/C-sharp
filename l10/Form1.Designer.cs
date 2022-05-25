namespace Contacte
{
    partial class FormContacte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContacte));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label companiaLabel;
            System.Windows.Forms.Label telefon_fixLabel;
            System.Windows.Forms.Label telefon_mobilLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label clientLabel;
            System.Windows.Forms.Label contactatLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.dBContacteDataSet = new Contacte.DBContacteDataSet();
            this.contactInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactInfoTableAdapter = new Contacte.DBContacteDataSetTableAdapters.ContactInfoTableAdapter();
            this.tableAdapterManager = new Contacte.DBContacteDataSetTableAdapters.TableAdapterManager();
            this.contactInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contactInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.companiaTextBox = new System.Windows.Forms.TextBox();
            this.telefon_fixTextBox = new System.Windows.Forms.TextBox();
            this.telefon_mobilTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.clientCheckBox = new System.Windows.Forms.CheckBox();
            this.contactatDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contactInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            companiaLabel = new System.Windows.Forms.Label();
            telefon_fixLabel = new System.Windows.Forms.Label();
            telefon_mobilLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            clientLabel = new System.Windows.Forms.Label();
            contactatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBContacteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoBindingNavigator)).BeginInit();
            this.contactInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contacte Firme";
            // 
            // dBContacteDataSet
            // 
            this.dBContacteDataSet.DataSetName = "DBContacteDataSet";
            this.dBContacteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactInfoBindingSource
            // 
            this.contactInfoBindingSource.DataMember = "ContactInfo";
            this.contactInfoBindingSource.DataSource = this.dBContacteDataSet;
            // 
            // contactInfoTableAdapter
            // 
            this.contactInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactInfoTableAdapter = this.contactInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Contacte.DBContacteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contactInfoBindingNavigator
            // 
            this.contactInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contactInfoBindingNavigator.BindingSource = this.contactInfoBindingSource;
            this.contactInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contactInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contactInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contactInfoBindingNavigatorSaveItem});
            this.contactInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contactInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contactInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contactInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contactInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contactInfoBindingNavigator.Name = "contactInfoBindingNavigator";
            this.contactInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contactInfoBindingNavigator.Size = new System.Drawing.Size(1143, 25);
            this.contactInfoBindingNavigator.TabIndex = 1;
            this.contactInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // contactInfoBindingNavigatorSaveItem
            // 
            this.contactInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactInfoBindingNavigatorSaveItem.Image")));
            this.contactInfoBindingNavigatorSaveItem.Name = "contactInfoBindingNavigatorSaveItem";
            this.contactInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.contactInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.contactInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.contactInfoBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(81, 98);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactInfoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(160, 95);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(81, 124);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(38, 13);
            numeLabel.TabIndex = 4;
            numeLabel.Text = "Nume:";
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactInfoBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(160, 121);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeTextBox.TabIndex = 5;
            // 
            // companiaLabel
            // 
            companiaLabel.AutoSize = true;
            companiaLabel.Location = new System.Drawing.Point(81, 150);
            companiaLabel.Name = "companiaLabel";
            companiaLabel.Size = new System.Drawing.Size(57, 13);
            companiaLabel.TabIndex = 6;
            companiaLabel.Text = "Compania:";
            // 
            // companiaTextBox
            // 
            this.companiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactInfoBindingSource, "Compania", true));
            this.companiaTextBox.Location = new System.Drawing.Point(160, 147);
            this.companiaTextBox.Name = "companiaTextBox";
            this.companiaTextBox.Size = new System.Drawing.Size(200, 20);
            this.companiaTextBox.TabIndex = 7;
            // 
            // telefon_fixLabel
            // 
            telefon_fixLabel.AutoSize = true;
            telefon_fixLabel.Location = new System.Drawing.Point(81, 176);
            telefon_fixLabel.Name = "telefon_fixLabel";
            telefon_fixLabel.Size = new System.Drawing.Size(59, 13);
            telefon_fixLabel.TabIndex = 8;
            telefon_fixLabel.Text = "Telefon fix:";
            // 
            // telefon_fixTextBox
            // 
            this.telefon_fixTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactInfoBindingSource, "Telefon fix", true));
            this.telefon_fixTextBox.Location = new System.Drawing.Point(160, 173);
            this.telefon_fixTextBox.Name = "telefon_fixTextBox";
            this.telefon_fixTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefon_fixTextBox.TabIndex = 9;
            // 
            // telefon_mobilLabel
            // 
            telefon_mobilLabel.AutoSize = true;
            telefon_mobilLabel.Location = new System.Drawing.Point(81, 202);
            telefon_mobilLabel.Name = "telefon_mobilLabel";
            telefon_mobilLabel.Size = new System.Drawing.Size(73, 13);
            telefon_mobilLabel.TabIndex = 10;
            telefon_mobilLabel.Text = "Telefon mobil:";
            // 
            // telefon_mobilTextBox
            // 
            this.telefon_mobilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactInfoBindingSource, "Telefon mobil", true));
            this.telefon_mobilTextBox.Location = new System.Drawing.Point(160, 199);
            this.telefon_mobilTextBox.Name = "telefon_mobilTextBox";
            this.telefon_mobilTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefon_mobilTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(81, 228);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactInfoBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(160, 225);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Location = new System.Drawing.Point(81, 256);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new System.Drawing.Size(36, 13);
            clientLabel.TabIndex = 14;
            clientLabel.Text = "Client:";
            // 
            // clientCheckBox
            // 
            this.clientCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contactInfoBindingSource, "Client", true));
            this.clientCheckBox.Location = new System.Drawing.Point(160, 251);
            this.clientCheckBox.Name = "clientCheckBox";
            this.clientCheckBox.Size = new System.Drawing.Size(200, 24);
            this.clientCheckBox.TabIndex = 15;
            this.clientCheckBox.Text = "checkBox1";
            this.clientCheckBox.UseVisualStyleBackColor = true;
            // 
            // contactatLabel
            // 
            contactatLabel.AutoSize = true;
            contactatLabel.Location = new System.Drawing.Point(81, 285);
            contactatLabel.Name = "contactatLabel";
            contactatLabel.Size = new System.Drawing.Size(56, 13);
            contactatLabel.TabIndex = 16;
            contactatLabel.Text = "Contactat:";
            // 
            // contactatDateTimePicker
            // 
            this.contactatDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contactInfoBindingSource, "Contactat", true));
            this.contactatDateTimePicker.Location = new System.Drawing.Point(160, 281);
            this.contactatDateTimePicker.Name = "contactatDateTimePicker";
            this.contactatDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.contactatDateTimePicker.TabIndex = 17;
            // 
            // contactInfoDataGridView
            // 
            this.contactInfoDataGridView.AutoGenerateColumns = false;
            this.contactInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.contactInfoDataGridView.DataSource = this.contactInfoBindingSource;
            this.contactInfoDataGridView.Location = new System.Drawing.Point(141, 376);
            this.contactInfoDataGridView.Name = "contactInfoDataGridView";
            this.contactInfoDataGridView.Size = new System.Drawing.Size(843, 135);
            this.contactInfoDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Compania";
            this.dataGridViewTextBoxColumn3.HeaderText = "Compania";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefon fix";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefon fix";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefon mobil";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefon mobil";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Client";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Client";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Contactat";
            this.dataGridViewTextBoxColumn7.HeaderText = "Contactat";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FormContacte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 624);
            this.Controls.Add(this.contactInfoDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(companiaLabel);
            this.Controls.Add(this.companiaTextBox);
            this.Controls.Add(telefon_fixLabel);
            this.Controls.Add(this.telefon_fixTextBox);
            this.Controls.Add(telefon_mobilLabel);
            this.Controls.Add(this.telefon_mobilTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(clientLabel);
            this.Controls.Add(this.clientCheckBox);
            this.Controls.Add(contactatLabel);
            this.Controls.Add(this.contactatDateTimePicker);
            this.Controls.Add(this.contactInfoBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "FormContacte";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormContacte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBContacteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoBindingNavigator)).EndInit();
            this.contactInfoBindingNavigator.ResumeLayout(false);
            this.contactInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DBContacteDataSet dBContacteDataSet;
        private System.Windows.Forms.BindingSource contactInfoBindingSource;
        private DBContacteDataSetTableAdapters.ContactInfoTableAdapter contactInfoTableAdapter;
        private DBContacteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contactInfoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contactInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox companiaTextBox;
        private System.Windows.Forms.TextBox telefon_fixTextBox;
        private System.Windows.Forms.TextBox telefon_mobilTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox clientCheckBox;
        private System.Windows.Forms.DateTimePicker contactatDateTimePicker;
        private System.Windows.Forms.DataGridView contactInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

