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
    float velocity = 0;
    float gravity = 200;
    float jumpHeight;

    public Player(Vector2 pos, Vector2 size, float jumpHeight)
    {
        this.pos = pos;
        this.size = size;
        this.jumpHeight = jumpHeight;
    }

    public void update()
    {
        DrawFish();
        PlayerGravity();
        PlayerMovement();
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
        Draw.LineSize = 0;
        Draw.LineColor = Color.Clear;
        Draw.Ellipse(pos.X, pos.Y, size.X, size.Y);
    }    

    public void PlayerGravity()
    {
        //apply gravity
        velocity += gravity * Time.DeltaTime;
        //move player
        pos.Y += velocity * Time.DeltaTime;
    }

}
