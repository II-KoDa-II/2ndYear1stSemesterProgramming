namespace GoldenRatioMethod
{
  partial class FindIntegral
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.назадToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.нахождениеЛогарифмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.menuStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip2
			// 
			this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(853, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(156, 642);
			this.menuStrip2.TabIndex = 23;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// назадToolStripMenuItem
			// 
			this.назадToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.назадToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem1,
            this.нахождениеЛогарифмаToolStripMenuItem});
			this.назадToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
			this.назадToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
			this.назадToolStripMenuItem.Text = "Другие задачи";
			// 
			// назадToolStripMenuItem1
			// 
			this.назадToolStripMenuItem1.Name = "назадToolStripMenuItem1";
			this.назадToolStripMenuItem1.Size = new System.Drawing.Size(189, 30);
			this.назадToolStripMenuItem1.Text = "Методы";
			this.назадToolStripMenuItem1.Click += new System.EventHandler(this.назадToolStripMenuItem1_Click);
			// 
			// нахождениеЛогарифмаToolStripMenuItem
			// 
			this.нахождениеЛогарифмаToolStripMenuItem.Name = "нахождениеЛогарифмаToolStripMenuItem";
			this.нахождениеЛогарифмаToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
			this.нахождениеЛогарифмаToolStripMenuItem.Text = "Сортировки";
			this.нахождениеЛогарифмаToolStripMenuItem.Click += new System.EventHandler(this.нахождениеЛогарифмаToolStripMenuItem_Click);
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			this.chart1.Location = new System.Drawing.Point(386, 41);
			this.chart1.Name = "chart1";
			series2.BorderWidth = 3;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series2.Name = "Series1";
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(611, 589);
			this.chart1.TabIndex = 24;
			this.chart1.Text = "chart1";
			this.chart1.Click += new System.EventHandler(this.chart1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(853, 33);
			this.menuStrip1.TabIndex = 25;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// рассчитатьToolStripMenuItem
			// 
			this.рассчитатьToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.рассчитатьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
			this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
			this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
			this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel1.Controls.Add(this.checkBox3);
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(368, 136);
			this.panel1.TabIndex = 26;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox3.Location = new System.Drawing.Point(7, 98);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(213, 28);
			this.checkBox3.TabIndex = 3;
			this.checkBox3.Text = "Симпсон (параболы)";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox2.Location = new System.Drawing.Point(7, 64);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(117, 28);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "Трапеции";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox1.Location = new System.Drawing.Point(7, 30);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(179, 28);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Прямоугольники";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.MinimumSize = new System.Drawing.Size(365, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(365, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Выбор метода";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(112, 120);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(240, 26);
			this.textBox1.TabIndex = 27;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(112, 88);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(240, 26);
			this.textBox2.TabIndex = 29;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel2.Controls.Add(this.label16);
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBox5);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBox4);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Location = new System.Drawing.Point(12, 183);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(368, 226);
			this.panel2.TabIndex = 31;
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(112, 184);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(240, 29);
			this.textBox5.TabIndex = 35;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(10, 187);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(96, 24);
			this.label12.TabIndex = 34;
			this.label12.Text = "Точность";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.MinimumSize = new System.Drawing.Size(365, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(365, 20);
			this.label5.TabIndex = 33;
			this.label5.Text = "Интеграл";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(112, 152);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(240, 26);
			this.textBox4.TabIndex = 31;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel3.Controls.Add(this.label17);
			this.panel3.Controls.Add(this.label18);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Location = new System.Drawing.Point(12, 415);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(368, 215);
			this.panel3.TabIndex = 32;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(212, 107);
			this.label9.MaximumSize = new System.Drawing.Size(140, 24);
			this.label9.MinimumSize = new System.Drawing.Size(140, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(140, 24);
			this.label9.TabIndex = 7;
			this.label9.Text = "_____________";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(212, 73);
			this.label10.MaximumSize = new System.Drawing.Size(140, 24);
			this.label10.MinimumSize = new System.Drawing.Size(140, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(140, 24);
			this.label10.TabIndex = 6;
			this.label10.Text = "_____________";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(212, 38);
			this.label11.MaximumSize = new System.Drawing.Size(140, 24);
			this.label11.MinimumSize = new System.Drawing.Size(140, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(140, 24);
			this.label11.TabIndex = 5;
			this.label11.Text = "_____________";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(140, 169);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 24);
			this.label8.TabIndex = 4;
			this.label8.Text = "Идеал";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(108, 73);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 24);
			this.label7.TabIndex = 3;
			this.label7.Text = "Трапеции";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(46, 38);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(160, 24);
			this.label6.TabIndex = 2;
			this.label6.Text = "Прямоугольники";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.MinimumSize = new System.Drawing.Size(365, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(365, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Результаты";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(83, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 24);
			this.label2.TabIndex = 36;
			this.label2.Text = "A";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(83, 120);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(22, 24);
			this.label13.TabIndex = 37;
			this.label13.Text = "B";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.Location = new System.Drawing.Point(22, 40);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(63, 24);
			this.label14.TabIndex = 38;
			this.label14.Text = "∫f(x)dx";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(46, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 24);
			this.label3.TabIndex = 39;
			this.label3.Text = "F(x) =";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(23, 27);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(13, 13);
			this.label15.TabIndex = 40;
			this.label15.Text = "a";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(23, 64);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(13, 13);
			this.label16.TabIndex = 41;
			this.label16.Text = "b";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label17.Location = new System.Drawing.Point(212, 169);
			this.label17.MaximumSize = new System.Drawing.Size(140, 24);
			this.label17.MinimumSize = new System.Drawing.Size(140, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(140, 24);
			this.label17.TabIndex = 9;
			this.label17.Text = "_____________";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label18.Location = new System.Drawing.Point(12, 107);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(194, 24);
			this.label18.TabIndex = 8;
			this.label18.Text = "Симпсон (параболы)";
			// 
			// FindIntegral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1009, 642);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.menuStrip2);
			this.Name = "FindIntegral";
			this.Text = "FindIntegral";
			this.Load += new System.EventHandler(this.FindIntegral_Load);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem нахождениеЛогарифмаToolStripMenuItem;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
	}
}