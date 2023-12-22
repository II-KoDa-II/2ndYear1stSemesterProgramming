using org.mariuszgromada.math.mxparser.mathcollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenRatioMethod
{
  class Program
  {
    [STAThreadAttribute]
    static void Main(string[] args)
    {
      Application.Run(new MainForm());
      Console.ReadKey();
    }
  }
}
