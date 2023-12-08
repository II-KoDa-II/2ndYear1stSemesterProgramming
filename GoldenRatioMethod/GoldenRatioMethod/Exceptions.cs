using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenRatioMethod
{
  class Exceptions
  {
    private string FunctionError = "Функция введена неверно";
    private string PrecisionError = "Точность указана неверно";
    private string DataEntryError = "Данные введены в неверном формате";
    private string RestrictionsError = "Начальная точка должна быть меньше конечной";
    private string SelectedMethodError = "Метод не выбран";
    private string PrecisionError2 = "Неудалось преобразовать точность";
    private string CoefficientError = "Неправильно задан коэффицент. Коэффицент будет задан по умолчанию";

    public void showPrecisionError()
    {
      Console.WriteLine($"Ошибка: " + PrecisionError);
    }

    public void showDataEntryError()
    {
      Console.WriteLine($"Ошибка: " + DataEntryError);
    }

    public void showRestrictionsError()
    {
      Console.WriteLine($"Ошибка: " + RestrictionsError);
    }

    public void showFunctionError()
    {
      Console.WriteLine($"Ошибка: " + FunctionError);
    }

    public void showSelectedMethodError()
    {
      Console.WriteLine($"Ошибка: " + SelectedMethodError);
    }
    public void showPrecisionError2()
    {
      Console.WriteLine($"Ошибка: " + PrecisionError2);
    }
    public void showCoefficientError()
    {
      Console.WriteLine($"Ошибка: " + CoefficientError);
    }
  }
}

