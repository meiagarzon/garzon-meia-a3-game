// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Game
    {
        // Place your variables here:
        Color teal = new Color ("#46929e");
        Player Fish = new Player(new Vector2(120, 250), new Vector2 (60, 20), 100);
        Bait[] worms = 
        {
            new Bait(new Vector2(10, 10), new Vector2(10,10))
        };
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Fish Game");             
            Window.ClearBackground(teal);           
        }

        public void Update()
        {
            Fish.update();
            for (int bait = 0; bait < worms.Length; bait++)
            {
                worms[bait].Update();
            }            
        }
    }

}
