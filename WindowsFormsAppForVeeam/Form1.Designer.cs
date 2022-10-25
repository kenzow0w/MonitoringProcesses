
namespace WindowsFormMonitoring
{
    partial class Monitor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartMon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.labelInfoAboutExit = new System.Windows.Forms.Label();
            this.textBoxProcessName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaxLifetime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFrequencyTime = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxForTimer = new System.Windows.Forms.TextBox();
            this.textBoxFreqTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завершитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // завершитьToolStripMenuItem
            // 
            this.завершитьToolStripMenuItem.Name = "завершитьToolStripMenuItem";
            this.завершитьToolStripMenuItem.Size = new System.Drawing.Size(186, 44);
            this.завершитьToolStripMenuItem.Text = "Exit";
            this.завершитьToolStripMenuItem.Click += new System.EventHandler(this.завершитьToolStripMenuItem_Click);
            // 
            // btnStartMon
            // 
            this.btnStartMon.Location = new System.Drawing.Point(15, 314);
            this.btnStartMon.Name = "btnStartMon";
            this.btnStartMon.Size = new System.Drawing.Size(206, 38);
            this.btnStartMon.TabIndex = 3;
            this.btnStartMon.Text = "Start monitoring";
            this.btnStartMon.UseVisualStyleBackColor = true;
            this.btnStartMon.Click += new System.EventHandler(this.buttonStartMonitoring_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(24, 897);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "You can press \"Q\" for exit from programm";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(398, 314);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(206, 38);
            this.btnClearForm.TabIndex = 6;
            this.btnClearForm.Text = "Clear form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.buttonClearForm_Click);
            // 
            // labelInfoAboutExit
            // 
            this.labelInfoAboutExit.AutoSize = true;
            this.labelInfoAboutExit.ForeColor = System.Drawing.Color.Crimson;
            this.labelInfoAboutExit.Location = new System.Drawing.Point(12, 635);
            this.labelInfoAboutExit.Name = "labelInfoAboutExit";
            this.labelInfoAboutExit.Size = new System.Drawing.Size(438, 29);
            this.labelInfoAboutExit.TabIndex = 7;
            this.labelInfoAboutExit.Text = "Press \"Q\" for cancel monitoring process";
            // 
            // textBoxProcessName
            // 
            this.textBoxProcessName.Location = new System.Drawing.Point(183, 106);
            this.textBoxProcessName.Name = "textBoxProcessName";
            this.textBoxProcessName.Size = new System.Drawing.Size(233, 35);
            this.textBoxProcessName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Process name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Maximum lifetime";
            // 
            // textBoxMaxLifetime
            // 
            this.textBoxMaxLifetime.Location = new System.Drawing.Point(183, 173);
            this.textBoxMaxLifetime.Name = "textBoxMaxLifetime";
            this.textBoxMaxLifetime.Size = new System.Drawing.Size(233, 35);
            this.textBoxMaxLifetime.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Frequency time";
            // 
            // textBoxFrequencyTime
            // 
            this.textBoxFrequencyTime.Location = new System.Drawing.Point(183, 253);
            this.textBoxFrequencyTime.Name = "textBoxFrequencyTime";
            this.textBoxFrequencyTime.Size = new System.Drawing.Size(233, 35);
            this.textBoxFrequencyTime.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Procesess started: ";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(578, 112);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(89, 29);
            this.labelTimer.TabIndex = 16;
            this.labelTimer.Text = "Timer: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // textBoxForTimer
            // 
            this.textBoxForTimer.Location = new System.Drawing.Point(629, 112);
            this.textBoxForTimer.Name = "textBoxForTimer";
            this.textBoxForTimer.ReadOnly = true;
            this.textBoxForTimer.Size = new System.Drawing.Size(63, 35);
            this.textBoxForTimer.TabIndex = 17;
            this.textBoxForTimer.Text = "00:00";
            this.textBoxForTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFreqTime
            // 
            this.textBoxFreqTime.Location = new System.Drawing.Point(653, 253);
            this.textBoxFreqTime.Name = "textBoxFreqTime";
            this.textBoxFreqTime.ReadOnly = true;
            this.textBoxFreqTime.Size = new System.Drawing.Size(39, 35);
            this.textBoxFreqTime.TabIndex = 19;
            this.textBoxFreqTime.Text = "00";
            this.textBoxFreqTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "next update in: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(12, 659);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Press \"ESC\" for exit";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFreqTime);
            this.Controls.Add(this.textBoxForTimer);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFrequencyTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMaxLifetime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProcessName);
            this.Controls.Add(this.labelInfoAboutExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartMon);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Monitor";
            this.Text = "Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитьToolStripMenuItem;
        private System.Windows.Forms.Button btnStartMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Label labelInfoAboutExit;
        private System.Windows.Forms.TextBox textBoxProcessName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaxLifetime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFrequencyTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxForTimer;
        private System.Windows.Forms.TextBox textBoxFreqTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}

    