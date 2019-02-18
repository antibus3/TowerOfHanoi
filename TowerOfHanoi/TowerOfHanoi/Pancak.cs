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
        private Pen _PenOfPancak;


        public Pancak ()
        { }

        public Pancak (int width, Pen pen)
        {
            _PancakVisible = new Rectangle(0, 0, width, 10);
            _PenOfPancak = pen;
        }

        //  Метод, отображающий блинчик на оси
        public void Draw (Graphics g)
        {
            g.DrawRectangle(_PenOfPancak, _PancakVisible);
        }




    }
}
