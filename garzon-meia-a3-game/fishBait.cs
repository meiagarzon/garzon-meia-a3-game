using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D;

public class FishBait
{
    Color brown = new Color("#925a3e");
    public Vector2 pos;

    Vector2 size;
    FishBait[] fishBaits = [];

    public FishBait(Vector2 pos, Vector2 size)
    {
        this.pos = pos;
        this.size = size;
        pos.X = pos.X + 800;
    }

    public void Update()
    {
        BaitMovement();
        DrawBait();
    }

    public void BaitMovement()
    {        
        pos.X = -pos.X - 400 * Time.SecondsElapsed;
    }

    public void DrawBait()
    {
        //draw fishing line
        Draw.LineSize = 1;
        Draw.LineColor = Color.White;
        Draw.Line(pos.X, pos.Y, pos.X, pos.Y - 600);

        //draw body
        Draw.FillColor = brown;
        Draw.LineColor = Color.Clear;
        Draw.Ellipse(pos, size);

        //draw tail
        Draw.FillColor = brown;
        Draw.LineColor = Color.Clear;
        Draw.Triangle(pos.X - 10, pos.Y + 20, pos.X, pos.Y + 5, pos.X + 10, pos.Y + 20);

        //draw eye
        Draw.FillColor = Color.Black;
        Draw.Circle(pos.X, pos.Y - 7, 2);

        //draw temporary hitbox
        //Draw.Rectangle(pos.X - 2, pos.Y - 3, size.X, size.Y);
    }
}
