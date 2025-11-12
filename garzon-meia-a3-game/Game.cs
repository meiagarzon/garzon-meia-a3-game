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
            new FishBait(new Vector2(820, 200), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 200), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 200), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 200), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 200), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 200), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 200), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 200), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 200), new Vector2(20, 30)), 
            new FishBait(new Vector2(820, 200), new Vector2(20, 30)), 
        };

        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Fish Game");
            for (int bait = 0; bait < fishBait.Length; bait++)
            {
                fishBait[bait].pos.X += bait * 180;
            }
        }

        public void Update()
        {                

            Window.ClearBackground(teal);
            Fish.Update();
            for (int bait = 0; bait < fishBait.Length; bait++)
            {
                fishBait[bait].Update();        
                
            }
        }

    }

}
