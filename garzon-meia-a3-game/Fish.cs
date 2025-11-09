using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D;

public class Player
{
    //place variables here
    Vector2 pos;
    Vector2 size;
    float velocity;
    float gravity = 200;
    float jumpHeight;

    public Player(Vector2 position, Vector2 size, float jumpHeight)
    {
        this.pos = position;
        this.size = size;
        this.jumpHeight = jumpHeight;
    }

    public void Update()
    {
        DrawFish();
        PlayerGravity();
        PlayerMovement();
        GameOver();
    }
    
    public void PlayerMovement()
    {
        if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
        {
            velocity -= jumpHeight;
        }
    }

    public void DrawFish()
    {
        //draw body
        Draw.FillColor = Color.Yellow;
        Draw.Ellipse(pos.X, pos.Y, size.X, size.Y);

        //draw tail
        Draw.FillColor = Color.Yellow;
        Draw.Triangle(pos.X - 33, pos.Y + 12, pos.X - 15, pos.Y, pos.X - 33, pos.Y - 12);

        //draw eye
        Draw.FillColor = Color.Black;
        Draw.Circle(pos.X + 20, pos.Y, 3);
    }

    public void PlayerGravity()
    {
        //apply gravity
        velocity += gravity * Time.DeltaTime;
        //move player
        pos.Y += velocity * Time.DeltaTime;
    }

    public void GameOver()
    {
        if (pos.Y + 20 >= Window.Height)
        {
            Window.ClearBackground(Color.Black);
            Text.Size = 35;
            Text.Color = Color.Red;
            string gameOver = "Your fish is dead. GAME OVER!";
            Text.Draw(gameOver, 130, 280);

            //restart
            Text.Size = 25;
            Text.Color = Color.Red;
            string restart = "Press [SPACE] to restart.";
            Text.Draw(restart, 230, 500);
        }            
        
    }
}
