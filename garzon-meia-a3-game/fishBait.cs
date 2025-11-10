using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D;

public class fishBait
{
    Vector2 pos;
    Vector2 size;
    fishBait[] fishBaits = [];

    public fishBait(Vector2 pos, Vector2 size)
    {
        this.pos = pos;
        this.size = size;
    }

    public void Update()
    {
        DrawBait();
    }

    public void DrawBait()
    {
        //hitbox
        Draw.FillColor = Color.Black;
        Draw.LineSize = 1;
        Draw.Ellipse(pos, size);        
        
        //draw line
        Draw.LineSize = 1;
        Draw.LineColor = Color.White;
        Draw.Line(pos.X, pos.Y, pos.X, pos.Y - 600);
    }
}

