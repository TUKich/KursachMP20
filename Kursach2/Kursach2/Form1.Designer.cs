namespace Kursach2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox6 = new System.Windows.Forms.ToolStripTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоКупейныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоПоездовДоЗаднСтанцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоИнтеревалуВремениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьСведенияОНаличиеБилетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(884, 535);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.редактированиеToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(884, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripComboBox2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem1.Text = "Таблица";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.ReadOnly = true;
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "Добавить";
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.ReadOnly = true;
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox2.Text = "Удалить";
            this.toolStripComboBox2.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox5,
            this.toolStripComboBox6});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(48, 23);
            this.toolStripMenuItem2.Text = "Файл";
            // 
            // toolStripComboBox5
            // 
            this.toolStripComboBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox5.Name = "toolStripComboBox5";
            this.toolStripComboBox5.ReadOnly = true;
            this.toolStripComboBox5.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox5.Text = "Сохранить";
            this.toolStripComboBox5.Click += new System.EventHandler(this.toolStripComboBox5_Click);
            // 
            // toolStripComboBox6
            // 
            this.toolStripComboBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox6.Name = "toolStripComboBox6";
            this.toolStripComboBox6.ReadOnly = true;
            this.toolStripComboBox6.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox6.Text = "Загрузить";
            this.toolStripComboBox6.Click += new System.EventHandler(this.toolStripComboBox6_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.колвоКупейныхToolStripMenuItem,
            this.колвоПоездовДоЗаднСтанцииToolStripMenuItem,
            this.сортировкаПоИнтеревалуВремениToolStripMenuItem,
            this.изменитьСведенияОНаличиеБилетовToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 20);
            this.toolStripMenuItem3.Text = "Работа с таблицей";
            // 
            // колвоКупейныхToolStripMenuItem
            // 
            this.колвоКупейныхToolStripMenuItem.Name = "колвоКупейныхToolStripMenuItem";
            this.колвоКупейныхToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.колвоКупейныхToolStripMenuItem.Text = "Кол-во свободных купейных выгон";
            this.колвоКупейныхToolStripMenuItem.Click += new System.EventHandler(this.колвоКупейныхToolStripMenuItem_Click);
            // 
            // колвоПоездовДоЗаднСтанцииToolStripMenuItem
            // 
            this.колвоПоездовДоЗаднСтанцииToolStripMenuItem.Name = "колвоПоездовДоЗаднСтанцииToolStripMenuItem";
            this.колвоПоездовДоЗаднСтанцииToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.колвоПоездовДоЗаднСтанцииToolStripMenuItem.Text = "Кол-во поездов до заданной станции";
            this.колвоПоездовДоЗаднСтанцииToolStripMenuItem.Click += new System.EventHandler(this.колвоПоездовДоЗаднСтанцииToolStripMenuItem_Click);
            // 
            // сортировкаПоИнтеревалуВремениToolStripMenuItem
            // 
            this.сортировкаПоИнтеревалуВремениToolStripMenuItem.Name = "сортировкаПоИнтеревалуВремениToolStripMenuItem";
            this.сортировкаПоИнтеревалуВремениToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.сортировкаПоИнтеревалуВремениToolStripMenuItem.Text = "Сортировка по интеревалу времени";
            this.сортировкаПоИнтеревалуВремениToolStripMenuItem.Click += new System.EventHandler(this.сортировкаПоИнтеревалуВремениToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            this.редактированиеToolStripMenuItem.Click += new System.EventHandler(this.редактированиеToolStripMenuItem_Click);
            // 
            // изменитьСведенияОНаличиеБилетовToolStripMenuItem
            // 
            this.изменитьСведенияОНаличиеБилетовToolStripMenuItem.Name = "изменитьСведенияОНаличиеБилетовToolStripMenuItem";
            this.изменитьСведенияОНаличиеБилетовToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.изменитьСведенияОНаличиеБилетовToolStripMenuItem.Text = "Изменить сведения о наличие билетов";
            this.изменитьСведенияОНаличиеБилетовToolStripMenuItem.Click += new System.EventHandler(this.изменитьСведенияОНаличиеБилетовToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "РЖД";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripComboBox5;
        private System.Windows.Forms.ToolStripTextBox toolStripComboBox6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem колвоКупейныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоПоездовДоЗаднСтанцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоИнтеревалуВремениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьСведенияОНаличиеБилетовToolStripMenuItem;
    }
}

