using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TowerOfHanoi
{
    public partial class Form1 : Form
    {

        private Axis Axis1 = new Axis();
        private Axis Axis2 = new Axis();
        private Axis Axis3 = new Axis();
        private bool IsItPossibleToMove;
        static object locker = new object();

        public Form1()
        {
            InitializeComponent();
            Axis1.Parent = panel;
            Axis2.Left = Axis1.Width;
            Axis2.Parent = panel;
            Axis3.Left = Axis1.Width + Axis2.Width;
            Axis3.Parent = panel;
        }

        private void CountPancak_Enter(object sender, EventArgs e)
        {
            CountPancak.Clear();
        }

        private void CreatePancak_Click(object sender, EventArgs e)
        {
            try
            {
                //  Создать блинчики и поместить на первую ось
                int countPancak = int.Parse(CountPancak.Text);
                int differencePancak = 20;  //  разница между размером блинчиков
                int widthPancak = Axis1.Width - differencePancak;
                int xPancak = Axis1.Width - widthPancak - (differencePancak / 2);
                Random rnd = new Random();
                for (int i = 1; i <= countPancak; i++)
                {
                    //  создать случайный цвет блинчика                
                    int col = rnd.Next();
                    Color color = Color.FromArgb(col);
                    SolidBrush brush = new SolidBrush(color);

                    Pancak p = new Pancak(widthPancak, xPancak, brush);
                    widthPancak -= differencePancak;
                    xPancak += (differencePancak / 2);

                    Axis1.AddPancak(p);
                }
                Axis1.Refresh();
                PanelCreate.Enabled = false;
                PanelControl.Enabled = true;
                ManualControl.Checked = true;

                //  Запуск алгоритма
                StartPancak();
                RefrechTimer.Enabled = true;
            } catch(System.FormatException)
            {
                MessageBox.Show("Введите число блинчиков");
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка");
            }
        }
        //  метод, который вычисляет сам алгоритм
        private void Implementation (int countPancak, Axis output, Axis input, Axis buffer)
        {
            if (countPancak == 0) return;
            Implementation(countPancak - 1, output, buffer, input);

            //  Реализация задержки
            while (!IsItPossibleToMove)
                Thread.Sleep(100);

            //  Перемещение блинчика
            input.AddPancak(output.PopPancak());
            lock (locker)
            {
                IsItPossibleToMove = false;
            }

            Implementation(countPancak - 1, buffer, input, output);
        }

        private void AutoControl_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoControl.Checked == true)
            {
                Move.Enabled = false;
                TimerMove.Enabled = true;
            }
        }

        private void ManualControl_CheckedChanged(object sender, EventArgs e)
        {
            if (ManualControl.Checked == true)
            {
                Move.Enabled = true;
                TimerMove.Enabled = false;
            }
        }


        private void AutoInterval_Leave(object sender, EventArgs e)
        {
            try
            {
                double d = Double.Parse(AutoInterval.Text);
                if (d < 0.1) throw (new Exception());
                TimerMove.Interval = (int)(d * 1000);
            } catch
            {
                MessageBox.Show("Введено некоректное число. Десятичная чвсть должны отделятся запятой.");
            }
        }

        private void AutoInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) panel.Focus();
        }

        private void CountPancak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) panel.Focus();
        }

        private void CountPancak_Leave(object sender, EventArgs e)
        {
            CreatePancak_Click(new object(), new EventArgs());
        }

        private void TimerMove_Tick(object sender, EventArgs e)
        {
            lock (locker)
            {
                IsItPossibleToMove = true;
            }
            //  Перерисовка изменённый оьектов
        }

        // Ручное управление алгоритмом
        private void Move_Click(object sender, EventArgs e)
        {
            lock (locker)
            {
                IsItPossibleToMove = true;
            }
            //  Перерисовка изменённый оьектов
        }

        //  Обновление прорисовки столбцов
        private void FefreshAxis ()
        {
            Axis1.Refresh();
            Axis2.Refresh();
            Axis3.Refresh();
        }

        //  Сам алгоритм
        private async void StartPancak ()
        {
            await Task.Run(() => { Implementation(Axis1.CountPancak(), Axis1, Axis2, Axis3); });
        }

        private void Refrech_Tick(object sender, EventArgs e)
        {
            FefreshAxis();
        }
    }
}
