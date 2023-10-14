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
  public partial class MainForm : Form
  {
    private double RestrictionStart, RestrictionEnd, Precision;
    private double x, y;
    string StringFunction;
    Exceptions ex = new Exceptions();
    public MainForm()
    {
      InitializeComponent();
    }

    private double GoldenRatioMethod(CalculateFunction func)
    {
      const double Phi = 1.61803;
      double Start = RestrictionStart;
      double End = RestrictionEnd;

      double h = End - Start;
      double c = End - h / Phi;
      double d = Start + h / Phi;
      double fc = func.getFunction(c);
      double fd = func.getFunction(d);

      while (Math.Abs(fc - fd) > Precision)
      {
        if (fc < fd)
        {
          End = d;
          d = c;
          c = End - (End - Start) / Phi;
          fd = fc;
          fc = func.getFunction(c);
        }
        else
        {
          Start = c;
          c = d;
          d = Start + (End - Start) / Phi;
          fc = fd;
          fd = func.getFunction(d);
        }
      }
      return (Start + End) / 2;
    }

    private void FindIntersectionPoints()
    {
      double Accuracy = Math.Log10(Precision) * -1.0;
      int AccuracyForView = Convert.ToInt32(Accuracy);
      if(AccuracyForView < 0)
      {
        AccuracyForView = 0;
      }
      
 
      CalculateFunction Function = new AbsFunction(StringFunction);
      textBox4.Text = Convert.ToString(Math.Round(GoldenRatioMethod(Function), AccuracyForView));
      textBox8.Text = Convert.ToString(Function.getFunction(GoldenRatioMethod(Function)));
    }

    private void FindTheMinimum()
    {
      CalculateFunction Function = new StandartFunction(StringFunction);
      textBox5.Text = Convert.ToString(GoldenRatioMethod(Function));
    }

    private void FindTheMaximum()
    {
      CalculateFunction Function = new MinusFunction(StringFunction);
      textBox6.Text = Convert.ToString(GoldenRatioMethod(Function));
    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CalculateFunction Function = new StandartFunction(StringFunction);
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
        Exceptions ex = new Exceptions();
        ex.showRestrictionsError();
      }
      FindIntersectionPoints();
      FindTheMinimum();
      FindTheMaximum();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        StringFunction = textBox1.Text;
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
        RestrictionStart = Convert.ToDouble(textBox3.Text);
        RestrictionEnd = Convert.ToDouble(textBox2.Text);
        Precision = Convert.ToDouble(textBox7.Text);
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
  }
}
