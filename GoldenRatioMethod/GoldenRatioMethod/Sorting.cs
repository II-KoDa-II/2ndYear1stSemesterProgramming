using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenRatioMethod
{
  public partial class Sorting : Form
  {
    MainForm mainform;
    List<int> NumberList = new List<int>();
    List<long> TimerList = new List<long>();
    List<int> IterationList = new List<int>();
    int IterationQuick;
    public Sorting(MainForm form)
    {
      InitializeComponent();
      mainform = form;
    }

    private void Sorting_Load(object sender, EventArgs e)
    {

    }

    private void BubbleSort(List<int> List, bool Ascending)
    {
      List<int> BubbleList = List;
      Stopwatch stopwatch = new Stopwatch();
      int Iteration = 0;
      stopwatch.Start();

      int temp = 0;
      for (int write = 0; write < BubbleList.Count; write++)
      {
        for (int sort = 0; sort < BubbleList.Count - 1; sort++)
        {
          if ((Ascending && BubbleList[sort] > BubbleList[sort + 1]) || (!Ascending && BubbleList[sort] < BubbleList[sort + 1]))
          {
            ++Iteration;
            temp = BubbleList[sort + 1];
            BubbleList[sort + 1] = BubbleList[sort];
            BubbleList[sort] = temp;
          }
        }
      }
      stopwatch.Stop();

      chart1.Series[0].Points.Clear();
      for (int index = 0; index < NumberList.Count; ++index)
      {
        chart1.Series[0].Points.AddXY(index, BubbleList[index]);
      }

      label2.Text = "Пузыри - " + stopwatch.ElapsedTicks.ToString() + "    " + Iteration;
      TimerList.Add(stopwatch.ElapsedTicks);
      IterationList.Add(Iteration);
    }


    private void InsertionSort(List<int> List, bool Ascending)
    {
      List<int> InsertionList = List;
      Stopwatch stopwatch = new Stopwatch();
      int Iteration = 0;
      stopwatch.Start();

      for (int index = 1; index < InsertionList.Count; index++)
      {
        int k = InsertionList[index];
        int j = index - 1;
        while (j >= 0 && ((Ascending && InsertionList[j] > k) || (!Ascending && InsertionList[j] < k)))
        {
          ++Iteration;
          InsertionList[j + 1] = InsertionList[j];
          InsertionList[j] = k;
          j--;
        }
      }

      stopwatch.Stop();

      chart1.Series[1].Points.Clear();
      for (int i = 0; i < InsertionList.Count; ++i)
      {
        chart1.Series[1].Points.AddXY(i, InsertionList[i]);
      }

      label3.Text = "Вставки - " + stopwatch.ElapsedTicks.ToString() + "    " + ++Iteration;
      TimerList.Add(stopwatch.ElapsedTicks);
      IterationList.Add(Iteration);
    }

    private void ShakerSort(List<int> List, bool Ascending)
    {
      List<int> ShakerList = List;
      Stopwatch stopwatch = new Stopwatch();
      int Iteration = 0;
      stopwatch.Start();

      int left = 0, right = ShakerList.Count - 1, c;
      do
      {
        ++Iteration;
        c = 0;
        for (int j = left; j < right; j++)
        {
          if ((Ascending && ShakerList[j] > ShakerList[j + 1]) || (!Ascending && ShakerList[j] < ShakerList[j + 1]))
          {

            int x = ShakerList[j];
            ShakerList[j] = ShakerList[j + 1];
            ShakerList[j + 1] = x;
            c = j;
          }
        }
        right = c;
        for (int j = right; j > left; j--)
        {
          if ((Ascending && ShakerList[j - 1] > ShakerList[j]) || (!Ascending && ShakerList[j - 1] < ShakerList[j]))
          {

            int x = ShakerList[j];
            ShakerList[j] = ShakerList[j - 1];
            ShakerList[j - 1] = x;
            c = j;
          }
        }
        left = c;
      } while (c != 0);
      stopwatch.Stop();

      chart1.Series[2].Points.Clear();
      for (int i = 0; i < NumberList.Count; ++i)
      {
        chart1.Series[2].Points.AddXY(i, ShakerList[i]);
      }

      label5.Text = "Шейкер - " + stopwatch.ElapsedTicks.ToString() + "    " + Iteration;
      TimerList.Add(stopwatch.ElapsedTicks);
      IterationList.Add(Iteration);
    }

    public void Sort(List<int> array, int left, int right, bool Ascending)
    {
      if (left < right)
      {
        ++IterationQuick;
        int pivotIndex = Partition(array, left, right, Ascending);
        Sort(array, left, pivotIndex - 1, Ascending);
        Sort(array, pivotIndex + 1, right, Ascending);
      }
    }

    private int Partition(List<int> array, int left, int right, bool Ascending)
    {
      int pivot = array[right];
      int i = (left - 1);

      for (int j = left; j < right; j++)
      {
        if ((Ascending && array[j] <= pivot) || (!Ascending && array[j] >= pivot))
        {
          i++;
          // Обмен элементов
          int temp = array[i];
          array[i] = array[j];
          array[j] = temp;
        }
      }
      // Обмен опорного элемента с элементом, находящимся на позиции i+1
      int swap = array[i + 1];
      array[i + 1] = array[right];
      array[right] = swap;

      return i + 1;
    }

    private void QuickSortRealise(List<int> List, bool Ascending)
    {
      List<int> QuickList = List;
      Stopwatch stopwatch = new Stopwatch();
      IterationQuick = 0;

      stopwatch.Start();
      Sort(QuickList, 0, QuickList.Count - 1, Ascending);
      stopwatch.Stop();

      chart1.Series[3].Points.Clear();
      for (int i = 0; i < NumberList.Count; ++i)
      {
        chart1.Series[3].Points.AddXY(i, QuickList[i]);
      }
      label6.Text = "Быстрая - " + stopwatch.ElapsedTicks.ToString() + "    " + IterationQuick;
      TimerList.Add(stopwatch.ElapsedTicks);
      IterationList.Add(IterationQuick);
    }

    private static bool IsSorted(List<int> data, bool Ascending)
    {
      int count = data.Count;

      for (int i = 1; i < count; i++)
      {
        if (Ascending)
        {
          if (data[i] < data[i - 1])
          {
            return false;
          }
        }
        else
        {
          if (data[i] > data[i - 1])
          {
            return false;
          }
        }
      }
      return true;
    }

    private static void Shuffle(List<int> data)
    {
      int temp, rnd;
      Random rand = new Random();

      for (int i = 0; i < data.Count; ++i)
      {
        rnd = rand.Next(data.Count);
        temp = data[i];
        data[i] = data[rnd];
        data[rnd] = temp;
      }
    }

    private void BogoSort(List<int> List, bool Ascending)
    {
      List<int> BogoList = List;
      Stopwatch stopwatch = new Stopwatch();
      int Iteration = 0;

      stopwatch.Start();
      while (!IsSorted(BogoList, Ascending))
      {
        if (Iteration >= 100000)
        {
          MessageBox.Show("Превышено количество итераций сортировки БОГО", "Стоп");
          break;
        }
        ++Iteration;
        Shuffle(BogoList);
      }
      stopwatch.Stop();

      chart1.Series[4].Points.Clear();
      for (int i = 0; i < NumberList.Count; ++i)
      {
        chart1.Series[4].Points.AddXY(i, BogoList[i]);
      }

      label7.Text = "BOGO - " + stopwatch.ElapsedTicks.ToString() + "    " + Iteration;
      TimerList.Add(stopwatch.ElapsedTicks);
      IterationList.Add(Iteration);
    }

    private void GetNumbersFromView()
    {
      string NumbersStrung = textBox1.Text;
      NumberList = new List<int>();

      if (NumbersStrung[textBox1.Text.Length - 1] != ' ')
      {
        NumbersStrung += ' ';
      }

      for (int index = 0; index < textBox1.Text.Length; ++index)
      {
        string strNum = "";
        while (NumbersStrung[index] != ' ')
        {
          strNum += NumbersStrung[index];
          ++index;
        }
        try
        {
          NumberList.Add(Convert.ToInt32(strNum));
        }
        catch
        {
          Console.WriteLine("Строка введена не верно");
        }
      }
    }

    private void startToolStripMenuItem_Click(object sender, EventArgs e)
    {
      TimerList = new List<long>();
      IterationList = new List<int>();
      bool AscendingKey = true;

      if (radioButton2.Checked)
      {
        AscendingKey = false;
      }

      if (checkBox1.Checked)
      {
        GetNumbersFromView();
        BubbleSort(NumberList, AscendingKey);
      }
      if (checkBox2.Checked)
      {
        GetNumbersFromView();
        InsertionSort(NumberList, AscendingKey);
      }
      if (checkBox3.Checked)
      {
        GetNumbersFromView();
        ShakerSort(NumberList, AscendingKey);
      }
      if (checkBox4.Checked)
      {
        GetNumbersFromView();
        QuickSortRealise(NumberList, AscendingKey);
      }
      if (checkBox5.Checked)
      {
        if (NumberList.Count > 5)
        {
          GetNumbersFromView();
          BogoSort(NumberList, AscendingKey);
        }
        else
        {
          GetNumbersFromView();
          BogoSort(NumberList, AscendingKey);
        }
      }

      textBox3.Text = "";
      textBox2.Text = "";

      if (TimerList.Count > 0 && IterationList.Count > 0)
      {
        textBox3.Text = Convert.ToString(TimerList.Min());
        textBox2.Text = Convert.ToString(IterationList.Min());
      }
    }

    private void оКToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int ArraySize = 0;
      int MaxNumber = 1;
      int MinNumber = 0;
      try
      {
        ArraySize = Convert.ToInt32(toolStripTextBox1.Text);
        MaxNumber = Convert.ToInt32(toolStripTextBox2.Text);
        MinNumber = Convert.ToInt32(toolStripTextBox3.Text);
      }
      catch
      {
        Console.WriteLine("Некорректный ввод");
      }
      finally
      {
        if (MaxNumber < MinNumber)
        {
          Console.WriteLine("Максимальное число должно быть больше минимального");
          MaxNumber = 1;
          MinNumber = 0;
        }
      }

      Random r = new Random();
      for (int index = 0; index < ArraySize; ++index)
      {
        textBox1.Text += r.Next(MinNumber, MaxNumber) + " ";
      }

      for (int index = 0; index < 5; ++index)
      {
        chart1.Series[index].Points.Clear();
      }
      GetNumbersFromView();
      for (int index = 0; index < NumberList.Count; ++index)
      {
        chart1.Series[0].Points.AddXY(index, NumberList[index]);
        chart1.Series[1].Points.AddXY(index, NumberList[index]);
        chart1.Series[2].Points.AddXY(index, NumberList[index]);
        chart1.Series[3].Points.AddXY(index, NumberList[index]);
        chart1.Series[4].Points.AddXY(index, NumberList[index]);
      }
    }

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (NumberList.Count > 0)
      {
        NumberList.Clear();
      }

      if (TimerList.Count > 0)
      {
        TimerList.Clear();
      }

      for (int i = 0; i < 5; ++i)
      {
        chart1.Series[i].Points.Clear();
      }

      textBox1.Text = "";
      textBox3.Text = "";
      label2.Text = "Пузыри";
      label3.Text = "Вставки";
      label5.Text = "Шейкер";
      label6.Text = "Быстрая";
      label7.Text = "BOGO";
    }

    private void OKbutton_Click(object sender, EventArgs e)
    {
      if (checkBox1.Checked)
      {
        chart1.Series[0].Enabled = true;
      }
      else
      {
        chart1.Series[0].Enabled = false;
      }
      if (checkBox2.Checked)
      {
        chart1.Series[1].Enabled = true;
      }
      else
      {
        chart1.Series[1].Enabled = false;
      }
      if (checkBox3.Checked)
      {
        chart1.Series[2].Enabled = true;
      }
      else
      {
        chart1.Series[2].Enabled = false;
      }
      if (checkBox4.Checked)
      {
        chart1.Series[3].Enabled = true;
      }
      else
      {
        chart1.Series[3].Enabled = false;
      }
      if (checkBox5.Checked)
      {
        chart1.Series[4].Enabled = true;
      }
      else
      {
        chart1.Series[4].Enabled = false;
      }
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void назадToolStripMenuItem_Click(object sender, EventArgs e)
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
      FindIntegral FindIntegral = new FindIntegral(mainform);
      FindIntegral.Show();
    }
  }
}