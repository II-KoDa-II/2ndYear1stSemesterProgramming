using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenRatioMethod
{
  public partial class FindIntegral : Form
  {
    MainForm mainform;
    string StringFunction;
    private short MethodsKey;
    private double RestrictionStart, RestrictionEnd, Precision, Coefficient;
    int AccuracyForView;
    Exceptions ex = new Exceptions();
    public FindIntegral(MainForm form)
    {
      InitializeComponent();
      mainform = form;
    }

    private void setValues()
    {
      try
      {
        StringFunction = textBox4.Text;
        Function f = new Function("f(x) = " + StringFunction);
        if (double.IsNaN(f.calculate(1)))
        {
          throw new Exception();
        }
      }
      catch
      {
        ex.showFunctionError();
      }

      Coefficient = 1;

      try
      {
        RestrictionStart = Convert.ToDouble(textBox1.Text);
        RestrictionEnd = Convert.ToDouble(textBox2.Text);
        Precision = Convert.ToDouble(textBox5.Text);
      }
      catch
      {
        ex.showDataEntryError();
      }
      if (Precision <= 0)
      {
        ex.showPrecisionError();
      }
    }

    private void CreateGrafVunction()
    {
      double x, y;
      CalculateFunction Function = new StandartFunction(Coefficient.ToString() + " * (" + StringFunction + ")");
      if (RestrictionStart < RestrictionEnd)
      {
        x = RestrictionStart;
        this.chart1.Series[0].Points.Clear();
        while (x <= RestrictionEnd)
        {
          y = Function.getFunction(x);
          this.chart1.Series[0].Points.AddXY(x, y);
          x += 1;
        }
      }
      else
      {
        ex.showRestrictionsError();
      }
    }

    private void RectangleMethod()
    {
      StandartFunction function = new StandartFunction(StringFunction);
      double start = RestrictionStart;
      double end = RestrictionEnd;
      double sumS = 0;

      while(start <= end - Precision)
      {
        double nextStep = function.getFunction(start + Precision);
        sumS += nextStep * Precision;
        start += Precision;
      }

      sumS = sumS * Coefficient;
      label11.Text = sumS.ToString();
      Console.WriteLine("Прямоугольники: " + sumS);
    }

    private void TrapezoidMethod()
    {
      StandartFunction function = new StandartFunction(StringFunction);
      double start = RestrictionStart;
      double end = RestrictionEnd;
      double sumS = 0;

      while (start <= end - Precision)
      {
        double nextStep = function.getFunction(start + Precision);
        double currentStep = function.getFunction(start);
        sumS += (nextStep + currentStep) * Precision / 2.0;
        start += Precision;
      }

      sumS = sumS * Coefficient;
      label10.Text = sumS.ToString();
      Console.WriteLine("Трапеции: " + sumS);
    }

    private void SimpsondMethod()
    {
      StandartFunction function = new StandartFunction(StringFunction);
      double start = RestrictionStart;
      double end = RestrictionEnd;
      double sumS = 0;
      double n = (Math.Abs(start) + Math.Abs(end)) / Precision;
      double h = (end - start) / n;
      double x = start + h;

      while(x < end)
      {
        sumS += 4 * function.getFunction(x);
        x += h;
        sumS += 2 * function.getFunction(x);
        x += h;
      }
      sumS = h / 3 * (sumS + function.getFunction(start) - function.getFunction(end));

      sumS = sumS * Coefficient;
      label9.Text = sumS.ToString();
      Console.WriteLine("Симпсон: " + sumS);
    }

    private void IdealIntegral()
    {
      IntegralFunction i = new IntegralFunction(StringFunction);
      double ri = i.getIntegral(Coefficient, RestrictionStart, RestrictionEnd);
      label17.Text = ri.ToString();
      Console.WriteLine("\nИдеал: " + ri);
    }

    private void ClearViewResult()
    {
      label9.Text = "_____________";
      label10.Text = "_____________";
      label11.Text = "_____________";
      label17.Text = "_____________";
    }

    private void FindIntegral_Load(object sender, EventArgs e)
    {

    }

    private void назадToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.Close();
      mainform.Show();
    }

    private void нахождениеЛогарифмаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      Sorting sorting = new Sorting(mainform);
      sorting.Show();
    }

    private void chart1_Click(object sender, EventArgs e)
    {

    }

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ClearViewResult();
      this.Update();
      setValues();
      CreateGrafVunction();

      IdealIntegral();

      if (checkBox1.Checked)
      {
        RectangleMethod();
        this.Update();
      }
      if (checkBox2.Checked)
      {
        TrapezoidMethod();
        this.Update();
      }
      if (checkBox3.Checked)
      {
        SimpsondMethod();
        this.Update();
      }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
