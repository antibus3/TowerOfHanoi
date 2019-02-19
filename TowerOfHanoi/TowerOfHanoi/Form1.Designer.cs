namespace TowerOfHanoi
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
            this.panel = new System.Windows.Forms.Panel();
            this.CreatePancak = new System.Windows.Forms.Button();
            this.CountPancak = new System.Windows.Forms.TextBox();
            this.PanelControl = new System.Windows.Forms.Panel();
            this.Move = new System.Windows.Forms.Button();
            this.AutoText = new System.Windows.Forms.Label();
            this.AutoInterval = new System.Windows.Forms.TextBox();
            this.ManualControl = new System.Windows.Forms.RadioButton();
            this.AutoControl = new System.Windows.Forms.RadioButton();
            this.PanelCreate = new System.Windows.Forms.Panel();
            this.TimerMove = new System.Windows.Forms.Timer(this.components);
            this.RefrechTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelControl.SuspendLayout();
            this.PanelCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(19, 145);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(769, 349);
            this.panel.TabIndex = 3;
            // 
            // CreatePancak
            // 
            this.CreatePancak.Location = new System.Drawing.Point(3, 3);
            this.CreatePancak.Name = "CreatePancak";
            this.CreatePancak.Size = new System.Drawing.Size(75, 23);
            this.CreatePancak.TabIndex = 4;
            this.CreatePancak.Text = "Создать";
            this.CreatePancak.UseVisualStyleBackColor = true;
            this.CreatePancak.Click += new System.EventHandler(this.CreatePancak_Click);
            // 
            // CountPancak
            // 
            this.CountPancak.Location = new System.Drawing.Point(84, 5);
            this.CountPancak.Name = "CountPancak";
            this.CountPancak.Size = new System.Drawing.Size(194, 20);
            this.CountPancak.TabIndex = 5;
            this.CountPancak.Text = "Введите число блинчиков (Max 10)";
            this.CountPancak.Enter += new System.EventHandler(this.CountPancak_Enter);
            this.CountPancak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountPancak_KeyPress);
            this.CountPancak.Leave += new System.EventHandler(this.CountPancak_Leave);
            // 
            // PanelControl
            // 
            this.PanelControl.Controls.Add(this.Move);
            this.PanelControl.Controls.Add(this.AutoText);
            this.PanelControl.Controls.Add(this.AutoInterval);
            this.PanelControl.Controls.Add(this.ManualControl);
            this.PanelControl.Controls.Add(this.AutoControl);
            this.PanelControl.Enabled = false;
            this.PanelControl.Location = new System.Drawing.Point(20, 61);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(768, 71);
            this.PanelControl.TabIndex = 6;
            // 
            // Move
            // 
            this.Move.Location = new System.Drawing.Point(379, 40);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(134, 23);
            this.Move.TabIndex = 4;
            this.Move.Text = "Переместить";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // AutoText
            // 
            this.AutoText.AutoSize = true;
            this.AutoText.Location = new System.Drawing.Point(14, 43);
            this.AutoText.Name = "AutoText";
            this.AutoText.Size = new System.Drawing.Size(117, 13);
            this.AutoText.TabIndex = 3;
            this.AutoText.Text = "Интервал с.(min 0,1с.)";
            // 
            // AutoInterval
            // 
            this.AutoInterval.Location = new System.Drawing.Point(165, 40);
            this.AutoInterval.Name = "AutoInterval";
            this.AutoInterval.Size = new System.Drawing.Size(35, 20);
            this.AutoInterval.TabIndex = 2;
            this.AutoInterval.Text = "0.5";
            this.AutoInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoInterval_KeyPress);
            this.AutoInterval.Leave += new System.EventHandler(this.AutoInterval_Leave);
            // 
            // ManualControl
            // 
            this.ManualControl.AutoSize = true;
            this.ManualControl.Location = new System.Drawing.Point(379, 16);
            this.ManualControl.Name = "ManualControl";
            this.ManualControl.Size = new System.Drawing.Size(134, 17);
            this.ManualControl.TabIndex = 1;
            this.ManualControl.TabStop = true;
            this.ManualControl.Text = "Ручное перемещение";
            this.ManualControl.UseVisualStyleBackColor = true;
            this.ManualControl.CheckedChanged += new System.EventHandler(this.ManualControl_CheckedChanged);
            // 
            // AutoControl
            // 
            this.AutoControl.AutoSize = true;
            this.AutoControl.Location = new System.Drawing.Point(17, 16);
            this.AutoControl.Name = "AutoControl";
            this.AutoControl.Size = new System.Drawing.Size(183, 17);
            this.AutoControl.TabIndex = 0;
            this.AutoControl.TabStop = true;
            this.AutoControl.Text = "Автоматическое перемещение";
            this.AutoControl.UseVisualStyleBackColor = true;
            this.AutoControl.CheckedChanged += new System.EventHandler(this.AutoControl_CheckedChanged);
            // 
            // PanelCreate
            // 
            this.PanelCreate.Controls.Add(this.CreatePancak);
            this.PanelCreate.Controls.Add(this.CountPancak);
            this.PanelCreate.Location = new System.Drawing.Point(20, 23);
            this.PanelCreate.Name = "PanelCreate";
            this.PanelCreate.Size = new System.Drawing.Size(282, 32);
            this.PanelCreate.TabIndex = 7;
            // 
            // TimerMove
            // 
            this.TimerMove.Interval = 500;
            this.TimerMove.Tick += new System.EventHandler(this.TimerMove_Tick);
            // 
            // RefrechTimer
            // 
            this.RefrechTimer.Tick += new System.EventHandler(this.Refrech_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.PanelCreate);
            this.Controls.Add(this.PanelControl);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelControl.ResumeLayout(false);
            this.PanelControl.PerformLayout();
            this.PanelCreate.ResumeLayout(false);
            this.PanelCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button CreatePancak;
        private System.Windows.Forms.TextBox CountPancak;
        private System.Windows.Forms.Panel PanelControl;
        private System.Windows.Forms.Panel PanelCreate;
        private System.Windows.Forms.RadioButton ManualControl;
        private System.Windows.Forms.RadioButton AutoControl;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Label AutoText;
        private System.Windows.Forms.TextBox AutoInterval;
        private System.Windows.Forms.Timer TimerMove;
        private System.Windows.Forms.Timer RefrechTimer;
    }
}

