using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using org.mariuszgromada.math.mxparser;
using System.Diagnostics;

namespace GoldenRatioMethod
{
  public partial class SLAE : Form
  {
    double[,] Matrix;
    int N;
    MainForm mainForm;
    Exceptions ex = new Exceptions();

    public SLAE(MainForm form)
    {
      InitializeComponent();
      mainForm = form;
    }

    private bool setN()
    {
      try
      {
        N = Convert.ToInt32(textBox1.Text);

        if (N < 2)
        {
          N = 2;
          ex.showDimensionError();
        }
        if (N > 50)
        {
          N = 50;
          ex.showDimensionError();
        }
        Matrix = new double[N, N + 1];

        return true;
      }
      catch
      {
        N = 1;
        ex.showDimensionError();
        return false;
      }
    }

    private void GenerateRandomMatrix()
    {
      Random r = new Random();

      for (int i = 0; i < N; ++i)
      {
        for (int j = 0; j < N + 1; ++j)
        {
          Matrix[i, j] = r.Next(-10, 10);
        }
      }
    }

    private void showConsoleMatrix()
    {
      Console.WriteLine();
      for (int i = 0; i < N; ++i)
      {
        for (int j = 0; j < N + 1; ++j)
        {
          Console.Write(Matrix[i, j] + "  ");
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
    private void GetExel()
    {
      double[,] excelTable;
      int totalRows = 0;
      int totalColumns = 0;

      try
      {
        DialogResult res = openFileDialog1.ShowDialog();
        if (res == DialogResult.OK)
        {
          ExcelPackage excelFile = new ExcelPackage(new FileInfo(openFileDialog1.FileName));
          ExcelWorksheet worksheet = excelFile.Workbook.Worksheets[1]; //индекс листа, котрый импортируем, добавь комбобокс
          totalRows = worksheet.Dimension.End.Row;
          totalColumns = worksheet.Dimension.End.Column; // колл-во строк и столбцов из хцеля передаются в переменные. добавить обработчик ошибки на неквадратность конечной импортируемой матрицы

          excelTable = new double[totalRows, totalColumns];

          for (int rowIndex = 1; rowIndex <= totalRows; rowIndex++)
          {
            IEnumerable<string> row = worksheet.Cells[rowIndex, 1, rowIndex, totalColumns].Select(c => c.Value == null ? string.Empty : c.Value.ToString());

            List<string> list = row.ToList<string>();

            for (int i = 0; i < list.Count; i++)
            {
              excelTable[rowIndex - 1, i] = Convert.ToDouble(list[i].Replace('.', ','));
            }
          }

          Matrix = excelTable;
          N = totalRows;
        }
        else
        {
          throw new Exception("Не выбран файл!");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    static double determinant(double[,] m)
    {
      int numRows = m.GetLength(0);
      int numCols = m.GetLength(1);
      int n = numCols;
      double[,] matrix = new double[n, n];
      matrix = m;

      for (int k = 1; k < n; k++)
      {
        for (int i = k; i < n; i++)
        {
          double C = matrix[i, k - 1] / matrix[k - 1, k - 1];
          for (int j = 0; j < numCols; j++)
          {
            matrix[i, j] -= C * matrix[k - 1, j];
          }
        }
      };
      double result = 1;
      for (int i = 0; i < n; i++)
      {
        result *= matrix[i, i];
      };
      return result;
    }

    private void SLAE_Load(object sender, EventArgs e)
    {

    }

    private void методыToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      mainForm.Show();
    }

    private void нахождениеЛогарифмаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      FindIntegral FindIntegral = new FindIntegral(mainForm);
      FindIntegral.Show();
    }

    private void сортировкиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      Sorting sorting = new Sorting(mainForm);
      sorting.Show();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      
    }

    private void ClearTimer()
    {
      textBox2.Text = "";
      textBox3.Text = "";
      textBox4.Text = "";
    }

    private void Cramer()
    {
      CramerMethod cm = new CramerMethod(Matrix, N);
      Stopwatch stopwatch = new Stopwatch();

      stopwatch.Start();
      double[] result = cm.Cramer();
      stopwatch.Stop();

      FillAnswer(result, 0);
      textBox2.Text = stopwatch.ElapsedTicks.ToString();

      Console.WriteLine("\n   Крамер");
      for (int i = 0; i < N; ++i)
      {
        Console.WriteLine(result[i]);
      }
    }

    private void Gauss()
    {
      GaussMethod gm = new GaussMethod(Matrix, N);
      Stopwatch stopwatch = new Stopwatch();

      stopwatch.Start();
      double[] result = gm.Gauss();
      stopwatch.Stop();

      FillAnswer(result, 2);
      textBox4.Text = stopwatch.ElapsedTicks.ToString();

      Console.WriteLine("\n   Гаусс");
      for (int i = 0; i < N; ++i)
      {
        Console.WriteLine(result[i]);
      }
    }

    private void GaussJordan()
    {
      GaussJordanMethod gjm = new GaussJordanMethod(Matrix, N);
      Stopwatch stopwatch = new Stopwatch();

      stopwatch.Start();
      double[] result = gjm.GaussJordan();
      stopwatch.Stop();

      FillAnswer(result, 1);
      textBox3.Text = stopwatch.ElapsedTicks.ToString();

      Console.WriteLine("\n   Гаусс-Жордан");
      for (int i = 0; i < N; ++i)
      {
        Console.WriteLine(result[i]);
      }
    }

    private void createMatrix()
    {
      dataGridView1.RowCount = N;
      dataGridView1.ColumnCount = N + 1;
      dataGridView2.RowCount = N;
    }

    private void showMatrix()
    {
      for(int i = 0; i < N; ++i)
      {
        for(int j = 0; j<N + 1; ++j)
        {
          dataGridView1.Rows[i].Cells[j].Value = Matrix[i, j];
        }
      }
    }

    private void MatrixFromView()
    {
      try
      {
        for (int i = 0; i < N; ++i)
        {
          for (int j = 0; j < N + 1; ++j)
          {
            if(dataGridView1.Rows[i].Cells[j].Value == "" || dataGridView1.Rows[i].Cells[j].Value == " ")
            {
              Matrix[i, j] = 0;
            }
            else
            {
              Function ParsFunction = new Function("f(x) = " + dataGridView1.Rows[i].Cells[j].Value);
              Matrix[i, j] = ParsFunction.calculate();
            }
          }
        }
      }
      catch
      {
        ex.showParseError();
      }
    }

    private bool notEmptyMatrix()
    {
      int countNull = 0;
      for(int i = 0; i < N; ++i)
      {
        for(int j = 0; j < N + 1; ++j)
        {
          try
          {
            if (Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value) == 0d)
            {
              ++countNull;
            }
            if (dataGridView1.Rows[i].Cells[j].Value == "" || dataGridView1.Rows[i].Cells[j].Value == " ")
            {
              return false;
            }
          }
          catch
          {

          }
        }
      }
      if(countNull == N * N + N)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    private void FillAnswer(double[] Mass, int index)
    {
      for(int i = 0; i < N; ++i)
      {
        dataGridView2.Rows[i].Cells[index].Value = Mass[i];
      }
    }

    private double detMatrix(double[,] Mass)
    {
      double[,] MatrixA = new double[N, N];
      for (int i = 0; i < N; ++i)
      {
        for (int j = 0; j < N; ++j)
        {
          MatrixA[i, j] = Matrix[i, j];
        }
      }

      return determinant(MatrixA);
    }

    private void calculation()
    {
      if (setN() && notEmptyMatrix())
      {
        ClearTimer();
        MatrixFromView();
        showConsoleMatrix();

        if (checkBox1.Checked)
        {
          if(detMatrix(Matrix) == 0)
          {
            MessageBox.Show("Определитель равен 0. Система имеет бесконечное количество решений", "Ошибка");
          }
          else
          {
            Cramer();
          }
        }

        if (checkBox2.Checked)
        {
          Gauss();
        }

        if (checkBox3.Checked)
        {
          GaussJordan();
        }
      }
    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      calculation();
    }

    private void сгенерироватьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (setN())
      {
          createMatrix();
          GenerateRandomMatrix();
          showMatrix();
          calculation();
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (setN())
      {
        createMatrix();
      }
    }

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      dataGridView1.Rows.Clear();
      dataGridView2.Rows.Clear();
    }

    private void импортToolStripMenuItem_Click(object sender, EventArgs e)
    {
      GetExel();
      createMatrix();
      showMatrix();
      textBox1.Text = N.ToString();
      calculation();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void мНКToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      MHK mhk = new MHK(mainForm);
      mhk.Show();
    }
  }
}
