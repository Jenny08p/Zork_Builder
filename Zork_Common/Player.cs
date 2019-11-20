using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace Zork_Common

{
    public class Player
    {
        public event EventHandler<int> ScoreChanged;
        public event EventHandler<int> PlayerMoved;

        public World World { get; }

        private int mScore;
        private int mMove;
        public int Score
        {
            get => mScore;
            set
            {
                mScore = value;
                ScoreChanged?.Invoke(this, mScore);
            }
        }

        [JsonIgnore]

        public Room Location { get; private set; }


        [JsonIgnore]

        public string LocationName
        {
            get
            {
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }

        public int Moves { get; set; }

        public int CustomMoves
        {
            get => mMove;
            set
            {
                mMove = value;
                PlayerMoved?.Invoke(this, mMove);
            }
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                Location = destination;
            }

            return isValidMove;
        }
    }
}