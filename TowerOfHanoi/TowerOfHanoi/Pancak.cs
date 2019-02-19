using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TowerOfHanoi
{
    public class Pancak
    {
        private Rectangle _PancakVisible;
        private Brush _BrushOfPancak;

        


        public Pancak ()
        { }

        public Pancak(int width, int x, Brush brush)
        {
            _PancakVisible = new Rectangle(x, 0, width, 10);
            _BrushOfPancak = brush;
        }

        //  Метод, отображающий блинчик на оси
        public void Draw (Graphics g)
        {
            g.DrawRectangle(Pens.Black, _PancakVisible);
            g.FillRectangle(_BrushOfPancak, _PancakVisible);
        }

        public void NewAxis (int y)
        {
            _PancakVisible.Y = y;
        }




    }
}
