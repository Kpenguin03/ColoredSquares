using System;
using Raylib_cs;

namespace SquareMovement
{
    class Program
    {
        static void Main(string[] args)
        {
            const int screenWidth = 1600;
            const int screenHeight = 800;

            bool unit1Purchased = true; 
            bool unit2Purchased = false;
            bool unit3Purchased = false;
            bool unit4Purchased = false;

            int activeSquare = 1; // The currently active square
            int isPlaying = 1; // 1 = playing mode, 2 = buying mode
            int nextUnit = 2;
            Movement movement = new Movement(); // The movement object

            Raylib.InitWindow(screenWidth, screenHeight, "Square Movement");
            Raylib.SetTargetFPS(60);

            Rectangle square1 = new Rectangle(100, 100, 50, 50);
            Rectangle square2 = new Rectangle(200, 100, 50, 50);
            Rectangle square3 = new Rectangle(300, 100, 50, 50);

            List<Rectangle> squares = new List<Rectangle>(); //allows for multple charecters to be on screen at the same time. 
            Color[] colors = new Color[] { Color.BLUE, Color.GREEN, Color.RED, Color.YELLOW, Color.PINK, Color.PURPLE }; // saves the order of colors for ne charecters spawned.
            int colorIndex = 0; //keeps track of color in list abouve

            while (!Raylib.WindowShouldClose()) 
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);

                foreach (Rectangle square in squares)
                {
                    Raylib.DrawRectangleRec(square, Color.RED);
                }



                //This will let user purchase a seccond charecter
                if(isPlaying == 2 )
                {
                    if(Raylib.IsKeyPressed(KeyboardKey.KEY_Q) & nextUnit == 2)
                    {
                        //spawn unit type 1 for charecter 2
                        Rectangle newSquare = new Rectangle(50, 50, 50, 50); // create a new square at position (50, 50) with width and height of 50
                        squares.Add(newSquare); // add the new square to the list
                    }
                    if(Raylib.IsKeyPressed(KeyboardKey.KEY_W) & nextUnit == 2)
                    {
                        //spawn unit type 2 for charecter 2
                        Rectangle newSquare = new Rectangle(50, 50, 50, 50); // create a new square at position (50, 50) with width and height of 50
                        squares.Add(newSquare); // add the new square to the list
                    }
                }

                //Checks to see if a charecter has been purchased before showing on screen
                if(unit1Purchased == true)
                {
                    Raylib.DrawRectangleRec(square1, Color.BLUE);
                }
                if(unit2Purchased == true)
                {
                    Raylib.DrawRectangleRec(square2, Color.GREEN);
                }
                if(unit3Purchased == true)
                {
                    Raylib.DrawRectangleRec(square3, Color.RED);
                }

                //Checks wich charecter is active under user control
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
                {
                    activeSquare = 0;
                    isPlaying = 2;
                }
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE))
                {
                    activeSquare = 1;
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO))
                {
                    activeSquare = 2;
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE))
                {
                    activeSquare = 3;
                }

                //switch statement to see witch charecter is active.
                switch(activeSquare)  
                {
                case 1:
                    movement.Move(ref square1);
                    break;
                case 2:
                    movement.Move(ref square2);
                    break;
                case 3:
                    movement.Move(ref square3);
                    break;
                default:
                    // code block
                    break;
                }


                    
                //Thees draw the charecters but curenttly they are in if statments for spawnig. 
                // Raylib.DrawRectangleRec(square1, Color.BLUE);
                // Raylib.DrawRectangleRec(square2, Color.GREEN);
                // Raylib.DrawRectangleRec(square3, Color.RED);
                
                
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }


}
