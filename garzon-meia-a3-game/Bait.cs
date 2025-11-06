using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D;

public class Bait
{
    //place variables here
    Vector2 pos;
    Vector2 size;

    public Bait(Vector2 pos, Vector2 size)
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
        Draw.FillColor = Color.Clear;
        Draw.LineSize = 1;
        Draw.Rectangle(pos, size);
    }
}

