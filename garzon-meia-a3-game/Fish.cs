using MohawkGame2D;
using System;
using System.Numerics;

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
       //FishHitbox();
       //FishCollision();
    }

    /*public void FishCollision()
    {
        float fishWidth = pos.X - 30;
        float fishHeight = pos.X - 11;
    }*/

    private void PlayerMovement()
    {
        if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
        {
            velocity -= jumpHeight;
        }
    }

    private void DrawFish()
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

    /*public void FishHitbox()
    {
        //draw hitbox
        Draw.Rectangle(pos.X - 30, pos.Y - 11, 60, 20);
    }*/

    private void PlayerGravity()
    {
        //apply gravity
        velocity += gravity * Time.DeltaTime;
        //move player
        pos.Y += velocity * Time.DeltaTime;
    }

    private void GameOver()
    {
        //fish is above window
        if (pos.Y - 10 <= 0)
        {
            Window.ClearBackground(Color.Black);
            Text.Size = 35;
            Text.Color = Color.Red;
            string gameOver = "Your fish is dead. GAME OVER!";
            Text.Draw(gameOver, 130, 265);

            //restart
            Text.Size = 25;
            Text.Color = Color.Red;
            string restart = "Press [SPACE] to restart.";
            Text.Draw(restart, 230, 500);
        }

        //fish is below window
        if (pos.Y + 10 >= 600)
        {
            Window.ClearBackground(Color.Black);
            Text.Size = 35;
            Text.Color = Color.Red;
            string gameOver = "Your fish is dead. GAME OVER!";
            Text.Draw(gameOver, 130, 265);

            //restart
            Text.Size = 25;
            Text.Color = Color.Red;
            string restart = "Press [SPACE] to restart.";
            Text.Draw(restart, 230, 500);
        }
    }
}
