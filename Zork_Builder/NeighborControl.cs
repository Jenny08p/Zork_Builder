using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zork_Common;

namespace Zork_Builder
{
    public partial class NeighborControl : UserControl
    {
        public Directions Direction
        {
            get => mDirection;
            set
            {
                mDirection = value;
                directionTextBox.Text = value.ToString();
            }
        }

        public Room Room
        {
            get => mRoom;
            set
            {
                mRoom = value;
                if (mRoom != null)
                {
                    // assign the neighbor
                }
                else
                {
                }
            }
        }


        public NeighborControl()
        {
            InitializeComponent();
        }


        private Directions mDirection;
        private Room mRoom;
    }
}
