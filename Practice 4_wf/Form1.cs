using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_4_wf
{
  public partial class Form1 : Form
  {

    static List<Thread> threads = new List<Thread>();
    private static ManualResetEvent th1_Reset = new ManualResetEvent(true);// Для ручной остановки потоков
    private static ManualResetEvent th2_Reset = new ManualResetEvent(true);
    private static ManualResetEvent th3_Reset = new ManualResetEvent(true);
    static bool th1_isSleep, th2_isSleep = true, th3_isSleep = true; // Проверка потоков


    private void ToLabel(Label label, string text)
    {
      if (InvokeRequired)
        label.Invoke(new Action(() => label.Text = text));
      else
        label.Text = text;
    }

    public void progModule1()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      string alpha;
      for (UInt64 i = UInt64.MinValue; i < UInt64.MaxValue; i++)
        for (UInt64 j = UInt64.MinValue; j < UInt64.MaxValue; j++)
          for (UInt64 k = UInt64.MinValue; k < UInt64.MaxValue; k++)
            for (UInt64 l = UInt64.MinValue; l < UInt64.MaxValue; l++)
              for (UInt64 m = UInt64.MinValue; m < UInt64.MaxValue; m++)
              {
                th1_Reset.WaitOne();
                alpha = Convert.ToString(i);
                alpha = Convert.ToString(j);
                alpha = Convert.ToString(k);
                alpha = Convert.ToString(l);
                alpha = Convert.ToString(m);
                if (stopwatch.ElapsedMilliseconds >= 3000)
                {
                  stopwatch.Reset();

                  ToLabel(label1_inProcess, "");
                  ToLabel(label1_inQueue, "Поток 1");
                  ToLabel(label1_inWait, "");
                  ToLabel(label1_isDone, "");
                  Thread.Sleep(3000);
                }else if(stopwatch.ElapsedMilliseconds == 0)
                {
                  stopwatch.Start();
                  ToLabel(label1_inProcess, "Поток 1");
                  ToLabel(label1_inQueue, "");
                  ToLabel(label1_inWait, "");
                  ToLabel(label1_isDone, "");
                }
              }
      label1_inProcess.Text = "";
      label1_inQueue.Text = "";
      label1_inWait.Text = "";
      label1_isDone.Text = "Поток 1";
    }
    public void progModule2()
    {
      string betta;
      for (UInt32 i = UInt32.MinValue; i < UInt32.MaxValue; i++)
        for (UInt32 j = UInt32.MinValue; j < UInt32.MaxValue; j++)
          for (UInt32 k = UInt32.MinValue; k < UInt32.MaxValue; k++)
            for (UInt32 l = UInt32.MinValue; l < UInt32.MaxValue; l++)
              for (UInt32 m = UInt32.MinValue; m < UInt32.MaxValue; m++)
              {
                th2_Reset.WaitOne();
                betta = Convert.ToString(i);
                betta = Convert.ToString(j);
                betta = Convert.ToString(k);
                betta = Convert.ToString(l);
                betta = Convert.ToString(m);
              }
      label2_inProcess.Text = "";
      label2_inQueue.Text = "";
      label2_inWait.Text = "";
      label2_isDone.Text = "Поток 2";
    }
    public void progModule3()
    {
      string gamma;
      for (UInt16 i = UInt16.MinValue; i < UInt16.MaxValue; i++)
        for (UInt16 j = UInt16.MinValue; j < UInt16.MaxValue; j++)
          for (UInt16 k = UInt16.MinValue; k < UInt16.MaxValue; k++)
            for (UInt16 l = UInt16.MinValue; l < UInt16.MaxValue; l++)
              for (UInt16 m = UInt16.MinValue; m < UInt16.MaxValue; m++)
              {
                th3_Reset.WaitOne();
                gamma = Convert.ToString(i);
                gamma = Convert.ToString(j);
                gamma = Convert.ToString(k);
                gamma = Convert.ToString(l);
                gamma = Convert.ToString(m);
              }
      label3_inProcess.Text = "";
      label3_inQueue.Text = "";
      label3_inWait.Text = "";
      label3_isDone.Text = "Поток 3";
    }


    public Form1()
    {
      InitializeComponent();
    }

    private void button_blockThread1_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[0].IsAlive && !th1_isSleep)
        {
          th1_isSleep = true;
          th1_Reset.Reset();
          button_blockThread1.Text = "Разблокировать поток 1";
          label1_inProcess.Text = "";
          label1_inQueue.Text = "";
          label1_inWait.Text = "Поток 1";
          label1_isDone.Text = "";
        }
        else
      if (threads[0].IsAlive && th1_isSleep)
        {
          th1_isSleep = false;
          th1_Reset.Set();
          button_blockThread1.Text = "Заблокировать поток 1";
          label1_inProcess.Text = "";
          label1_inQueue.Text = "Поток 1";
          label1_inWait.Text = "";
          label1_isDone.Text = "";
        }
      }
      catch { }  
    }

    private void button_blockThread2_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[1].IsAlive && !th2_isSleep)
        {
          th2_isSleep = true;
          th2_Reset.Reset();
          button_blockThread2.Text = "Разблокировать поток 2";
          label2_inProcess.Text = "";
          label2_inQueue.Text = "";
          label2_inWait.Text = "Поток 2";
          label2_isDone.Text = "";
        }
        else
      if (threads[1].IsAlive && th2_isSleep)
        {
          th2_isSleep = false;
          th2_Reset.Set();
          button_blockThread2.Text = "Заблокировать поток 2";
          label2_inProcess.Text = "";
          label2_inQueue.Text = "Поток 2";
          label2_inWait.Text = "";
          label2_isDone.Text = "";
        }
      }
      catch { }
    }

    private void button_blockThread3_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[2].IsAlive && !th3_isSleep)
        {
          th3_isSleep = true;
          th3_Reset.Reset();
          button_blockThread3.Text = "Разблокировать поток 3";
          label3_inProcess.Text = "";
          label3_inQueue.Text = "";
          label3_inWait.Text = "Поток 3";
          label3_isDone.Text = "";
        }
        else
      if (threads[2].IsAlive && th3_isSleep)
        {
          th3_isSleep = false;
          th3_Reset.Set();
          button_blockThread3.Text = "Заблокировать поток 3";
          label3_inProcess.Text = "";
          label3_inQueue.Text = "Поток 3";
          label3_inWait.Text = "";
          label3_isDone.Text = "";
        }
      }
      catch { }
    }

    private void button1_setPriorityLowest_Click(object sender, EventArgs e)
    {
      try
      {
        if(threads[0].IsAlive)
        threads[0].Priority = ThreadPriority.Lowest;
      }
      catch { }
    }

    private void button1_setPriorityBelowNormal_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[0].IsAlive)
          threads[0].Priority = ThreadPriority.BelowNormal;
      }
      catch { }
    }

    private void button1_setPriorityNormal_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[0].IsAlive)
          threads[0].Priority = ThreadPriority.Normal;
      }
      catch { }
    }

    private void button1_setPriorityAboveNormal_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[0].IsAlive)
          threads[0].Priority = ThreadPriority.AboveNormal;
      }
      catch { }
    }

    private void button1_setPriorityHighest_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[0].IsAlive)
          threads[0].Priority = ThreadPriority.Highest;
      }
      catch { }
    }

    private void button2_setPriorityLowest_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[1].IsAlive)
          threads[1].Priority = ThreadPriority.Lowest;
      }
      catch { }
    }

    private void button2_setPriorityBelowNormal_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[1].IsAlive)
          threads[1].Priority = ThreadPriority.BelowNormal;
      }
      catch { }
    }

    private void button2_setPriorityNormal_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[1].IsAlive)
          threads[1].Priority = ThreadPriority.Normal;
      }
      catch { }
    }

    private void button2_setPriorityAboveNormal_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[1].IsAlive)
          threads[1].Priority = ThreadPriority.AboveNormal;
      }
      catch { }
    }

    private void button2_setPriorityHighest_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[1].IsAlive)
          threads[1].Priority = ThreadPriority.Highest;
      }
      catch { }
    }

    private void button3_setPriorityLowest_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[2].IsAlive)
          threads[2].Priority = ThreadPriority.Lowest;
      }
      catch { }
    }

    private void button3_setPriorityBelowNormal_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[2].IsAlive)
          threads[2].Priority = ThreadPriority.BelowNormal;
      }
      catch { }
    }

    private void button3_setPriorityNormal_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[2].IsAlive)
          threads[2].Priority = ThreadPriority.Normal;
      }
      catch { }
    }

    private void button3_setPriorityAboveNormal_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[2].IsAlive)
          threads[2].Priority = ThreadPriority.AboveNormal;
      }
      catch { }
    }

    private void button3_setPriorityHighest_Click(object sender, EventArgs e)
    {
      try
      {
        if (threads[2].IsAlive)
          threads[2].Priority = ThreadPriority.Highest;
      }
      catch { }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // Подсказки
      toolTip1.SetToolTip(button1_setPriorityLowest, "Lowest");
      toolTip2.SetToolTip(button1_setPriorityBelowNormal, "BelowNormal");
      toolTip3.SetToolTip(button1_setPriorityNormal, "Normal");
      toolTip4.SetToolTip(button1_setPriorityAboveNormal, "AboveNormal");
      toolTip5.SetToolTip(button1_setPriorityHighest, "Highest");

      // Обнуление всех текстовых лейблов
      label1_inProcess.Text = "";
      label1_inQueue.Text = "";
      label1_inWait.Text = "";
      label1_isDone.Text = "";

      label2_inProcess.Text = "";
      label2_inQueue.Text = "";
      label2_inWait.Text = "";
      label2_isDone.Text = "";

      label3_inProcess.Text = "";
      label3_inQueue.Text = "";
      label3_inWait.Text = "";
      label3_isDone.Text = "";
      
    }

    private void button_start_Click(object sender, EventArgs e)
    {
      button_start.Enabled = false;
      label1_inQueue.Text = "Поток 1";
      label2_inQueue.Text = "Поток 2";
      label3_inQueue.Text = "Поток 3";

      threads.Add(new Thread(progModule1));
        label1_inQueue.Text = "";
        label1_inProcess.Text = "Поток 1";
        th1_isSleep = false;
        th1_Reset.Set();
        threads[0].Start();
      /*
      threads.Add(new Thread(progModule2));
        label2_inQueue.Text = "";
        label2_inProcess.Text = "Поток 2";
        th2_isSleep = false;
        th2_Reset.Set();
        threads[0].Start(); 
      */
    }
  }
}
