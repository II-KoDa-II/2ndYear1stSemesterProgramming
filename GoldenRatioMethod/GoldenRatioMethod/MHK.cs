using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace GoldenRatioMethod
{
  public partial class MHK : Form
  {
    MainForm mainform;
    List<double> MassF = new List<double>();
    List<double> MassX = new List<double>();
    double Start, End, Precision;
    string Function;
    int AccuracyForView;
    Exceptions ex = new Exceptions();
    public MHK()
    {
      InitializeComponent();
    }

    public MHK(MainForm form)
    {
      mainform = form;
      InitializeComponent();
    }

    private void MHK_Load(object sender, EventArgs e)
    {

    }

    private bool getValue()
    {
      try
      {
        int Count = dataGridView1.Rows.Count;
        for (int i = 0; i < Count; ++i)
        {
          MassF.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value));
          MassX.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value));
        }
      }
      catch
      {
        ex.showDataEntryError();
        return false;
      }
      try
      {
        Precision = Convert.ToDouble(textBox1.Text);
        double Accuracy = Math.Log10(Precision) * -1.0;
        AccuracyForView = Convert.ToInt32(Accuracy);
        if (AccuracyForView < 0)
        {
          AccuracyForView = 0;
        }
      }
      catch
      {
        Precision = 0.01;
        AccuracyForView = 3;
      }
      return true;
    }

    private void setMinMaxValue()
    {
      Start = MassX.Min();
      End = MassX.Max();
    }

    private void CreateViewGraf(string StringFunction, bool HyperbolaChek)
    {
      CalculateFunction Function = new StandartFunction(StringFunction);
      bool flag = true;
      double Step = (End - Start) / 50;
      int SeriesIndex = 0;

      System.Windows.Forms.DataVisualization.Charting.Series MainSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
      MainSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      MainSeries.BorderWidth = 3;
      MainSeries.Color = Color.CornflowerBlue;
      this.chart1.Series.Add(MainSeries);

      for (double x = Start; x < End; x += Step)
      {
        double y = Function.getFunction(x);
        this.chart1.Series[SeriesIndex].Points.AddXY(x, y);
        this.Update();

        if (Function.getFunction(x) * Function.getFunction(x + Step) < 0 && flag && HyperbolaChek)
        {
          System.Windows.Forms.DataVisualization.Charting.Series s = new System.Windows.Forms.DataVisualization.Charting.Series();
          s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
          s.BorderWidth = 3;
          s.Color = Color.CornflowerBlue;
          this.chart1.Series.Add(s);
          x += Step;
          ++SeriesIndex;
          flag = false;
        }
      }
    }

    private void CreateViewPoints()
    {
      for (int i = 0; i < MassX.Count; ++i)
      {
        System.Windows.Forms.DataVisualization.Charting.Series Point = new System.Windows.Forms.DataVisualization.Charting.Series();
        Point.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
        Point.Color = Color.Red;
        Point.BorderWidth = 4;
        Point.Points.AddXY(MassX[i], MassF[i]);
        chart1.Series.Add(Point);
      }
    }

    private string ConvertRount(double a, bool Sign)
    {
      string result = "";
      if (Sign)
      {
        if (a >= 0)
        {
          result = "+";
        }
        else
        {
          result = "-";
        }
      }
      result += Convert.ToString(Math.Round(Math.Abs(a), AccuracyForView));
      return result;
    }

    private string LinearFunction()
    {
      int N = dataGridView1.Rows.Count;
      double sumX = 0, sumY = 0, sumXY = 0, sumXX = 0;

      for (int i = 0; i < N; ++i)
      {
        sumX += MassX[i];
        sumY += MassF[i];
        sumXY += MassX[i] * MassF[i];
        sumXX += MassX[i] * MassX[i];
      }

      double a = (N * sumXY - sumX * sumY) / (N * sumXX - sumX * sumX);
      double b = (sumY - a * sumX) / N;
      string result = a + " * x + (" + b + ")";
      result = result.Replace(',', '.');
      Function = result;
      Console.WriteLine(result);
      textBox3.Text = ConvertRount(a, false) + " x " + ConvertRount(b, true);
      return result;
    }

    private string ParabolicFunction2()
    {
      int N = dataGridView1.Rows.Count;
      double X1 = 0, X2 = 0, X3 = 0, X4 = 0, Y = 0, YX = 0, YXX = 0;

      for (int i = 0; i < N; ++i)
      {
        X1 += MassX[i];
        X2 += Math.Pow(MassX[i], 2);
        X3 += Math.Pow(MassX[i], 3);
        X4 += Math.Pow(MassX[i], 4);
        Y += MassF[i];
        YX += MassF[i] * MassX[i];
        YXX += MassF[i] * MassX[i] * MassX[i];
      }

      double[,] Matrix = {
        { X2, X1, N, Y },
        { X3, X2, X1, YX },
        { X4, X3, X2, YXX} };

      CramerMethod cm = new CramerMethod(Matrix, 3);
      double[] ResultMatrix = cm.Cramer();

      double a = ResultMatrix[0];
      double b = ResultMatrix[1];
      double c = ResultMatrix[2];

      string result = a + " * x^2 + (" + b + ") * x + (" + c + ")";
      result = result.Replace(',', '.');
      Function = result;
      Console.WriteLine(result);
      textBox3.Text = ConvertRount(a, false) + "x^2 " + ConvertRount(b, true) + "x " + ConvertRount(c, true);
      return result;
    }

    private string HyperbolaFunction()
    {
      int N = dataGridView1.Rows.Count;
      double sumY = 0, sumYY = 0, sumXY = 0, sumXYY = 0;

      for (int i = 0; i < N; ++i)
      {
        sumY += MassF[i];
        sumYY += MassF[i] * MassF[i];
        sumXY += MassX[i] * MassF[i];
        sumXYY += MassX[i] * MassF[i] * MassF[i];
      }

      double[,] Matrix = { 
        { N, -1 * sumY, sumXY}, 
        { sumY, -1* sumYY, sumXYY } };
      CramerMethod cm = new CramerMethod(Matrix, 2);
      double[] ResultMatrix = cm.Cramer();

      double a = ResultMatrix[0];
      double b = ResultMatrix[1];

      if(a is double.NaN || b is double.NaN)
      {
        MessageBox.Show("Не удалось посчитать", "Ошибка");
      }

      string result = a + " / ( x + " + b + " )";
      result = result.Replace(',', '.');
      Function = result;
      Console.WriteLine(result);
      textBox3.Text = ConvertRount(a, false) + " / (x " + ConvertRount(b, true) + ")";
      return result;
    }

    private double GoldenRatioMethod(CalculateFunction func)
    {
      double z = (3 - Math.Sqrt(5)) / 2;
      double x1 = Start + z * (End - Start);
      double x2 = End - z * (End - Start);

      while (Math.Abs(End - Start) > Precision)
      {
        if (func.getFunction(x1) <= func.getFunction(x2))
        {
          End = x2;
          x2 = x1;
          x1 = Start + End - x2;
        }
        else
        {
          Start = x1;
          x1 = x2;
          x2 = Start + End - x1;
        }
      }
      double x = (Start + End) / 2;
      return (x);
    }

    private void FindIntersectionPointsGolden(string func)
    {
      CalculateFunction Function = new AbsFunction(func);
      double Root = GoldenRatioMethod(Function);
      double f0 = Function.getFunction(Root);

      if (f0 < 1 && f0 > -1)
      {
        textBox4.Text = Convert.ToString(Math.Round(Root, AccuracyForView));
        textBox8.Text = Convert.ToString(f0);
      }
      else
      {
        textBox4.Text = "Не удалось найти";
        textBox8.Text = "Нет";
      }
    }
    private void FindTheMinimumGolden(string func)
    {
      CalculateFunction Function = new StandartFunction(func);
      textBox5.Text = Convert.ToString(Math.Round(GoldenRatioMethod(Function), AccuracyForView));
    }
    private void FindTheMaximumGolden(string func)
    {
      CalculateFunction Function = new MinusFunction(func);
      textBox6.Text = Convert.ToString(Math.Round(GoldenRatioMethod(Function), AccuracyForView));
    }

    private void ExtremumFunction(string Function)
    {
      FindIntersectionPointsGolden(Function);
      FindTheMinimumGolden(Function);
      FindTheMaximumGolden(Function);
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ClearDate();
      if (getValue())
      {
        chart1.Series.Clear();
        setMinMaxValue();

        if (radioButton1.Checked)
        {
          CreateViewGraf(LinearFunction(), false);
        }
        if (radioButton2.Checked)
        {
          CreateViewGraf(ParabolicFunction2(), false);
          Console.WriteLine();
        }
        if (radioButton3.Checked)
        {
          CreateViewGraf(HyperbolaFunction(), true);
        }
        CreateViewPoints();
        ExtremumFunction(Function);
      }
    }

    private void методыToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      mainform.Show();
    }

    private void сортировкиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      Sorting sorting = new Sorting(mainform);
      sorting.Show();
    }

    private void сЛАУToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      SLAE slae = new SLAE(mainform);
      slae.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Random r = new Random();
      int Count;
      try
      {
        Count = Convert.ToInt32(textBox2.Text);
      }
      catch
      {
        ex.showDataEntryError();
        return;
      }

      dataGridView1.RowCount = Count;
      dataGridView1.ColumnCount = 2;

      string FuncType = comboBox1.Text;
      switch (FuncType)
      {
        case "Прямая":
          int x = r.Next(-Count, Count);
          int al = r.Next(-20, 20);
          int bl = r.Next(-50, 50);
          string LineFunction = al + "x + " + bl;
          StandartFunction lcalculate = new StandartFunction(LineFunction);
          for (int i = 0; i < Count; ++i)
          {
            x = r.Next(x - Count, x + Count);
            dataGridView1.Rows[i].Cells[0].Value = lcalculate.getFunction(x + r.Next(-Count, Count));
            dataGridView1.Rows[i].Cells[1].Value = x;
          }
          break;
        case "Парабола":
          int xp = -Count;
          int ap = r.Next(-Count/4, Count/4);
          int bp = r.Next(-Count/2, Count/2);
          int cp = r.Next(-Count, Count);
          string ParabolaFunction = ap + "x^2 + " + bp + "x + " + cp;
          StandartFunction pcalculate = new StandartFunction(ParabolaFunction);
          for (int i = 0; i < Count; ++i)
          {
            xp = r.Next(xp - Count, xp + Count);
            dataGridView1.Rows[i].Cells[0].Value = pcalculate.getFunction(xp + r.Next(-Count, Count));
            dataGridView1.Rows[i].Cells[1].Value = xp;
          }
          break;
        case "Гипербола":
          x = -40;
          int kh = r.Next(-20, 20);
          string HyperbolaFunction = kh + " / x";
          StandartFunction hcalculate = new StandartFunction(HyperbolaFunction);
          for (int i = 0; i < Count; ++i)
          {
            x = r.Next(x - Count, x + Count);
            dataGridView1.Rows[i].Cells[0].Value = hcalculate.getFunction(x + r.Next(-Count/2, Count/2));
            dataGridView1.Rows[i].Cells[1].Value = x;
          }
          break;
        case "Рандом": 
          for(int i = 0; i < Count; ++i)
          {
            int randomY = r.Next(-Count, Count);
            int randomX = r.Next(-Count, Count);
            dataGridView1.Rows[i].Cells[0].Value = randomY + r.NextDouble();
            dataGridView1.Rows[i].Cells[1].Value = randomX + r.NextDouble();
          }
          break;
        default:
          Console.WriteLine("Генерация указана неправильно");
          break;
      }
    }

    private void ClearFunc()
    {
      textBox3.Text = "";
      textBox4.Text = "";
      textBox5.Text = "";
      textBox6.Text = "";
      textBox8.Text = "";
    }

    private void ClearDate()
    {
      MassF = new List<double>();
      MassX = new List<double>();
      Start = new double();
      End = new double();
    }

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      chart1.Series.Clear();
      dataGridView1.Rows.Clear();
      ClearFunc();
    }

    private void нахождениеЛогарифмаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      FindIntegral FindIntegral = new FindIntegral(mainform);
      FindIntegral.Show();
    }
  }
}
