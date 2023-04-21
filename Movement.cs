using System;
using Raylib_cs;

namespace SquareMovement{
    class Movement
    {
        private const int moveSpeed = 5;

        public void Move(ref Rectangle square)
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) || Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                square.x += moveSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) || Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                square.x -= moveSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) || Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                square.y += moveSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) || Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                square.y -= moveSpeed;
            }
        }
    }
}