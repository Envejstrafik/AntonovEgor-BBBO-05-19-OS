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
    static List<int> threadsQueue = new List<int>();
    Thread controlThread;
    Mutex mu = new Mutex(); // Мьютекс для правильной обработки ручной блокировки

    private static ManualResetEvent th1_Reset = new ManualResetEvent(true);// Для ручной остановки потоков
    private static ManualResetEvent th2_Reset = new ManualResetEvent(true);
    private static ManualResetEvent th3_Reset = new ManualResetEvent(true);
    static bool th1_isInterrupted = false, th2_isInterrupted = false, th3_isInterrupted = false; // Проверка потоков на прерванность
    static bool th1_isSleep, th2_isSleep, th3_isSleep; // Проверка потоков


    private void ToLabel(Label label, string text)
    {
      if (InvokeRequired)
        label.Invoke(new Action(() => label.Text = text));
      else
        label.Text = text;
    }

    public int setKvant(Thread t)
    {
      int newKvant = 0;
      if (t.Priority == ThreadPriority.Lowest)
      {
        newKvant = 1000;
      } else 
      if(t.Priority == ThreadPriority.BelowNormal)
      {
        newKvant = 2000;
      } else
      if (t.Priority == ThreadPriority.Normal)
      {
        newKvant = 3000;
      } else
      if (t.Priority == ThreadPriority.AboveNormal)
      {
        newKvant = 4000;
      } else
      if (t.Priority == ThreadPriority.Highest)
      {
        newKvant = 5000;
      }
      return newKvant;
    }

    public void progModule1()
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
 //     int kvant = setKvant(Thread.CurrentThread);

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
   /*             if (stopwatch.ElapsedMilliseconds >= kvant)
                {
                  stopwatch.Reset();
                  kvant = setKvant(Thread.CurrentThread);
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
   */
              }
      ToLabel(label1_inProcess, "");
      ToLabel(label1_inQueue, "");
      ToLabel(label1_inWait, "");
      ToLabel(label1_isDone, "Поток 1");
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
      ToLabel(label2_inProcess, "");
      ToLabel(label2_inQueue, "");
      ToLabel(label2_inWait, "");
      ToLabel(label2_isDone, "Поток 2");
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
      ToLabel(label3_inProcess, "");
      ToLabel(label3_inQueue, "");
      ToLabel(label3_inWait, "");
      ToLabel(label3_isDone, "Поток 3");
    }


    public Form1()
    {
      InitializeComponent();
    }

    private void button_blockThread1_Click(object sender, EventArgs e)
    {
      mu.WaitOne();
      try
      {
        if (threads[0].IsAlive && !th1_isInterrupted)
        {
          th1_isInterrupted = true;
          th1_Reset.Reset();
          button_blockThread1.Text = "Разблокировать поток 1";
          label1_inProcess.Text = "";
          label1_inQueue.Text = "";
          label1_inWait.Text = "Поток 1";
          label1_isDone.Text = "";
        }
        else
      if (threads[0].IsAlive && th1_isInterrupted)
        {
          th1_isInterrupted = false;
          th1_Reset.Set();
          button_blockThread1.Text = "Заблокировать поток 1";
          label1_inProcess.Text = "";
          label1_inQueue.Text = "Поток 1";
          label1_inWait.Text = "";
          label1_isDone.Text = "";
        }
      }
      catch { Console.WriteLine("Can't block 1 thread"); }
      mu.ReleaseMutex();
    }

    private void button_blockThread2_Click(object sender, EventArgs e)
    {
      mu.WaitOne();
      try
      {
        if (threads[1].IsAlive && !th2_isInterrupted)
        {
          th2_isInterrupted = true;
          th2_Reset.Reset();
          button_blockThread2.Text = "Разблокировать поток 2";
          label2_inProcess.Text = "";
          label2_inQueue.Text = "";
          label2_inWait.Text = "Поток 2";
          label2_isDone.Text = "";
        }
        else
      if (threads[1].IsAlive && th2_isInterrupted)
        {
          th2_isInterrupted = false;
          th2_Reset.Set();
          button_blockThread2.Text = "Заблокировать поток 2";
          label2_inProcess.Text = "";
          label2_inQueue.Text = "Поток 2";
          label2_inWait.Text = "";
          label2_isDone.Text = "";
        }
      }
      catch { Console.WriteLine("Can't block 2 thread"); }
      mu.ReleaseMutex();
    }

    private void button_blockThread3_Click(object sender, EventArgs e)
    {
      mu.WaitOne();
      try
      {
        if (threads[2].IsAlive && !th3_isInterrupted)
        {
          th3_isInterrupted = true;
          th3_Reset.Reset();
          button_blockThread3.Text = "Разблокировать поток 3";
          label3_inProcess.Text = "";
          label3_inQueue.Text = "";
          label3_inWait.Text = "Поток 3";
          label3_isDone.Text = "";
        }
        else
      if (threads[2].IsAlive && th3_isInterrupted)
        {
          th3_isInterrupted = false;
          th3_Reset.Set();
          button_blockThread3.Text = "Заблокировать поток 3";
          label3_inProcess.Text = "";
          label3_inQueue.Text = "Поток 3";
          label3_inWait.Text = "";
          label3_isDone.Text = "";
        }
      }
      catch { Console.WriteLine("Can't block 3 thread"); }
      mu.ReleaseMutex();
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

    private void Form1_FormClosed(object sender, FormClosedEventArgs e) // Завершает потоки при закрытии окна
    {
      try
      {
        if(controlThread != null)
        controlThread.Abort();
      } catch { }
      for (int i = 0; i < 3; i++)
      {
        try
        {
          threads[i].Abort();
        }
        catch { }
      }
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

      controlThread = new Thread(controlUnit);
      controlThread.Start();
    }

    public void controlUnit() // "Устройство", управляющее потоками и распределяющее их очерёдность
    {
      // Первичное создание потоков и запуск первого
      threads.Add(new Thread(progModule1));
      ToLabel(label1_inQueue, "");
      ToLabel(label1_inProcess, "Поток 1");
      th1_isInterrupted = false;
      th1_Reset.Set();
      threads[0].Start();

       threads.Add(new Thread(progModule2));
 //     ToLabel(label2_inQueue, "");
 //     ToLabel(label2_inProcess, "Поток 2");
      th2_isInterrupted = false;
//         th2_Reset.Set();
//         threads[1].Start();  

       threads.Add(new Thread(progModule3));
 //     ToLabel(label3_inQueue, "");
 //     ToLabel(label3_inProcess, "Поток 3");
      th3_isInterrupted = false;
//         th3_Reset.Set();
//         threads[2].Start();

      Stopwatch stopwatch1 = new Stopwatch(); // Секундомеры для каждого потока
      Stopwatch stopwatch2 = new Stopwatch();
      Stopwatch stopwatch3 = new Stopwatch();


      stopwatch1.Start();
      int kvant1, kvant2, kvant3;
      kvant1 = setKvant(threads[0]);
      kvant2 = setKvant(threads[1]);
      kvant3 = setKvant(threads[2]);
      bool Justice1 = false, Justice2 = false, Justice3 = false;
      while (true)
      {
        
        kvant1 = setKvant(threads[0]);
        kvant2 = setKvant(threads[1]);
        kvant3 = setKvant(threads[2]);
        if (threads[0].IsAlive && !th1_isInterrupted && !th1_isSleep && stopwatch1.ElapsedMilliseconds >= kvant1)
        {
          Console.WriteLine($"thread 1 reset (497), {stopwatch1.ElapsedMilliseconds}");
          th1_Reset.Reset();
          th1_isSleep = true;
          stopwatch1.Stop();
          stopwatch1.Reset();


          ToLabel(label1_inProcess, "");
          ToLabel(label1_inQueue, "Поток 1");
          ToLabel(label1_inWait, "");
          ToLabel(label1_isDone, "");

          if (kvant2 >= kvant3 && !Justice1 && !th2_isInterrupted)
          {
            Console.WriteLine("thread 2 set, 511");
            Justice1 = true;
            if (!threads[1].IsAlive)
            {
              threads[1].Start();
            }
            th2_Reset.Set();
            stopwatch2.Start();
            th3_Reset.Reset();
            th2_isSleep = false;
            th3_isSleep = true;
            ToLabel(label2_inProcess, "Поток 2");
            ToLabel(label2_inQueue, "");
            ToLabel(label2_inWait, "");
            ToLabel(label2_isDone, "");

          }
          else if (!th3_isInterrupted)
          {
            Justice1 = false;
            if (!threads[2].IsAlive)
            {
              threads[2].Start();
            }
            th3_Reset.Set();

            th2_Reset.Reset();
            th3_isSleep = false;
            th2_isSleep = true;
            Console.WriteLine("thread 3 set, 539");
            stopwatch3.Start();
            ToLabel(label3_inProcess, "Поток 3");
            ToLabel(label3_inQueue, "");
            ToLabel(label3_inWait, "");
            ToLabel(label3_isDone, "");
          }
        }
        else
        if (threads[1].IsAlive && !th2_isInterrupted && !th2_isSleep && stopwatch2.ElapsedMilliseconds >= kvant2)
        {
          th2_Reset.Reset();
          th2_isSleep = true;
          Console.WriteLine($"thread 2 reset, 551, {stopwatch2.ElapsedMilliseconds}");
          stopwatch2.Stop();
          stopwatch2.Reset();
          ToLabel(label2_inProcess, "");
          ToLabel(label2_inQueue, "Поток 2");
          ToLabel(label2_inWait, "");
          ToLabel(label2_isDone, "");
          if (kvant1 >= kvant3 && !Justice2 && !th1_isInterrupted)
          {
            Justice2 = true;
            Console.WriteLine("thread 1 set, 561");
            th1_Reset.Set();
            th3_Reset.Reset();
            stopwatch1.Start();
            th1_isSleep = false;
            th3_isSleep = true;
            ToLabel(label1_inProcess, "Поток 1");
            ToLabel(label1_inQueue, "");
            ToLabel(label1_inWait, "");
            ToLabel(label1_isDone, "");
          }
          else
          if (!th3_isInterrupted)
          {
            Justice2 = false;
            Console.WriteLine("thread 3 set, 576");
            th3_Reset.Set();
            th1_Reset.Reset();
            stopwatch3.Start();
            th3_isSleep = false;
            th1_isSleep = true;
            ToLabel(label3_inProcess, "Поток 3");
            ToLabel(label3_inQueue, "");
            ToLabel(label3_inWait, "");
            ToLabel(label3_isDone, "");
          }
        }
        else
        if (threads[2].IsAlive && !th3_isInterrupted && !th3_isSleep && stopwatch3.ElapsedMilliseconds >= kvant3)
        {
          th3_Reset.Reset();
          stopwatch3.Stop();
          Console.WriteLine($"thread 3 reset, 592, {stopwatch3.ElapsedMilliseconds}");
          stopwatch3.Reset();
          th3_isSleep = true;

          ToLabel(label3_inProcess, "");
          ToLabel(label3_inQueue, "Поток 3");
          ToLabel(label3_inWait, "");
          ToLabel(label3_isDone, "");
          if (kvant2 >= kvant1 && !Justice3 && !th2_isInterrupted)
          {
            Justice3 = true;
            Console.WriteLine("thread 2 set, 603");
            th2_Reset.Set();
            th1_Reset.Reset();
            th2_isSleep = false;
            th1_isSleep = true;
            stopwatch2.Start();
            ToLabel(label2_inProcess, "Поток 2");
            ToLabel(label2_inQueue, "");
            ToLabel(label2_inWait, "");
            ToLabel(label2_isDone, "");
          }
          else if (!th1_isInterrupted)
          {
            Justice3 = false;
            Console.WriteLine("thread 1 set, 617");
            th1_Reset.Set();
            th2_Reset.Reset();
            th1_isSleep = false;
            th2_isSleep = true;
            stopwatch1.Start();
            ToLabel(label1_inProcess, "Поток 1");
            ToLabel(label1_inQueue, "");
            ToLabel(label1_inWait, "");
            ToLabel(label1_isDone, "");
          }
        }
  /*        else if (!th1_isInterrupted && th2_isInterrupted)
          {
            Justice3 = false;
            Console.WriteLine("thread 1 set, 617");
            th1_Reset.Set();
            th2_Reset.Reset();
            th1_isSleep = false;
            th2_isSleep = true;
            stopwatch1.Start();
            ToLabel(label1_inProcess, "Поток 1");
            ToLabel(label1_inQueue, "");
            ToLabel(label1_inWait, "");
            ToLabel(label1_isDone, "");
          } else 
          if (th1_isInterrupted && !th2_isInterrupted)
          {
            Console.WriteLine("thread 2 set, 603");
            th2_Reset.Set();
            th1_Reset.Reset();
            th2_isSleep = false;
            th1_isSleep = true;
            stopwatch2.Start();
            ToLabel(label2_inProcess, "Поток 2");
            ToLabel(label2_inQueue, "");
            ToLabel(label2_inWait, "");
            ToLabel(label2_isDone, "");
          }
          
        } else
        if (th1_isInterrupted && th2_isInterrupted && !th3_isInterrupted)
        {
          if (th3_isSleep)
          {
            Console.WriteLine("thread 3 set///");
            th3_Reset.Set();
            stopwatch3.Start();
            th3_isSleep = false;
            ToLabel(label3_inProcess, "Поток 3");
            ToLabel(label3_inQueue, "");
            ToLabel(label3_inWait, "");
            ToLabel(label3_isDone, "");
          }
        } else
         if (th1_isInterrupted && !th2_isInterrupted && th3_isInterrupted)
        {
          if (th3_isSleep)
          {
            Console.WriteLine("thread 2 set///");
            th2_Reset.Set();
            stopwatch2.Start();
            th3_isSleep = false;
            ToLabel(label2_inProcess, "Поток 2");
            ToLabel(label2_inQueue, "");
            ToLabel(label2_inWait, "");
            ToLabel(label2_isDone, "");
          }
        }else
         if (!th1_isInterrupted && th2_isInterrupted && th3_isInterrupted)
        {
          if (th3_isSleep)
          {
            Console.WriteLine("thread 1 set///");
            th1_Reset.Set();
            stopwatch1.Start();
            th3_isSleep = false;
            ToLabel(label1_inProcess, "Поток 1");
            ToLabel(label1_inQueue, "");
            ToLabel(label1_inWait, "");
            ToLabel(label1_isDone, "");
          }
        }else
        {
 //         Console.WriteLine("NOT ENTERED!");
        }
  */
      }
    }
  }
}
