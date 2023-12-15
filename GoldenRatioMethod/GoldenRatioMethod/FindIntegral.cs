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
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GoldenRatioMethod
{
  public partial class FindIntegral : Form
  {
    MainForm mainform;
    string StringFunction;
    private double RestrictionStart, RestrictionEnd, Precision, Coefficient;
    int AccuracyForView;
    int NumberOfSteps;
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
      try
      {
        Coefficient = Convert.ToDouble(textBox3.Text);
        if(textBox3.Text == "" || textBox3.Text == " ")
        {
          Coefficient = 1;
        }
      }
      catch
      {
        textBox3.Text = "1";
        Coefficient = 1;
      }

      try
      {
        Function functionStart = new Function("f(x) = " + textBox1.Text);
        Function functionEnd = new Function("f(x) = " + textBox2.Text);

        RestrictionStart = functionStart.calculate();
        RestrictionEnd = functionEnd.calculate();
        Precision = Convert.ToDouble(textBox5.Text);

        if (Precision <= 0)
        {
          Precision = 1;
          ex.showPrecisionError();
        }
      }
      catch
      {
        ex.showDataEntryError();
      }

      try
      {
        NumberOfSteps = Convert.ToInt32(textBox6.Text);
        if(NumberOfSteps <= 0)
        {
          NumberOfSteps = 1;
          ex.showCountStepsError();
        }
      }
      catch
      {
        ex.showStepsError();
      }
    }

    private void setAccuracyForView()
    {
      try
      {
        double Accuracy = Math.Log10(Precision) * -1.0;
        AccuracyForView = Convert.ToInt32(Accuracy);
        if (AccuracyForView < 0)
        {
          AccuracyForView = 0;
        }
      }
      catch
      {
        ex.showPrecisionError();
      }
    }

    private bool CreateGrafVunction()
    {
      double x, y;
      CalculateFunction Function = new StandartFunction(StringFunction);
      if (RestrictionStart < RestrictionEnd)
      {
        x = RestrictionStart;
        this.chart1.Series[0].Points.Clear();
        this.Update();
        while (x <= RestrictionEnd)
        {
          y = Function.getFunction(x);
          if (y is double.NaN || y is double.PositiveInfinity || y is double.NegativeInfinity)
          {
            this.chart1.Series[0].Points.Clear();
            return false;
          }
          this.chart1.Series[0].Points.AddXY(x, y);
          this.Update();
          x += 1;
        }
        return true;
      }
      else
      {
        ex.showRestrictionsError();
        return false;
      }
    }

    private double Rectangle(double start, double end, double Splits)
    {
      StandartFunction f = new StandartFunction(StringFunction);
      double h = (end - start) / Splits;
      double sum = (f.getFunction(start) + f.getFunction(end)) / 2;

      for(double i = 1; i < Splits; i++)
      {
        double x = start + i * h;
        sum += f.getFunction(x);
      }

      double result = h * sum;
      return result;
    }

    private double Trapezoid(double start, double end, double Splits)
    {
      StandartFunction f = new StandartFunction(StringFunction);
      double h = (end - start) / Splits;
      double sum = f.getFunction(start) + f.getFunction(end);
      for(int i = 1; i <= Splits - 1; i++)
      {
        sum += 2 * f.getFunction(start + i * h);
      }
      sum *= h / 2;
      return sum;
    }

    private void RectangleMethod(double Splits)
    {
      double start = RestrictionStart;
      double end = RestrictionEnd;
      double result = Rectangle(start, end, Splits);

      double roundResult = Math.Truncate(result * Math.Pow(10, AccuracyForView)) / Math.Pow(10, AccuracyForView);
      Console.WriteLine("Прямоугольники: " + roundResult);
      textBox7.Text = roundResult.ToString();
    }

    private void TrapezoidMethod(double Splits)
    {
      double start = RestrictionStart;
      double end = RestrictionEnd;
      double result = Trapezoid(start, end, Splits);

      double roundResult = Math.Truncate(result * Math.Pow(10, AccuracyForView)) / Math.Pow(10, AccuracyForView);
      Console.WriteLine("Трапеции: " + roundResult);
      textBox8.Text = roundResult.ToString();
    }

    private double Simpson(double start, double end, double Splits)
    {
      double sumST = Trapezoid(start,end, Splits);
      double sumST2 = Trapezoid(start, end, Splits * 2);

      double result = Coefficient * (4 * sumST2 - sumST) / 3;
      return result;
    }

    private void SimpsondMethod (double Splits)
    {
      double start = RestrictionStart;
      double end = RestrictionEnd;
      double result = Simpson(start, end, Splits);

      double roundResult = Math.Truncate(result * Math.Pow(10, AccuracyForView)) / Math.Pow(10, AccuracyForView);
      Console.WriteLine("Симпсон: " + result);
      textBox9.Text = roundResult.ToString();
    }

    private void CalculationToPrecision()
    {
      StandartFunction function = new StandartFunction(StringFunction);
      double start = RestrictionStart;
      double end = RestrictionEnd;
      double Splits = 2;
      double roundSp = 0, roundSt = 0, roundSs = 0;

      label14.Visible = true;
      textBox6.Visible = true;

      while (true) {

        if(Splits >= 200)
        {
          break;
        }

        double Sp = Rectangle(start, end, Splits);
        double St = Trapezoid(start, end, Splits);
        double Ss = Simpson(start, end, Splits);

        roundSp = Math.Truncate(Sp * Math.Pow(10, AccuracyForView)) / Math.Pow(10, AccuracyForView);
        roundSt = Math.Truncate(St * Math.Pow(10, AccuracyForView)) / Math.Pow(10, AccuracyForView);
        roundSs = Math.Truncate(Ss * Math.Pow(10, AccuracyForView)) / Math.Pow(10, AccuracyForView);

        Console.WriteLine("шаг: " + Splits + "    прямоугольники: " + roundSp + "     трапеции: " + roundSt + "      симпсон: " + roundSs);

        textBox7.Text = roundSp.ToString();
        textBox8.Text = roundSt.ToString();
        textBox9.Text = roundSs.ToString();
        textBox6.Text = Splits.ToString();
        this.Update();

        if (roundSp == roundSt && roundSt == roundSs && roundSp == roundSs)
        {
          textBox7.Text = roundSp.ToString();
          textBox8.Text = roundSt.ToString();
          textBox9.Text = roundSs.ToString();
          break;
        }

        Splits += 1;
      }

      Console.WriteLine("Количество шагов: " + Splits);
      textBox7.Text = roundSp.ToString();
      textBox8.Text = roundSt.ToString();
      textBox9.Text = roundSs.ToString();

      Console.WriteLine("roundSp: " + roundSp + "     toString: " + roundSp.ToString());
      Console.WriteLine("roundSp: " + roundSt + "     toString: " + roundSt.ToString());
      Console.WriteLine("roundSp: " + roundSs + "     toString: " + roundSs.ToString());
    }

    private void IdealIntegral()
    {
      IntegralFunction i = new IntegralFunction(StringFunction);
      double ri = i.getIntegral(Coefficient, RestrictionStart, RestrictionEnd);
      ri = Math.Round(ri, 10);
      Console.WriteLine("Идеал: " + ri + "\n");
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

    private void ClearViewResult()
    {
      textBox7.Text = "";
      textBox8.Text = "";
      textBox9.Text = "";
    }

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ClearViewResult();
      this.chart1.Series[0].Points.Clear();
    }

    private void chart1_Click(object sender, EventArgs e)
    {

    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox4.Checked)
      {
        textBox6.Visible = false;
        label14.Visible = false;
        this.Update();
      }
      else
      {
        textBox6.Visible = true;
        label14.Visible = true;
        this.Update();
      }
    }

    private void сЛАУToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      SLAE slae = new SLAE(mainform);
      slae.Show();
    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      panel4.Visible = true;
      ClearViewResult();
      this.Update();
      setValues();
      setAccuracyForView();

      if (!CreateGrafVunction())
      {
        panel4.Visible = false;
        ex.showUncertaintyError();
        return;
      }

      if (checkBox4.Checked)
      {
        CalculationToPrecision();
      }
      else
      {
        if (checkBox1.Checked)
        {
          RectangleMethod(NumberOfSteps);
          this.Update();
        }
      }
      if (checkBox2.Checked)
      {
        TrapezoidMethod(NumberOfSteps);
        this.Update();

      }
      if (checkBox3.Checked)
      {
        SimpsondMethod(NumberOfSteps);
        this.Update();

      }
      IdealIntegral();

      panel4.Visible = false;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
