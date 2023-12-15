﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace GoldenRatioMethod
{
  abstract class CalculateFunction
  {
    public virtual double getFunction(double x)
    {
      return x;
    }
  }
  class StandartFunction : CalculateFunction
  {
    string StringFunction;

    public StandartFunction(string func)
    {
      this.StringFunction = "f(x) = " + func;
    }
    public override double getFunction(double x)
    {
      Function function = new Function(StringFunction);
      double Result = function.calculate(x);
      return Result;
    }
  }

  class MinusFunction : CalculateFunction
  {
    string StringFunction;
    public MinusFunction(string func)
    {
      this.StringFunction = "f(x) = (" + func + ") * -1.0";
    }
    public override double getFunction(double x)
    {
      Function function = new Function(StringFunction);
      double Result = function.calculate(x);
      return Result;
    }
  }

  class AbsFunction : CalculateFunction
  {
    string StringFunction;
    public AbsFunction(string func)
    {
      this.StringFunction = "f(x) = abs(" + func + ")";
    }
    public override double getFunction(double x)
    {
      Function function = new Function(StringFunction);
      double Result = function.calculate(x);
      return Result;
    }
  }

  class DerivFunction : CalculateFunction
  {
    string StringFunction;

    public DerivFunction(string func)
    {
      this.StringFunction = func;
    }

    public double getDeriv(double x)
    {
      string xs = x.ToString();
      Expression ex = new Expression("der(" + StringFunction + ", x, " + xs.Replace(',', '.') + ")");
      return ex.calculate();
    }
  }

  class IntegralFunction : CalculateFunction
  {
    string StringFunction;

    public IntegralFunction(string func)
    {
      this.StringFunction = func;
    }

    public double getIntegral(double a, double start, double end)
    {
      Expression ex = new Expression(a + " * int(" + StringFunction + ", x," + start + ", " + end + ")");
      return ex.calculate();
    }
  }
}
