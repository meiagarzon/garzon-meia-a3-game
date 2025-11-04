// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Game
    {
        // Place your variables here:
        Color turquoise = new Color ("#6d8d8a");
         
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Fish Game");
            Window.ClearBackground(turquoise);
        }

        public void Update()
        {
            
        }
    }

}
