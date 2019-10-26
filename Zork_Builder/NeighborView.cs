using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zork_Common;

namespace Zork_Builder
{
    internal partial class NeighborView : UserControl 
    {
        public WorldViewModel ViewModel { get; set; }

        public NeighborView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public Room Room
        {
            get => mRoom;
            set
            {
                mRoom = value;
                if (mRoom != null)
                {
                   // Neighbor = mRoom.Neighbors.TryGetValue(Directions, out Room neighbor) ? neighbor : null; 
                }
                else
                {
                    Neighbor = null;
                }
            }
        }

        //public Directions Direction
        //{

        //}

        public Room Neighbor
        {
            get => mNeighbor;
            set
            {
                mNeighbor = value;
            }
        }
        private Room mRoom;
        private Room mNeighbor;
        private Directions mDirection;

    }
}
