// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            MyCoolFunction();
        }

        void MyCoolFunction()
        {
            if (2+4 == 6)
            {
                Draw.Rectangle(new Vector2(10, 10), new Vector2(100, 10));
            }
        }
    }

}
