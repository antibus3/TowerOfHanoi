using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TowerOfHanoi
{
    public class Axis : PictureBox
    {
        //  Этото стак будет эмитировать ось с блинчиками
        private Stack<Pancak> _AxisPancaks = new Stack<Pancak>();
        
        public Axis ()
        {
            this.Width = 250;
            this.Height = 300;
            this.Paint += ThisPaint;
            
            
        }

        //  Добавить блинчик на ось
        public void AddPancak (Pancak pancak)
        {
            int yNewPancak = this.Height - ((_AxisPancaks.Count * 10) + 10);
            pancak.NewAxis(yNewPancak);
            _AxisPancaks.Push(pancak);
        }

        //  Снять блинчик с оси
        public Pancak PopPancak ()
        {
            return _AxisPancaks.Pop();
        }

        //  Метод события прорисовки
        private void ThisPaint (object sender, PaintEventArgs e)
        {
            DrawColumn(e.Graphics);
            DrawPancak(e.Graphics);
        }

        //  Рисование столбца для блинчиков
        private void DrawColumn (Graphics g)
        {
            Brush colorColumn = Brushes.Black;
            g.FillRectangle(colorColumn, this.Width / 2 - 5, 100, 10, this.Height - 100);
        }

        // метод прорисовки блинчиков
        private void DrawPancak (Graphics g)
        {
            foreach (Pancak p in _AxisPancaks)
            {
                p.Draw(g);
            }
        }

        public int CountPancak ()
        {
            return _AxisPancaks.Count;
        }


    }
}
