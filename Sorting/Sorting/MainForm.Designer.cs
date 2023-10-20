namespace Sorting
{
  partial class MainForm
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сгенерироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.оКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.checkBox5 = new System.Windows.Forms.CheckBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.OKbutton = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.укажитеМакимумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
      this.укажитеМинимумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
      this.количествоЭлементовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numbers});
      this.dataGridView1.Location = new System.Drawing.Point(12, 107);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(144, 166);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // Numbers
      // 
      this.Numbers.HeaderText = "Numbers";
      this.Numbers.Name = "Numbers";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.сгенерироватьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1133, 33);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // startToolStripMenuItem
      // 
      this.startToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.startToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.startToolStripMenuItem.Name = "startToolStripMenuItem";
      this.startToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
      this.startToolStripMenuItem.Text = "Start";
      this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
      // 
      // сгенерироватьToolStripMenuItem
      // 
      this.сгенерироватьToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.сгенерироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоЭлементовToolStripMenuItem,
            this.укажитеМинимумToolStripMenuItem,
            this.укажитеМакимумToolStripMenuItem,
            this.оКToolStripMenuItem});
      this.сгенерироватьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.сгенерироватьToolStripMenuItem.Name = "сгенерироватьToolStripMenuItem";
      this.сгенерироватьToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
      this.сгенерироватьToolStripMenuItem.Text = "Сгенерировать";
      this.сгенерироватьToolStripMenuItem.Click += new System.EventHandler(this.сгенерироватьToolStripMenuItem_Click);
      // 
      // оКToolStripMenuItem
      // 
      this.оКToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
      this.оКToolStripMenuItem.Name = "оКToolStripMenuItem";
      this.оКToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
      this.оКToolStripMenuItem.Text = "ОК";
      this.оКToolStripMenuItem.Click += new System.EventHandler(this.оКToolStripMenuItem_Click);
      // 
      // очиститьToolStripMenuItem
      // 
      this.очиститьToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.очиститьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
      this.очиститьToolStripMenuItem.Text = "Очистить";
      this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox1.Location = new System.Drawing.Point(12, 37);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(435, 29);
      this.textBox1.TabIndex = 2;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(272, 72);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(175, 29);
      this.button1.TabIndex = 3;
      this.button1.Text = "Сгенерировать";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // chart1
      // 
      chartArea4.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea4);
      legend4.Name = "Legend1";
      this.chart1.Legends.Add(legend4);
      this.chart1.Location = new System.Drawing.Point(474, 37);
      this.chart1.Name = "chart1";
      series16.ChartArea = "ChartArea1";
      series16.Enabled = false;
      series16.Legend = "Legend1";
      series16.Name = "Пузыри";
      series17.ChartArea = "ChartArea1";
      series17.Enabled = false;
      series17.Legend = "Legend1";
      series17.Name = "Вставки";
      series18.ChartArea = "ChartArea1";
      series18.Enabled = false;
      series18.Legend = "Legend1";
      series18.Name = "Шейкер";
      series19.ChartArea = "ChartArea1";
      series19.Enabled = false;
      series19.Legend = "Legend1";
      series19.Name = "Быстрая";
      series20.ChartArea = "ChartArea1";
      series20.Enabled = false;
      series20.Legend = "Legend1";
      series20.Name = "BOGO";
      this.chart1.Series.Add(series16);
      this.chart1.Series.Add(series17);
      this.chart1.Series.Add(series18);
      this.chart1.Series.Add(series19);
      this.chart1.Series.Add(series20);
      this.chart1.Size = new System.Drawing.Size(647, 526);
      this.chart1.TabIndex = 4;
      this.chart1.Text = "Шейкер";
      this.chart1.Click += new System.EventHandler(this.chart1_Click);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox1.Location = new System.Drawing.Point(15, 10);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(84, 24);
      this.checkBox1.TabIndex = 5;
      this.checkBox1.Text = "Пузыри";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox2.Location = new System.Drawing.Point(15, 40);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(91, 24);
      this.checkBox2.TabIndex = 6;
      this.checkBox2.Text = "Вставки";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox3.Location = new System.Drawing.Point(15, 70);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(85, 24);
      this.checkBox3.TabIndex = 7;
      this.checkBox3.Text = "Шейкер";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox4.Location = new System.Drawing.Point(15, 100);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new System.Drawing.Size(94, 24);
      this.checkBox4.TabIndex = 8;
      this.checkBox4.Text = "Быстрая";
      this.checkBox4.UseVisualStyleBackColor = true;
      // 
      // checkBox5
      // 
      this.checkBox5.AutoSize = true;
      this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox5.Location = new System.Drawing.Point(15, 130);
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.Size = new System.Drawing.Size(66, 24);
      this.checkBox5.TabIndex = 9;
      this.checkBox5.Text = "Bogo";
      this.checkBox5.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panel1.Controls.Add(this.OKbutton);
      this.panel1.Controls.Add(this.checkBox3);
      this.panel1.Controls.Add(this.checkBox5);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Controls.Add(this.checkBox4);
      this.panel1.Controls.Add(this.checkBox2);
      this.panel1.Location = new System.Drawing.Point(314, 134);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(133, 202);
      this.panel1.TabIndex = 10;
      // 
      // OKbutton
      // 
      this.OKbutton.Location = new System.Drawing.Point(2, 160);
      this.OKbutton.Name = "OKbutton";
      this.OKbutton.Size = new System.Drawing.Size(127, 39);
      this.OKbutton.TabIndex = 10;
      this.OKbutton.Text = "OK";
      this.OKbutton.UseVisualStyleBackColor = true;
      this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Location = new System.Drawing.Point(12, 368);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(249, 195);
      this.panel2.TabIndex = 11;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(6, 159);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(57, 20);
      this.label7.TabIndex = 14;
      this.label7.Text = "BOGO";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(6, 125);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(75, 20);
      this.label6.TabIndex = 13;
      this.label6.Text = "Быстрая";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(6, 92);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(66, 20);
      this.label5.TabIndex = 12;
      this.label5.Text = "Шейкер";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(6, 59);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(72, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Вставки";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(6, 28);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Пузыри";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(1, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(245, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Скорость алгоритмов (в тиках)";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(292, 506);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(143, 20);
      this.label4.TabIndex = 4;
      this.label4.Text = "Рекордное время";
      // 
      // textBox3
      // 
      this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox3.Location = new System.Drawing.Point(314, 529);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 29);
      this.textBox3.TabIndex = 5;
      // 
      // укажитеМакимумToolStripMenuItem
      // 
      this.укажитеМакимумToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
      this.укажитеМакимумToolStripMenuItem.Name = "укажитеМакимумToolStripMenuItem";
      this.укажитеМакимумToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
      this.укажитеМакимумToolStripMenuItem.Text = "Укажите макимум числа";
      // 
      // toolStripTextBox2
      // 
      this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.toolStripTextBox2.Name = "toolStripTextBox2";
      this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
      // 
      // укажитеМинимумToolStripMenuItem
      // 
      this.укажитеМинимумToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
      this.укажитеМинимумToolStripMenuItem.Name = "укажитеМинимумToolStripMenuItem";
      this.укажитеМинимумToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
      this.укажитеМинимумToolStripMenuItem.Text = "Укажите минимум числа";
      this.укажитеМинимумToolStripMenuItem.Click += new System.EventHandler(this.укажитеМинимумToolStripMenuItem_Click);
      // 
      // toolStripTextBox3
      // 
      this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.toolStripTextBox3.Name = "toolStripTextBox3";
      this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
      // 
      // количествоЭлементовToolStripMenuItem
      // 
      this.количествоЭлементовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
      this.количествоЭлементовToolStripMenuItem.Name = "количествоЭлементовToolStripMenuItem";
      this.количествоЭлементовToolStripMenuItem.Size = new System.Drawing.Size(283, 30);
      this.количествоЭлементовToolStripMenuItem.Text = "Количество элементов";
      // 
      // toolStripTextBox1
      // 
      this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.toolStripTextBox1.Name = "toolStripTextBox1";
      this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1133, 575);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn Numbers;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ToolStripMenuItem сгенерироватьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem оКToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.CheckBox checkBox5;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button OKbutton;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ToolStripMenuItem количествоЭлементовToolStripMenuItem;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    private System.Windows.Forms.ToolStripMenuItem укажитеМинимумToolStripMenuItem;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
    private System.Windows.Forms.ToolStripMenuItem укажитеМакимумToolStripMenuItem;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
  }
}