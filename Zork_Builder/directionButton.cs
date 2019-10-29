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
    public partial class directionButton : UserControl
    {
        public WorldViewModel ViewModel { get; set; }

        //public Room Room
        //{
        //    //get => mRoom;
        //    //set
        //    //{
        //    //    mRoom = value;
        //    //    if (mRoom != null)
        //    //    {
        //    //        Neighbor = mRoom.Neighbors.TryValue(Directions, out Room neighbor) ? neighbor : null;
        //    //    }
        //    //    else
        //    //    {
        //    //        Neighbor = null;
        //    //    }
        //    //}
        //}

        public Room Neighbor { get; private set; }
        public object mRoom { get; private set; }

        public directionButton()
        {
            InitializeComponent();
        }
    }
}
