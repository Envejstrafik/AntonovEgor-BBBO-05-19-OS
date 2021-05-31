
namespace Practice_4_wf
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.label1_inQueue = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.button_blockThread3 = new System.Windows.Forms.Button();
      this.button_blockThread2 = new System.Windows.Forms.Button();
      this.button_blockThread1 = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label3_inQueue = new System.Windows.Forms.Label();
      this.label2_inQueue = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.label3_inWait = new System.Windows.Forms.Label();
      this.label2_inWait = new System.Windows.Forms.Label();
      this.label1_inWait = new System.Windows.Forms.Label();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.label3_inProcess = new System.Windows.Forms.Label();
      this.label2_inProcess = new System.Windows.Forms.Label();
      this.label1_inProcess = new System.Windows.Forms.Label();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.label3_isDone = new System.Windows.Forms.Label();
      this.label2_isDone = new System.Windows.Forms.Label();
      this.label1_isDone = new System.Windows.Forms.Label();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.groupBox9 = new System.Windows.Forms.GroupBox();
      this.button3_setPriorityHighest = new System.Windows.Forms.Button();
      this.button3_setPriorityAboveNormal = new System.Windows.Forms.Button();
      this.button3_setPriorityNormal = new System.Windows.Forms.Button();
      this.button3_setPriorityLowest = new System.Windows.Forms.Button();
      this.button3_setPriorityBelowNormal = new System.Windows.Forms.Button();
      this.groupBox8 = new System.Windows.Forms.GroupBox();
      this.button2_setPriorityHighest = new System.Windows.Forms.Button();
      this.button2_setPriorityAboveNormal = new System.Windows.Forms.Button();
      this.button2_setPriorityNormal = new System.Windows.Forms.Button();
      this.button2_setPriorityLowest = new System.Windows.Forms.Button();
      this.button2_setPriorityBelowNormal = new System.Windows.Forms.Button();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.button1_setPriorityHighest = new System.Windows.Forms.Button();
      this.button1_setPriorityAboveNormal = new System.Windows.Forms.Button();
      this.button1_setPriorityNormal = new System.Windows.Forms.Button();
      this.button1_setPriorityLowest = new System.Windows.Forms.Button();
      this.button1_setPriorityBelowNormal = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
      this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
      this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
      this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
      this.button_start = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1_inQueue
      // 
      this.label1_inQueue.AutoSize = true;
      this.label1_inQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.label1_inQueue.Location = new System.Drawing.Point(42, 48);
      this.label1_inQueue.Name = "label1_inQueue";
      this.label1_inQueue.Size = new System.Drawing.Size(141, 39);
      this.label1_inQueue.TabIndex = 0;
      this.label1_inQueue.Text = "Поток 1";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button_blockThread3);
      this.groupBox1.Controls.Add(this.button_blockThread2);
      this.groupBox1.Controls.Add(this.button_blockThread1);
      this.groupBox1.Location = new System.Drawing.Point(670, 54);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(222, 155);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Блокировка потоков";
      // 
      // button_blockThread3
      // 
      this.button_blockThread3.Location = new System.Drawing.Point(6, 112);
      this.button_blockThread3.Name = "button_blockThread3";
      this.button_blockThread3.Size = new System.Drawing.Size(210, 36);
      this.button_blockThread3.TabIndex = 2;
      this.button_blockThread3.Text = "Заблокировать поток 3";
      this.button_blockThread3.UseVisualStyleBackColor = true;
      this.button_blockThread3.Click += new System.EventHandler(this.button_blockThread3_Click);
      // 
      // button_blockThread2
      // 
      this.button_blockThread2.Location = new System.Drawing.Point(6, 70);
      this.button_blockThread2.Name = "button_blockThread2";
      this.button_blockThread2.Size = new System.Drawing.Size(210, 36);
      this.button_blockThread2.TabIndex = 1;
      this.button_blockThread2.Text = "Заблокировать поток 2";
      this.button_blockThread2.UseVisualStyleBackColor = true;
      this.button_blockThread2.Click += new System.EventHandler(this.button_blockThread2_Click);
      // 
      // button_blockThread1
      // 
      this.button_blockThread1.Location = new System.Drawing.Point(7, 28);
      this.button_blockThread1.Name = "button_blockThread1";
      this.button_blockThread1.Size = new System.Drawing.Size(209, 36);
      this.button_blockThread1.TabIndex = 0;
      this.button_blockThread1.Text = "Заблокировать поток 1";
      this.button_blockThread1.UseVisualStyleBackColor = true;
      this.button_blockThread1.Click += new System.EventHandler(this.button_blockThread1_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label3_inQueue);
      this.groupBox2.Controls.Add(this.label2_inQueue);
      this.groupBox2.Controls.Add(this.label1_inQueue);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
      this.groupBox2.Location = new System.Drawing.Point(44, 42);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(265, 192);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Очередь";
      // 
      // label3_inQueue
      // 
      this.label3_inQueue.AutoSize = true;
      this.label3_inQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.label3_inQueue.Location = new System.Drawing.Point(42, 128);
      this.label3_inQueue.Name = "label3_inQueue";
      this.label3_inQueue.Size = new System.Drawing.Size(141, 39);
      this.label3_inQueue.TabIndex = 2;
      this.label3_inQueue.Text = "Поток 3";
      // 
      // label2_inQueue
      // 
      this.label2_inQueue.AutoSize = true;
      this.label2_inQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.label2_inQueue.Location = new System.Drawing.Point(42, 87);
      this.label2_inQueue.Name = "label2_inQueue";
      this.label2_inQueue.Size = new System.Drawing.Size(141, 39);
      this.label2_inQueue.TabIndex = 1;
      this.label2_inQueue.Text = "Поток 2";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.label3_inWait);
      this.groupBox3.Controls.Add(this.label2_inWait);
      this.groupBox3.Controls.Add(this.label1_inWait);
      this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
      this.groupBox3.ForeColor = System.Drawing.Color.Black;
      this.groupBox3.Location = new System.Drawing.Point(44, 282);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(265, 192);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Ожидание";
      // 
      // label3_inWait
      // 
      this.label3_inWait.AutoSize = true;
      this.label3_inWait.ForeColor = System.Drawing.Color.Red;
      this.label3_inWait.Location = new System.Drawing.Point(55, 135);
      this.label3_inWait.Name = "label3_inWait";
      this.label3_inWait.Size = new System.Drawing.Size(141, 39);
      this.label3_inWait.TabIndex = 8;
      this.label3_inWait.Text = "Поток 3";
      // 
      // label2_inWait
      // 
      this.label2_inWait.AutoSize = true;
      this.label2_inWait.ForeColor = System.Drawing.Color.Red;
      this.label2_inWait.Location = new System.Drawing.Point(55, 94);
      this.label2_inWait.Name = "label2_inWait";
      this.label2_inWait.Size = new System.Drawing.Size(141, 39);
      this.label2_inWait.TabIndex = 7;
      this.label2_inWait.Text = "Поток 2";
      // 
      // label1_inWait
      // 
      this.label1_inWait.AutoSize = true;
      this.label1_inWait.ForeColor = System.Drawing.Color.Red;
      this.label1_inWait.Location = new System.Drawing.Point(55, 55);
      this.label1_inWait.Name = "label1_inWait";
      this.label1_inWait.Size = new System.Drawing.Size(141, 39);
      this.label1_inWait.TabIndex = 6;
      this.label1_inWait.Text = "Поток 1";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.label3_inProcess);
      this.groupBox4.Controls.Add(this.label2_inProcess);
      this.groupBox4.Controls.Add(this.label1_inProcess);
      this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
      this.groupBox4.Location = new System.Drawing.Point(356, 42);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(265, 192);
      this.groupBox4.TabIndex = 4;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Выполняется";
      // 
      // label3_inProcess
      // 
      this.label3_inProcess.AutoSize = true;
      this.label3_inProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.label3_inProcess.Location = new System.Drawing.Point(56, 128);
      this.label3_inProcess.Name = "label3_inProcess";
      this.label3_inProcess.Size = new System.Drawing.Size(141, 39);
      this.label3_inProcess.TabIndex = 5;
      this.label3_inProcess.Text = "Поток 3";
      // 
      // label2_inProcess
      // 
      this.label2_inProcess.AutoSize = true;
      this.label2_inProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.label2_inProcess.Location = new System.Drawing.Point(56, 87);
      this.label2_inProcess.Name = "label2_inProcess";
      this.label2_inProcess.Size = new System.Drawing.Size(141, 39);
      this.label2_inProcess.TabIndex = 4;
      this.label2_inProcess.Text = "Поток 2";
      // 
      // label1_inProcess
      // 
      this.label1_inProcess.AutoSize = true;
      this.label1_inProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.label1_inProcess.Location = new System.Drawing.Point(56, 48);
      this.label1_inProcess.Name = "label1_inProcess";
      this.label1_inProcess.Size = new System.Drawing.Size(141, 39);
      this.label1_inProcess.TabIndex = 3;
      this.label1_inProcess.Text = "Поток 1";
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.label3_isDone);
      this.groupBox5.Controls.Add(this.label2_isDone);
      this.groupBox5.Controls.Add(this.label1_isDone);
      this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
      this.groupBox5.Location = new System.Drawing.Point(356, 282);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(265, 192);
      this.groupBox5.TabIndex = 5;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Готов";
      // 
      // label3_isDone
      // 
      this.label3_isDone.AutoSize = true;
      this.label3_isDone.ForeColor = System.Drawing.Color.Green;
      this.label3_isDone.Location = new System.Drawing.Point(56, 135);
      this.label3_isDone.Name = "label3_isDone";
      this.label3_isDone.Size = new System.Drawing.Size(141, 39);
      this.label3_isDone.TabIndex = 11;
      this.label3_isDone.Text = "Поток 3";
      // 
      // label2_isDone
      // 
      this.label2_isDone.AutoSize = true;
      this.label2_isDone.ForeColor = System.Drawing.Color.Green;
      this.label2_isDone.Location = new System.Drawing.Point(56, 94);
      this.label2_isDone.Name = "label2_isDone";
      this.label2_isDone.Size = new System.Drawing.Size(141, 39);
      this.label2_isDone.TabIndex = 10;
      this.label2_isDone.Text = "Поток 2";
      // 
      // label1_isDone
      // 
      this.label1_isDone.AutoSize = true;
      this.label1_isDone.ForeColor = System.Drawing.Color.Green;
      this.label1_isDone.Location = new System.Drawing.Point(56, 55);
      this.label1_isDone.Name = "label1_isDone";
      this.label1_isDone.Size = new System.Drawing.Size(141, 39);
      this.label1_isDone.TabIndex = 9;
      this.label1_isDone.Text = "Поток 1";
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.groupBox9);
      this.groupBox6.Controls.Add(this.groupBox8);
      this.groupBox6.Controls.Add(this.groupBox7);
      this.groupBox6.Location = new System.Drawing.Point(670, 215);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(222, 259);
      this.groupBox6.TabIndex = 3;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Приоритеты потоков";
      // 
      // groupBox9
      // 
      this.groupBox9.Controls.Add(this.button3_setPriorityHighest);
      this.groupBox9.Controls.Add(this.button3_setPriorityAboveNormal);
      this.groupBox9.Controls.Add(this.button3_setPriorityNormal);
      this.groupBox9.Controls.Add(this.button3_setPriorityLowest);
      this.groupBox9.Controls.Add(this.button3_setPriorityBelowNormal);
      this.groupBox9.Location = new System.Drawing.Point(19, 176);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new System.Drawing.Size(182, 65);
      this.groupBox9.TabIndex = 9;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "Поток 3";
      // 
      // button3_setPriorityHighest
      // 
      this.button3_setPriorityHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button3_setPriorityHighest.Location = new System.Drawing.Point(146, 19);
      this.button3_setPriorityHighest.Name = "button3_setPriorityHighest";
      this.button3_setPriorityHighest.Size = new System.Drawing.Size(29, 40);
      this.button3_setPriorityHighest.TabIndex = 8;
      this.button3_setPriorityHighest.Text = "4";
      this.button3_setPriorityHighest.UseVisualStyleBackColor = true;
      this.button3_setPriorityHighest.Click += new System.EventHandler(this.button3_setPriorityHighest_Click);
      // 
      // button3_setPriorityAboveNormal
      // 
      this.button3_setPriorityAboveNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button3_setPriorityAboveNormal.Location = new System.Drawing.Point(111, 19);
      this.button3_setPriorityAboveNormal.Name = "button3_setPriorityAboveNormal";
      this.button3_setPriorityAboveNormal.Size = new System.Drawing.Size(29, 40);
      this.button3_setPriorityAboveNormal.TabIndex = 7;
      this.button3_setPriorityAboveNormal.Text = "3";
      this.button3_setPriorityAboveNormal.UseVisualStyleBackColor = true;
      this.button3_setPriorityAboveNormal.Click += new System.EventHandler(this.button3_setPriorityAboveNormal_Click);
      // 
      // button3_setPriorityNormal
      // 
      this.button3_setPriorityNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button3_setPriorityNormal.Location = new System.Drawing.Point(76, 19);
      this.button3_setPriorityNormal.Name = "button3_setPriorityNormal";
      this.button3_setPriorityNormal.Size = new System.Drawing.Size(29, 40);
      this.button3_setPriorityNormal.TabIndex = 6;
      this.button3_setPriorityNormal.Text = "2";
      this.button3_setPriorityNormal.UseVisualStyleBackColor = true;
      this.button3_setPriorityNormal.Click += new System.EventHandler(this.button3_setPriorityNormal_Click);
      // 
      // button3_setPriorityLowest
      // 
      this.button3_setPriorityLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button3_setPriorityLowest.Location = new System.Drawing.Point(6, 19);
      this.button3_setPriorityLowest.Name = "button3_setPriorityLowest";
      this.button3_setPriorityLowest.Size = new System.Drawing.Size(29, 40);
      this.button3_setPriorityLowest.TabIndex = 5;
      this.button3_setPriorityLowest.Text = "0";
      this.button3_setPriorityLowest.UseVisualStyleBackColor = true;
      this.button3_setPriorityLowest.Click += new System.EventHandler(this.button3_setPriorityLowest_Click);
      // 
      // button3_setPriorityBelowNormal
      // 
      this.button3_setPriorityBelowNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button3_setPriorityBelowNormal.Location = new System.Drawing.Point(41, 19);
      this.button3_setPriorityBelowNormal.Name = "button3_setPriorityBelowNormal";
      this.button3_setPriorityBelowNormal.Size = new System.Drawing.Size(29, 40);
      this.button3_setPriorityBelowNormal.TabIndex = 1;
      this.button3_setPriorityBelowNormal.Text = "1";
      this.button3_setPriorityBelowNormal.UseVisualStyleBackColor = true;
      this.button3_setPriorityBelowNormal.Click += new System.EventHandler(this.button3_setPriorityBelowNormal_Click);
      // 
      // groupBox8
      // 
      this.groupBox8.Controls.Add(this.button2_setPriorityHighest);
      this.groupBox8.Controls.Add(this.button2_setPriorityAboveNormal);
      this.groupBox8.Controls.Add(this.button2_setPriorityNormal);
      this.groupBox8.Controls.Add(this.button2_setPriorityLowest);
      this.groupBox8.Controls.Add(this.button2_setPriorityBelowNormal);
      this.groupBox8.Location = new System.Drawing.Point(19, 100);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new System.Drawing.Size(182, 65);
      this.groupBox8.TabIndex = 9;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "Поток 2";
      // 
      // button2_setPriorityHighest
      // 
      this.button2_setPriorityHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button2_setPriorityHighest.Location = new System.Drawing.Point(146, 19);
      this.button2_setPriorityHighest.Name = "button2_setPriorityHighest";
      this.button2_setPriorityHighest.Size = new System.Drawing.Size(29, 40);
      this.button2_setPriorityHighest.TabIndex = 8;
      this.button2_setPriorityHighest.Text = "4";
      this.button2_setPriorityHighest.UseVisualStyleBackColor = true;
      this.button2_setPriorityHighest.Click += new System.EventHandler(this.button2_setPriorityHighest_Click);
      // 
      // button2_setPriorityAboveNormal
      // 
      this.button2_setPriorityAboveNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button2_setPriorityAboveNormal.Location = new System.Drawing.Point(111, 19);
      this.button2_setPriorityAboveNormal.Name = "button2_setPriorityAboveNormal";
      this.button2_setPriorityAboveNormal.Size = new System.Drawing.Size(29, 40);
      this.button2_setPriorityAboveNormal.TabIndex = 7;
      this.button2_setPriorityAboveNormal.Text = "3";
      this.button2_setPriorityAboveNormal.UseVisualStyleBackColor = true;
      this.button2_setPriorityAboveNormal.Click += new System.EventHandler(this.button2_setPriorityAboveNormal_Click);
      // 
      // button2_setPriorityNormal
      // 
      this.button2_setPriorityNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button2_setPriorityNormal.Location = new System.Drawing.Point(76, 19);
      this.button2_setPriorityNormal.Name = "button2_setPriorityNormal";
      this.button2_setPriorityNormal.Size = new System.Drawing.Size(29, 40);
      this.button2_setPriorityNormal.TabIndex = 6;
      this.button2_setPriorityNormal.Text = "2";
      this.button2_setPriorityNormal.UseVisualStyleBackColor = true;
      this.button2_setPriorityNormal.Click += new System.EventHandler(this.button2_setPriorityNormal_Click);
      // 
      // button2_setPriorityLowest
      // 
      this.button2_setPriorityLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button2_setPriorityLowest.Location = new System.Drawing.Point(6, 19);
      this.button2_setPriorityLowest.Name = "button2_setPriorityLowest";
      this.button2_setPriorityLowest.Size = new System.Drawing.Size(29, 40);
      this.button2_setPriorityLowest.TabIndex = 5;
      this.button2_setPriorityLowest.Text = "0";
      this.button2_setPriorityLowest.UseVisualStyleBackColor = true;
      this.button2_setPriorityLowest.Click += new System.EventHandler(this.button2_setPriorityLowest_Click);
      // 
      // button2_setPriorityBelowNormal
      // 
      this.button2_setPriorityBelowNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button2_setPriorityBelowNormal.Location = new System.Drawing.Point(41, 19);
      this.button2_setPriorityBelowNormal.Name = "button2_setPriorityBelowNormal";
      this.button2_setPriorityBelowNormal.Size = new System.Drawing.Size(29, 40);
      this.button2_setPriorityBelowNormal.TabIndex = 1;
      this.button2_setPriorityBelowNormal.Text = "1";
      this.button2_setPriorityBelowNormal.UseVisualStyleBackColor = true;
      this.button2_setPriorityBelowNormal.Click += new System.EventHandler(this.button2_setPriorityBelowNormal_Click);
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.button1_setPriorityHighest);
      this.groupBox7.Controls.Add(this.button1_setPriorityAboveNormal);
      this.groupBox7.Controls.Add(this.button1_setPriorityNormal);
      this.groupBox7.Controls.Add(this.button1_setPriorityLowest);
      this.groupBox7.Controls.Add(this.button1_setPriorityBelowNormal);
      this.groupBox7.Location = new System.Drawing.Point(19, 29);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(182, 65);
      this.groupBox7.TabIndex = 0;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Поток 1";
      // 
      // button1_setPriorityHighest
      // 
      this.button1_setPriorityHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button1_setPriorityHighest.Location = new System.Drawing.Point(146, 19);
      this.button1_setPriorityHighest.Name = "button1_setPriorityHighest";
      this.button1_setPriorityHighest.Size = new System.Drawing.Size(29, 40);
      this.button1_setPriorityHighest.TabIndex = 8;
      this.button1_setPriorityHighest.Text = "4";
      this.button1_setPriorityHighest.UseVisualStyleBackColor = true;
      this.button1_setPriorityHighest.Click += new System.EventHandler(this.button1_setPriorityHighest_Click);
      // 
      // button1_setPriorityAboveNormal
      // 
      this.button1_setPriorityAboveNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button1_setPriorityAboveNormal.Location = new System.Drawing.Point(111, 19);
      this.button1_setPriorityAboveNormal.Name = "button1_setPriorityAboveNormal";
      this.button1_setPriorityAboveNormal.Size = new System.Drawing.Size(29, 40);
      this.button1_setPriorityAboveNormal.TabIndex = 7;
      this.button1_setPriorityAboveNormal.Text = "3";
      this.button1_setPriorityAboveNormal.UseVisualStyleBackColor = true;
      this.button1_setPriorityAboveNormal.Click += new System.EventHandler(this.button1_setPriorityAboveNormal_Click);
      // 
      // button1_setPriorityNormal
      // 
      this.button1_setPriorityNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button1_setPriorityNormal.Location = new System.Drawing.Point(76, 19);
      this.button1_setPriorityNormal.Name = "button1_setPriorityNormal";
      this.button1_setPriorityNormal.Size = new System.Drawing.Size(29, 40);
      this.button1_setPriorityNormal.TabIndex = 6;
      this.button1_setPriorityNormal.Text = "2";
      this.button1_setPriorityNormal.UseVisualStyleBackColor = true;
      this.button1_setPriorityNormal.Click += new System.EventHandler(this.button1_setPriorityNormal_Click);
      // 
      // button1_setPriorityLowest
      // 
      this.button1_setPriorityLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button1_setPriorityLowest.Location = new System.Drawing.Point(6, 19);
      this.button1_setPriorityLowest.Name = "button1_setPriorityLowest";
      this.button1_setPriorityLowest.Size = new System.Drawing.Size(29, 40);
      this.button1_setPriorityLowest.TabIndex = 5;
      this.button1_setPriorityLowest.Text = "0";
      this.button1_setPriorityLowest.UseVisualStyleBackColor = true;
      this.button1_setPriorityLowest.Click += new System.EventHandler(this.button1_setPriorityLowest_Click);
      // 
      // button1_setPriorityBelowNormal
      // 
      this.button1_setPriorityBelowNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.button1_setPriorityBelowNormal.Location = new System.Drawing.Point(41, 19);
      this.button1_setPriorityBelowNormal.Name = "button1_setPriorityBelowNormal";
      this.button1_setPriorityBelowNormal.Size = new System.Drawing.Size(29, 40);
      this.button1_setPriorityBelowNormal.TabIndex = 1;
      this.button1_setPriorityBelowNormal.Text = "1";
      this.button1_setPriorityBelowNormal.UseVisualStyleBackColor = true;
      this.button1_setPriorityBelowNormal.Click += new System.EventHandler(this.button1_setPriorityBelowNormal_Click);
      // 
      // button_start
      // 
      this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
      this.button_start.Location = new System.Drawing.Point(50, 486);
      this.button_start.Name = "button_start";
      this.button_start.Size = new System.Drawing.Size(835, 45);
      this.button_start.TabIndex = 6;
      this.button_start.Text = "Начать";
      this.button_start.UseVisualStyleBackColor = true;
      this.button_start.Click += new System.EventHandler(this.button_start_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(904, 539);
      this.Controls.Add(this.button_start);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox9.ResumeLayout(false);
      this.groupBox8.ResumeLayout(false);
      this.groupBox7.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label label1_inQueue;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button button_blockThread3;
    private System.Windows.Forms.Button button_blockThread2;
    private System.Windows.Forms.Button button_blockThread1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label3_inQueue;
    private System.Windows.Forms.Label label2_inQueue;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label label3_inWait;
    private System.Windows.Forms.Label label2_inWait;
    private System.Windows.Forms.Label label1_inWait;
    private System.Windows.Forms.Label label3_inProcess;
    private System.Windows.Forms.Label label2_inProcess;
    private System.Windows.Forms.Label label1_inProcess;
    private System.Windows.Forms.Label label3_isDone;
    private System.Windows.Forms.Label label2_isDone;
    private System.Windows.Forms.Label label1_isDone;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.Button button1_setPriorityHighest;
    private System.Windows.Forms.Button button1_setPriorityAboveNormal;
    private System.Windows.Forms.Button button1_setPriorityNormal;
    private System.Windows.Forms.Button button1_setPriorityLowest;
    private System.Windows.Forms.Button button1_setPriorityBelowNormal;
    private System.Windows.Forms.GroupBox groupBox9;
    private System.Windows.Forms.Button button3_setPriorityHighest;
    private System.Windows.Forms.Button button3_setPriorityAboveNormal;
    private System.Windows.Forms.Button button3_setPriorityNormal;
    private System.Windows.Forms.Button button3_setPriorityLowest;
    private System.Windows.Forms.Button button3_setPriorityBelowNormal;
    private System.Windows.Forms.GroupBox groupBox8;
    private System.Windows.Forms.Button button2_setPriorityHighest;
    private System.Windows.Forms.Button button2_setPriorityAboveNormal;
    private System.Windows.Forms.Button button2_setPriorityNormal;
    private System.Windows.Forms.Button button2_setPriorityLowest;
    private System.Windows.Forms.Button button2_setPriorityBelowNormal;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.ToolTip toolTip2;
    private System.Windows.Forms.ToolTip toolTip3;
    private System.Windows.Forms.ToolTip toolTip4;
    private System.Windows.Forms.ToolTip toolTip5;
    private System.Windows.Forms.Button button_start;
  }
}

