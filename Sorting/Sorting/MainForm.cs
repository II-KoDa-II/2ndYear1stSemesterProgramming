using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.CSharp;

namespace Sorting
{
  public partial class MainForm : Form
  {
    List<int> NumberList = new List<int>();
    List<long> TimerList = new List<long>();
    public MainForm()
    {
      InitializeComponent();
    }

    private void BubbleSort()
    {
      List<int> BubbleList = NumberList;
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int temp = 0;
      for(int write = 0; write < BubbleList.Count; write++)
      {
        for(int sort = 0; sort < BubbleList.Count - 1; sort++)
        {
          if (BubbleList[sort] > BubbleList[sort + 1])
          {
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

      label2.Text = "Пузыри - " + stopwatch.ElapsedTicks.ToString();
      TimerList.Add(stopwatch.ElapsedTicks);
    }

    private void InsertionSort()
    {
      List<int> InsertionList = NumberList;
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      for(int index = 1; index < InsertionList.Count; index++)
      {
        int k = InsertionList[index];
        int j = index - 1;
         while(j >= 0 && InsertionList[j] > k)
        {
          InsertionList[j + 1] = InsertionList[j];
          j--;
        }
        InsertionList[j] = k;
      }
      stopwatch.Stop();

      chart1.Series[1].Points.Clear();
      for (int i = 0; i < NumberList.Count; ++i)
      {
        chart1.Series[1].Points.AddXY(i, InsertionList[i]);
      }

      label3.Text = "Вставки - " + stopwatch.ElapsedTicks.ToString();
      TimerList.Add(stopwatch.ElapsedTicks);
    }

    private void ShakerSort()
    {
      List<int> ShakerList = NumberList;
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      int left = 0, right = ShakerList.Count - 1, c;
      do
      {
        c = 0;
        for (int j = left; j < right; j++)
        {
          if (ShakerList[j] > ShakerList[j + 1])
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
          if (ShakerList[j - 1] > ShakerList[j])
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
      label5.Text = "Шейкер - " + stopwatch.ElapsedTicks.ToString();
      TimerList.Add(stopwatch.ElapsedTicks);
    }

    public static void Sort(List<int> array, int low, int high)
    {
      if (low < high)
      {
        int pivotIndex = Partition(array, low, high);
        Sort(array, low, pivotIndex);
        Sort(array, pivotIndex + 1, high);
      }
    }

    private static int Partition(List<int> array, int low, int high)
    {
      int pivot = array[low];
      int i = low - 1;
      int j = high + 1;

      while (true)
      {
        do
        {
          i++;
        } while (array[i] < pivot);

        do
        {
          j--;
        } while (array[j] > pivot);

        if (i >= j)
          return j;

        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
      }
    }

    private void QuickSortRealise()
    {
      List<int> QuickList = NumberList;
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      Sort(QuickList, 0, QuickList.Count - 1);
      stopwatch.Stop();

      chart1.Series[3].Points.Clear();
      for (int i = 0; i < NumberList.Count; ++i)
      {
        chart1.Series[3].Points.AddXY(i, QuickList[i]);
      }

      label6.Text = "Быстрая - " + stopwatch.ElapsedTicks.ToString();
      TimerList.Add(stopwatch.ElapsedTicks);
    }

    private static bool IsSorted(List<int> data)
    {
      int count = data.Count;

      while (--count >= 1)
      {
        if (data[count] < data[count - 1])
        {
          return false;
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

    private void BogoSort()
    {
      List<int> BogoList = NumberList;
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      while (!IsSorted(BogoList))
      {
        Shuffle(BogoList);
      }
      stopwatch.Stop();

      chart1.Series[4].Points.Clear();
      for (int i = 0; i < NumberList.Count; ++i)
      {
        chart1.Series[4].Points.AddXY(i, BogoList[i]);
      }

      label7.Text = "BOGO - " + stopwatch.ElapsedTicks.ToString();
      TimerList.Add(stopwatch.ElapsedTicks);
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void startToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (checkBox1.Checked)
      {
        BubbleSort();
      }
      if (checkBox2.Checked)
      {
        InsertionSort();
      }
      if (checkBox3.Checked)
      {
        ShakerSort();
      }
      if (checkBox4.Checked)
      {
        QuickSortRealise();
      }
      if (checkBox5.Checked)
      {
        if(NumberList.Count > 5)
        {
          DialogResult dialogResult = MessageBox.Show("Внимание, BOGO сортировка большого массива может занять длительное время, вы уверены что хотите продолжить ?", "Предупреждение", MessageBoxButtons.YesNo);
          if(dialogResult == DialogResult.Yes)
          {
            BogoSort();
          }
        }
        else
        {
          BogoSort();
        }
      }
      textBox3.Text = "";
      if(TimerList.Count > 0)
      {
        textBox3.Text = Convert.ToString(TimerList.Min());
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void сгенерироватьToolStripMenuItem_Click(object sender, EventArgs e)
    {

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
        Console.WriteLine("Некорректный ввод ");
      }

      Random r = new Random();
      for(int index = 0; index < ArraySize; ++index)
      {
        NumberList.Add(r.Next(MinNumber, MaxNumber));
      }
      
      foreach(int o in NumberList)
      {
        textBox1.Text += o.ToString() + " ";
      }

      for(int index = 0; index < 5; ++index)
      {
        chart1.Series[index].Points.Clear();
      }
      for (int index = 0; index < NumberList.Count; ++index)
      {
        chart1.Series[0].Points.AddXY(index, NumberList[index]);
        chart1.Series[1].Points.AddXY(index, NumberList[index]);
        chart1.Series[2].Points.AddXY(index, NumberList[index]);
        chart1.Series[3].Points.AddXY(index, NumberList[index]);
        chart1.Series[4].Points.AddXY(index, NumberList[index]);
      }
    }

    private void toolStripTextBox1_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      NumberList.Clear();
      TimerList.Clear();
      for(int i = 0; i < 5; ++i)
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

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      
    }

    private void chart1_Click(object sender, EventArgs e)
    {

    }

    private void укажитеМинимумToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
  }
}
