using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum Direction  //directions are normally stored as int but tutorial guy preferred written directions.
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            Speed = 10; //slowed down as apparently snake is difficult at top speed
            Score = 0;
            Points = 25; //you set this lower so don't be dumb when it doesn't match
            GameOver = false;
            direction = Direction.Down;
        }
    }


}
