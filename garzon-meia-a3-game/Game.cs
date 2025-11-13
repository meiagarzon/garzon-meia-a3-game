using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Game
    {
        Color teal = new Color("#46929e");

        Player Fish = new Player(new Vector2(120, 250), new Vector2(60, 20), 100);
        FishBait[] fishBait =
        {
            new FishBait(new Vector2(820, 54), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 108), new Vector2(20, 30)),             
            new FishBait(new Vector2(820, 162), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 216), new Vector2(20, 30)),            
            new FishBait(new Vector2(820, 270), new Vector2(20, 30)),             
            new FishBait(new Vector2(820, 324), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 378), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 432), new Vector2(20, 30)),
            new FishBait(new Vector2(820, 486), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 540), new Vector2(20, 30)), 
        };



        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Fish Game");

            //calculate distance between each fish
            for (int bait = 0; bait < fishBait.Length; bait++)
            {
                fishBait[bait].pos.X += bait * 180;

                //position randomizer
                //fishBait[bait].pos.Y = Random.Integer(200, 500);
            }
        }

        public void Update()
        {                
            Window.ClearBackground(teal);

            Fish.Update();

            //draw array of fish
            for (int bait = 0; bait < fishBait.Length; bait++)
            {
                fishBait[bait].Update();
            }
        }
    }
}
