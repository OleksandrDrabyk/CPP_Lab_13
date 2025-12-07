
namespace lab_12
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DGSklad = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBGrupa = new System.Windows.Forms.ComboBox();
            this.BAddRowToTable = new System.Windows.Forms.Button();
            this.TBKilkist = new System.Windows.Forms.TextBox();
            this.TBCina = new System.Windows.Forms.TextBox();
            this.TBVyrobnyk = new System.Windows.Forms.TextBox();
            this.TBNazva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатиТаблицюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зчитатиТаблицюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фільтруватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.встановитиФільтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.знятиФільтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.встановитиКритерійСортуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортуватиПоГрупіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукПоНазвіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGSkladSum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGSklad)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGSkladSum)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DGSklad);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGSkladSum);
            this.splitContainer1.Size = new System.Drawing.Size(1105, 599);
            this.splitContainer1.SplitterDistance = 381;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // DGSklad
            // 
            this.DGSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSklad.Location = new System.Drawing.Point(6, 122);
            this.DGSklad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGSklad.Name = "DGSklad";
            this.DGSklad.RowHeadersWidth = 102;
            this.DGSklad.Size = new System.Drawing.Size(1042, 228);
            this.DGSklad.TabIndex = 1;
            this.DGSklad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGSklad_CellContentClick);
            this.DGSklad.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGSklad_CellValidating);
            this.DGSklad.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGSklad_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBGrupa);
            this.panel1.Controls.Add(this.BAddRowToTable);
            this.panel1.Controls.Add(this.TBKilkist);
            this.panel1.Controls.Add(this.TBCina);
            this.panel1.Controls.Add(this.TBVyrobnyk);
            this.panel1.Controls.Add(this.TBNazva);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 86);
            this.panel1.TabIndex = 0;
            // 
            // CBGrupa
            // 
            this.CBGrupa.FormattingEnabled = true;
            this.CBGrupa.Location = new System.Drawing.Point(4, 34);
            this.CBGrupa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBGrupa.Name = "CBGrupa";
            this.CBGrupa.Size = new System.Drawing.Size(120, 24);
            this.CBGrupa.TabIndex = 12;
            // 
            // BAddRowToTable
            // 
            this.BAddRowToTable.Location = new System.Drawing.Point(873, 13);
            this.BAddRowToTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BAddRowToTable.Name = "BAddRowToTable";
            this.BAddRowToTable.Size = new System.Drawing.Size(125, 64);
            this.BAddRowToTable.TabIndex = 11;
            this.BAddRowToTable.Text = "Додати рядок до таблиці Склад";
            this.BAddRowToTable.UseVisualStyleBackColor = true;
            this.BAddRowToTable.Click += new System.EventHandler(this.BAddRowToTable_Click);
            // 
            // TBKilkist
            // 
            this.TBKilkist.Location = new System.Drawing.Point(733, 34);
            this.TBKilkist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBKilkist.Name = "TBKilkist";
            this.TBKilkist.Size = new System.Drawing.Size(132, 22);
            this.TBKilkist.TabIndex = 10;
            // 
            // TBCina
            // 
            this.TBCina.Location = new System.Drawing.Point(562, 34);
            this.TBCina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBCina.Name = "TBCina";
            this.TBCina.Size = new System.Drawing.Size(132, 22);
            this.TBCina.TabIndex = 9;
            // 
            // TBVyrobnyk
            // 
            this.TBVyrobnyk.Location = new System.Drawing.Point(364, 33);
            this.TBVyrobnyk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBVyrobnyk.Name = "TBVyrobnyk";
            this.TBVyrobnyk.Size = new System.Drawing.Size(132, 22);
            this.TBVyrobnyk.TabIndex = 8;
            // 
            // TBNazva
            // 
            this.TBNazva.Location = new System.Drawing.Point(177, 34);
            this.TBNazva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBNazva.Name = "TBNazva";
            this.TBNazva.Size = new System.Drawing.Size(132, 22);
            this.TBNazva.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(761, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Кількість";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ціна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Виробник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Група";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть нові дані у таблицю Склад";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фільтруватиToolStripMenuItem,
            this.сортуватиToolStripMenuItem,
            this.пошукToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1105, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записатиТаблицюToolStripMenuItem,
            this.зчитатиТаблицюToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // записатиТаблицюToolStripMenuItem
            // 
            this.записатиТаблицюToolStripMenuItem.Name = "записатиТаблицюToolStripMenuItem";
            this.записатиТаблицюToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.записатиТаблицюToolStripMenuItem.Text = "Записати таблицю";
            this.записатиТаблицюToolStripMenuItem.Click += new System.EventHandler(this.записатиТаблицюToolStripMenuItem_Click);
            // 
            // зчитатиТаблицюToolStripMenuItem
            // 
            this.зчитатиТаблицюToolStripMenuItem.Name = "зчитатиТаблицюToolStripMenuItem";
            this.зчитатиТаблицюToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.зчитатиТаблицюToolStripMenuItem.Text = "Зчитати таблицю";
            this.зчитатиТаблицюToolStripMenuItem.Click += new System.EventHandler(this.зчитатиТаблицюToolStripMenuItem_Click);
            // 
            // фільтруватиToolStripMenuItem
            // 
            this.фільтруватиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.встановитиФільтрToolStripMenuItem,
            this.знятиФільтрToolStripMenuItem});
            this.фільтруватиToolStripMenuItem.Name = "фільтруватиToolStripMenuItem";
            this.фільтруватиToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.фільтруватиToolStripMenuItem.Text = "Фільтрувати";
            // 
            // встановитиФільтрToolStripMenuItem
            // 
            this.встановитиФільтрToolStripMenuItem.Name = "встановитиФільтрToolStripMenuItem";
            this.встановитиФільтрToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.встановитиФільтрToolStripMenuItem.Text = "Встановити фільтр";
            this.встановитиФільтрToolStripMenuItem.Click += new System.EventHandler(this.встановитиФільтрToolStripMenuItem_Click);
            // 
            // знятиФільтрToolStripMenuItem
            // 
            this.знятиФільтрToolStripMenuItem.Name = "знятиФільтрToolStripMenuItem";
            this.знятиФільтрToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.знятиФільтрToolStripMenuItem.Text = "Зняти фільтр";
            this.знятиФільтрToolStripMenuItem.Click += new System.EventHandler(this.знятиФільтрToolStripMenuItem_Click);
            // 
            // сортуватиToolStripMenuItem
            // 
            this.сортуватиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.встановитиКритерійСортуванняToolStripMenuItem,
            this.сортуватиПоГрупіToolStripMenuItem});
            this.сортуватиToolStripMenuItem.Name = "сортуватиToolStripMenuItem";
            this.сортуватиToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.сортуватиToolStripMenuItem.Text = "Сортувати";
            // 
            // встановитиКритерійСортуванняToolStripMenuItem
            // 
            this.встановитиКритерійСортуванняToolStripMenuItem.Name = "встановитиКритерійСортуванняToolStripMenuItem";
            this.встановитиКритерійСортуванняToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.встановитиКритерійСортуванняToolStripMenuItem.Text = "Встановити критерій сортування";
            this.встановитиКритерійСортуванняToolStripMenuItem.Click += new System.EventHandler(this.встановитиКритерійСортуванняToolStripMenuItem_Click);
            // 
            // сортуватиПоГрупіToolStripMenuItem
            // 
            this.сортуватиПоГрупіToolStripMenuItem.Name = "сортуватиПоГрупіToolStripMenuItem";
            this.сортуватиПоГрупіToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.сортуватиПоГрупіToolStripMenuItem.Text = "Сортувати по групі";
            this.сортуватиПоГрупіToolStripMenuItem.Click += new System.EventHandler(this.сортуватиПоГрупіToolStripMenuItem_Click);
            // 
            // пошукToolStripMenuItem
            // 
            this.пошукToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пошукПоНазвіToolStripMenuItem});
            this.пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            this.пошукToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.пошукToolStripMenuItem.Text = "Пошук";
            // 
            // пошукПоНазвіToolStripMenuItem
            // 
            this.пошукПоНазвіToolStripMenuItem.Name = "пошукПоНазвіToolStripMenuItem";
            this.пошукПоНазвіToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.пошукПоНазвіToolStripMenuItem.Text = "Пошук по назві";
            this.пошукПоНазвіToolStripMenuItem.Click += new System.EventHandler(this.пошукПоНазвіToolStripMenuItem_Click);
            // 
            // DGSkladSum
            // 
            this.DGSkladSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSkladSum.Location = new System.Drawing.Point(12, 19);
            this.DGSkladSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGSkladSum.Name = "DGSkladSum";
            this.DGSkladSum.RowHeadersWidth = 102;
            this.DGSkladSum.Size = new System.Drawing.Size(1038, 163);
            this.DGSkladSum.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 599);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Drabyk_lab_13";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGSklad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGSkladSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBKilkist;
        private System.Windows.Forms.TextBox TBCina;
        private System.Windows.Forms.TextBox TBVyrobnyk;
        private System.Windows.Forms.TextBox TBNazva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGSklad;
        private System.Windows.Forms.Button BAddRowToTable;
        private System.Windows.Forms.DataGridView DGSkladSum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записатиТаблицюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зчитатиТаблицюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фільтруватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem встановитиФільтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem знятиФільтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem встановитиКритерійСортуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортуватиПоГрупіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукПоНазвіToolStripMenuItem;
        private System.Windows.Forms.ComboBox CBGrupa;
    }
}

