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
    private short MethodsKey;
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
      try
      {
        double Accuracy = Math.Log10(Precision) * -1.0;
        AccuracyForView = Convert.ToInt32(Accuracy);
        if (AccuracyForView < 0)
        {
          AccuracyForView = 0;
        }
        Console.WriteLine("Точность - " + AccuracyForView);
      }
      catch 
      {
        ex.showPrecisionError2();
      }
    }

    private void LableClear()
    {
      textBox4.Text = "";
      textBox5.Text = "";
      textBox6.Text = "";
      textBox8.Text = "";
    }

    private void OffAllResults()
    {
      PointViewOff();
      ExtremumViewOff();
    }

    private void PointViewOff()
    {
      label5.Visible = false;
      label9.Visible = false;
      textBox4.Visible = false;
      textBox8.Visible = false;
    }

    private void PointViewOn()
    {
      label5.Visible = true;
      label9.Visible = true;
      textBox4.Visible = true;
      textBox8.Visible = true;
    }

    private void ExtremumViewOff()
    {
      label6.Visible = false;
      label7.Visible = false;
      textBox5.Visible = false;
      textBox6.Visible = false;
    }

    private void ExtremumViewOn()
    {
      label6.Visible = true;
      label7.Visible = true;
      textBox5.Visible = true;
      textBox6.Visible = true;
    }

    private double newtons(CalculateFunction func, DerivFunction derv)
    {
      double x0, xn,  xnp1;
      x0 = RestrictionEnd;
      xn = x0 - (func.getFunction(x0) / derv.getDeriv(x0));
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
      return Math.Round((Start + End) / 2.0, AccuracyForView);
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

    private void FindIntersectionPointsGolden()
    {
      CalculateFunction Function = new AbsFunction(StringFunction);
      double Root = GoldenRatioMethod(Function);
      double f0 = Function.getFunction(Root);
      Console.WriteLine("Gold: Root = " + Root + ",   f(x) = " + f0);

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

    private void FindIntersectionPointsDichotomy()
    {
      CalculateFunction Function = new AbsFunction(StringFunction);
      double Root = FindIntersectionPointsDichotomy(Function);
      double f0 = Function.getFunction(Root);
      Console.WriteLine("Dichotomy: Root = " + Root + ",   f(x) = " + f0);

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

    private void FindIntersectionPointsHewton()
    {
      CalculateFunction Function = new StandartFunction(StringFunction);
      DerivFunction DerivFunction = new DerivFunction(StringFunction);

      double Root = newtons(Function, DerivFunction);
      double f0 = Function.getFunction(Root);
      Console.WriteLine("Newton: Root = " + Root + ",   f(x) = " + f0);

      if (Root < RestrictionStart || Root > RestrictionEnd)
      {
        textBox4.Text = "Не удалось найти";
        textBox8.Text = "Нет";
        return;
      }

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

    private bool CreateGrafFunction()
    {
      CalculateFunction Function = new StandartFunction(StringFunction);
      if (RestrictionStart < RestrictionEnd)
      {
        x = RestrictionStart;
        this.chart1.Series[0].Points.Clear();
        this.Update();
        while (x <= RestrictionEnd)
        {
          if(Function.getFunction(x) is double.NaN || Function.getFunction(x) is double.PositiveInfinity || Function.getFunction(x) is double.NegativeInfinity)
          {
            ex.showUncertaintyError();
            return false;
          }

          y = Function.getFunction(x);
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

      if (!CreateGrafFunction())
      {
        return;
      }
      OffAllResults();
      LableClear();
      SetAccuracy();
      switch (MethodsKey)
      {
        case 1:
          PointViewOn();
          FindIntersectionPointsDichotomy();
          break;
        case 2:
          PointViewOn();
          ExtremumViewOn();
          FindIntersectionPointsGolden();
          FindTheMinimumGolden();
          FindTheMaximumGolden();
          break;
        case 3:
          PointViewOn();
          FindIntersectionPointsHewton();
          break;
        case 4:
          ExtremumViewOn();
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

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void дихотомияToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MethodsKey = 1;
      label11.Text = "Метод дихотомии";
    }

    private void золотоеСечениеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MethodsKey = 2;
      label11.Text = "Золотое сечение";
    }

    private void методНьютонаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MethodsKey = 3;
      label11.Text = "Метод Ньютона";
    }

    private void координатныйСпускToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MethodsKey = 4;
      label11.Text = "Координатный спуск";
    }

    private void сортировкиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Sorting SortingForm = new Sorting(this);
      this.Hide();
      SortingForm.Show();
    }

    private void нахождениеЛогарифмаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FindIntegral FindIntegral = new FindIntegral(this);
      this.Hide();
      FindIntegral.Show();
    }

    private void сЛАУToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SLAE slae = new SLAE(this);
      this.Hide();
      slae.Show();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
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
