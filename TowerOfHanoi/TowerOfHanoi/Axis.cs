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
        { }

        //  Добавить блинчик на ось
        public void AddPancak (Pancak pancak)
        {
            _AxisPancaks.Push(pancak);
        }

        //  Снять блинчик с оси
        public Pancak PopPancak ()
        {
            return _AxisPancaks.Pop();
        }
    }
}
