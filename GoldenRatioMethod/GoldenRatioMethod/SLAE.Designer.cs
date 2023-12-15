namespace GoldenRatioMethod
{
  partial class SLAE
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сгенерироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.методыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.нахождениеЛогарифмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ГауссЖордан = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Гаусс = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.label5 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      this.menuStrip2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.сгенерироватьToolStripMenuItem,
            this.импортToolStripMenuItem,
            this.очиститьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(853, 33);
      this.menuStrip1.TabIndex = 6;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // рассчитатьToolStripMenuItem
      // 
      this.рассчитатьToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
      this.рассчитатьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
      this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
      this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
      this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
      // 
      // сгенерироватьToolStripMenuItem
      // 
      this.сгенерироватьToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
      this.сгенерироватьToolStripMenuItem.Name = "сгенерироватьToolStripMenuItem";
      this.сгенерироватьToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
      this.сгенерироватьToolStripMenuItem.Text = "Сгенерировать";
      this.сгенерироватьToolStripMenuItem.Click += new System.EventHandler(this.сгенерироватьToolStripMenuItem_Click);
      // 
      // импортToolStripMenuItem
      // 
      this.импортToolStripMenuItem.BackColor = System.Drawing.Color.LightGreen;
      this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
      this.импортToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
      this.импортToolStripMenuItem.Text = "Импорт";
      this.импортToolStripMenuItem.Click += new System.EventHandler(this.импортToolStripMenuItem_Click);
      // 
      // очиститьToolStripMenuItem
      // 
      this.очиститьToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
      this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
      this.очиститьToolStripMenuItem.Text = "Очистить";
      this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
      // 
      // menuStrip2
      // 
      this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
      this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
      this.menuStrip2.Location = new System.Drawing.Point(853, 0);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(156, 653);
      this.menuStrip2.TabIndex = 7;
      this.menuStrip2.Text = "menuStrip2";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методыToolStripMenuItem,
            this.сортировкиToolStripMenuItem,
            this.нахождениеЛогарифмаToolStripMenuItem});
      this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 29);
      this.toolStripMenuItem1.Text = "Другие задачи";
      // 
      // методыToolStripMenuItem
      // 
      this.методыToolStripMenuItem.Name = "методыToolStripMenuItem";
      this.методыToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
      this.методыToolStripMenuItem.Text = "Методы";
      this.методыToolStripMenuItem.Click += new System.EventHandler(this.методыToolStripMenuItem_Click);
      // 
      // сортировкиToolStripMenuItem
      // 
      this.сортировкиToolStripMenuItem.Name = "сортировкиToolStripMenuItem";
      this.сортировкиToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
      this.сортировкиToolStripMenuItem.Text = "Сортировки";
      this.сортировкиToolStripMenuItem.Click += new System.EventHandler(this.сортировкиToolStripMenuItem_Click);
      // 
      // нахождениеЛогарифмаToolStripMenuItem
      // 
      this.нахождениеЛогарифмаToolStripMenuItem.Name = "нахождениеЛогарифмаToolStripMenuItem";
      this.нахождениеЛогарифмаToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
      this.нахождениеЛогарифмаToolStripMenuItem.Text = "Нахождение интеграла";
      this.нахождениеЛогарифмаToolStripMenuItem.Click += new System.EventHandler(this.нахождениеЛогарифмаToolStripMenuItem_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(184, 31);
      this.label1.TabIndex = 8;
      this.label1.Text = "Матрица NxN";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.checkBox3);
      this.panel1.Controls.Add(this.checkBox2);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(8, 37);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(363, 170);
      this.panel1.TabIndex = 9;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(263, 62);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(69, 54);
      this.button1.TabIndex = 19;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Checked = true;
      this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox3.Location = new System.Drawing.Point(9, 135);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(69, 24);
      this.checkBox3.TabIndex = 18;
      this.checkBox3.Text = "Гаусс";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Checked = true;
      this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox2.Location = new System.Drawing.Point(9, 105);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(134, 24);
      this.checkBox2.TabIndex = 17;
      this.checkBox2.Text = "Гаусс-Жордан";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox1.Location = new System.Drawing.Point(9, 75);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(94, 24);
      this.checkBox1.TabIndex = 16;
      this.checkBox1.Text = "Крамера";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(59, 45);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(64, 20);
      this.label4.TabIndex = 15;
      this.label4.Text = "Метод:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(261, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "(2<=N<=50)";
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox1.Location = new System.Drawing.Point(242, 19);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(104, 32);
      this.textBox1.TabIndex = 13;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(195, 22);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 26);
      this.label2.TabIndex = 12;
      this.label2.Text = "N=";
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panel2.Controls.Add(this.dataGridView2);
      this.panel2.Location = new System.Drawing.Point(8, 213);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(363, 428);
      this.panel2.TabIndex = 10;
      // 
      // dataGridView2
      // 
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ГауссЖордан,
            this.Гаусс});
      this.dataGridView2.Location = new System.Drawing.Point(4, 3);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.Size = new System.Drawing.Size(356, 422);
      this.dataGridView2.TabIndex = 0;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Крамер";
      this.Column1.Name = "Column1";
      // 
      // ГауссЖордан
      // 
      this.ГауссЖордан.HeaderText = "Гаусс-Жордан";
      this.ГауссЖордан.Name = "ГауссЖордан";
      // 
      // Гаусс
      // 
      this.Гаусс.HeaderText = "Гаусс";
      this.Гаусс.Name = "Гаусс";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(377, 36);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(620, 605);
      this.dataGridView1.TabIndex = 12;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "Excel|*.xlsx";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(547, 9);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(185, 20);
      this.label5.TabIndex = 13;
      this.label5.Text = "aX1 + aX2 + ... + aXn = b";
      // 
      // SLAE
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1009, 653);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.menuStrip2);
      this.Name = "SLAE";
      this.Text = "SLAE";
      this.Load += new System.EventHandler(this.SLAE_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.menuStrip2.ResumeLayout(false);
      this.menuStrip2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem сортировкиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem нахождениеЛогарифмаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem методыToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.ToolStripMenuItem сгенерироватьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn ГауссЖордан;
    private System.Windows.Forms.DataGridViewTextBoxColumn Гаусс;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Label label5;
  }
}