namespace FTP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.дАТАБАСЕ21DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дАТАБАСЕ21DataSet = new FTP.ДАТАБАСЕ21DataSet();
            this.зарплатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.зарплатаTableAdapter = new FTP.ДАТАБАСЕ21DataSetTableAdapters.ЗарплатаTableAdapter();
            this.iDЗарплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПолученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ктоПолучилDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типЗарплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дАТАБАСЕ21DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дАТАБАСЕ21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зарплатаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗарплатаDataGridViewTextBoxColumn,
            this.датаПолученияDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.ктоПолучилDataGridViewTextBoxColumn,
            this.типЗарплатыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.зарплатаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(753, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // дАТАБАСЕ21DataSetBindingSource
            // 
            this.дАТАБАСЕ21DataSetBindingSource.DataSource = this.дАТАБАСЕ21DataSet;
            this.дАТАБАСЕ21DataSetBindingSource.Position = 0;
            // 
            // дАТАБАСЕ21DataSet
            // 
            this.дАТАБАСЕ21DataSet.DataSetName = "ДАТАБАСЕ21DataSet";
            this.дАТАБАСЕ21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // зарплатаBindingSource
            // 
            this.зарплатаBindingSource.DataMember = "Зарплата";
            this.зарплатаBindingSource.DataSource = this.дАТАБАСЕ21DataSetBindingSource;
            // 
            // зарплатаTableAdapter
            // 
            this.зарплатаTableAdapter.ClearBeforeFill = true;
            // 
            // iDЗарплатаDataGridViewTextBoxColumn
            // 
            this.iDЗарплатаDataGridViewTextBoxColumn.DataPropertyName = "ID_Зарплата";
            this.iDЗарплатаDataGridViewTextBoxColumn.HeaderText = "ID_Зарплата";
            this.iDЗарплатаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDЗарплатаDataGridViewTextBoxColumn.Name = "iDЗарплатаDataGridViewTextBoxColumn";
            this.iDЗарплатаDataGridViewTextBoxColumn.Width = 110;
            // 
            // датаПолученияDataGridViewTextBoxColumn
            // 
            this.датаПолученияDataGridViewTextBoxColumn.DataPropertyName = "Дата получения";
            this.датаПолученияDataGridViewTextBoxColumn.HeaderText = "Дата получения";
            this.датаПолученияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаПолученияDataGridViewTextBoxColumn.Name = "датаПолученияDataGridViewTextBoxColumn";
            this.датаПолученияDataGridViewTextBoxColumn.Width = 110;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.Width = 110;
            // 
            // ктоПолучилDataGridViewTextBoxColumn
            // 
            this.ктоПолучилDataGridViewTextBoxColumn.DataPropertyName = "Кто получил";
            this.ктоПолучилDataGridViewTextBoxColumn.HeaderText = "Кто получил";
            this.ктоПолучилDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ктоПолучилDataGridViewTextBoxColumn.Name = "ктоПолучилDataGridViewTextBoxColumn";
            this.ктоПолучилDataGridViewTextBoxColumn.Width = 110;
            // 
            // типЗарплатыDataGridViewTextBoxColumn
            // 
            this.типЗарплатыDataGridViewTextBoxColumn.DataPropertyName = "Тип зарплаты";
            this.типЗарплатыDataGridViewTextBoxColumn.HeaderText = "Тип зарплаты";
            this.типЗарплатыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типЗарплатыDataGridViewTextBoxColumn.Name = "типЗарплатыDataGridViewTextBoxColumn";
            this.типЗарплатыDataGridViewTextBoxColumn.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 458);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Таблица З\\П";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дАТАБАСЕ21DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дАТАБАСЕ21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зарплатаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource дАТАБАСЕ21DataSetBindingSource;
        private ДАТАБАСЕ21DataSet дАТАБАСЕ21DataSet;
        private System.Windows.Forms.BindingSource зарплатаBindingSource;
        private ДАТАБАСЕ21DataSetTableAdapters.ЗарплатаTableAdapter зарплатаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗарплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПолученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ктоПолучилDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типЗарплатыDataGridViewTextBoxColumn;
    }
}

