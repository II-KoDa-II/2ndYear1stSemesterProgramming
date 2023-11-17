using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace GoldenRatioMethod
{
  public partial class MainForm : Form
  {
    private short MethodsKey = 4;
    private double RestrictionStart, RestrictionEnd, Precision;
    private double x, y;
    string StringFunction;
    int AccuracyForView;
    Exceptions ex = new Exceptions();
    public MainForm()
    {
      InitializeComponent();
    }

    private void SetAccuracy()
    {
      double Accuracy = Math.Log10(Precision) * -1.0;
      AccuracyForView = Convert.ToInt32(Accuracy);
      if (AccuracyForView < 0)
      {
        AccuracyForView = 0;
      }
      Console.WriteLine("Точность - " + AccuracyForView);
    }

    private void LableClear()
    {
      textBox5.Text = "";
      textBox6.Text = "";
    }

    private double newtons(CalculateFunction func, DerivFunction derv)
    {
      double x0, xn,  xnp1;
      x0 = RestrictionEnd;
      xn = x0 - (func.getFunction(x0)/ derv.getDeriv(x0));
      xnp1 = xn - (func.getFunction(xn) / derv.getDeriv(xn));

      while (xn - xnp1 >= Precision)
      {
        xn = xnp1;
        xnp1 = xn - (func.getFunction(xn) / derv.getDeriv(xn));
      }
      return xnp1;
    }

    private double GoldenRatioMethod(CalculateFunction func)
    {
      double Start = RestrictionStart;
      double End = RestrictionEnd;
      double z = (3 - Math.Sqrt(5)) / 2;
      double x1 = Start + z * (End - Start);
      double x2 = End - z * (End - Start);

      while(Math.Abs(End - Start) > Precision)
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
      return(x);
    }

    private double FindIntersectionPointsDichotomy(CalculateFunction func)
    {
      double Start = RestrictionStart;
      double End = RestrictionEnd;

      while (Math.Abs(End - Start) > Precision)
      {
        double MidPoint = (Start + End) / 2.0;
        if (func.getFunction(End) * func.getFunction(MidPoint) < 0)
        {
          Start = MidPoint;
        }
        else
        {
          End = MidPoint;
        }
      }

      double Accuracy = Math.Log10(Precision) * -1.0;
      int AccuracyForView = Convert.ToInt32(Accuracy);
      if (AccuracyForView < 0)
      {
        AccuracyForView = 0;
      }
      return Math.Round((Start + End) / 2.0);
    }

    private double CoordinateDescent(CalculateFunction func)
    {
      double Start = RestrictionStart;
      double End = RestrictionEnd;
      double x = (Start + End)/2;

      while (true)
      {
        if (x - Precision <= Start || x + Precision >= End)
        {
          break;
        }

        if(func.getFunction(x) > func.getFunction(x - Precision))
        {
          x -= Precision;
        }
        else if(func.getFunction(x) > func.getFunction(x + Precision))
        {
          x += Precision; 
        }
        else
        {
          break;
        }
      }
      Console.WriteLine("Спуск: " + x);
      return (x);
    }

    private void FindTheMinimumGolden()
    {
      CalculateFunction Function = new StandartFunction(StringFunction);
      textBox5.Text = Convert.ToString(Math.Round(GoldenRatioMethod(Function), AccuracyForView));
    }

    private void FindTheMinimumCoordinateMethod()
    {
      CalculateFunction Function = new StandartFunction(StringFunction);
      textBox5.Text = Convert.ToString(Math.Round(CoordinateDescent(Function), AccuracyForView));
    }

    private void FindTheMaximumCoordinateMethod()
    {
      CalculateFunction Function = new MinusFunction(StringFunction);
      textBox6.Text = Convert.ToString(Math.Round(CoordinateDescent(Function), AccuracyForView));
    }

    private void FindTheMaximumGolden()
    {
      CalculateFunction Function = new MinusFunction(StringFunction);
      textBox6.Text = Convert.ToString(Math.Round(GoldenRatioMethod(Function), AccuracyForView));
    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
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
        ex.showRestrictionsError();
      }
      LableClear();
      SetAccuracy();
      switch (MethodsKey)
      {
        case 4:
          FindTheMinimumCoordinateMethod();
          FindTheMaximumCoordinateMethod();
          break;
        default:
          ex.showSelectedMethodError();
          break;
      }
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

		private void label2_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
