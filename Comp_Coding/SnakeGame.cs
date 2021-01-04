using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class SnakeGame
    {
        /** Initialize your data structure here.
       @param width - screen width
       @param height - screen height 
       @param food - A list of food positions
       E.g food = [[1,1], [1,0]] means the first food is positioned at [1,1], the second is at [1,0]. */

        // int[][] snake_grid;
        Queue<string> food_Set;
        HashSet<string> snake_locations;
        StringBuilder sb;
        int score; int x = 0; int y = 0;
        Queue<string> movement;
        int rows; int cols;
        public SnakeGame(int width, int height, int[][] food)
        {
            score = 0; rows = height; cols = width;
            movement = new Queue<string>();
            movement.Enqueue("00");
            snake_locations = new HashSet<string>();
            snake_locations.Add("00");
            //     snake_grid = new int[height][];
            food_Set = new Queue<string>();

            // for(int i = 0; i < height; i++)
            // {
            //     snake_grid[i] = new int[width];
            // }

            foreach (int[] f in food)
            {
                sb = new StringBuilder();
                sb.Append(f[0]); sb.Append("_"); sb.Append(f[1]);
                food_Set.Enqueue(sb.ToString());
            }

        }

        /** Moves the snake.
            @param direction - 'U' = Up, 'L' = Left, 'R' = Right, 'D' = Down 
            @return The game's score after the move. Return -1 if game over. 
            Game over when snake crosses the screen boundary or bites its body. */
        public int Move(string direction)
        {
            if (direction == "U")
            {
                x -= 1;
            }

            else if (direction == "D")
            {
                x += 1;
            }

            else if (direction == "L")
            {
                y -= 1;
            }
            //Direction == R
            else
            {
                y += 1;
            }

            sb = new StringBuilder();
            sb.Append(x); sb.Append("_"); sb.Append(y);
            string location = sb.ToString();
            if (food_Set.Count > 0 && food_Set.Peek().Equals(location))
            {
                score += 1;
                food_Set.Dequeue();
                snake_locations.Add(location);
                movement.Enqueue(location);
            }

            else if (!isValid(x, rows) || !isValid(y, cols))
            {
                return -1;
            }

            else if (snake_locations.Contains(location) && !movement.Peek().Equals(location))
            {
                return -1;
            }

            else
            {
                if(!snake_locations.Contains(location))
                {
                    snake_locations.Add(location);
                    movement.Enqueue(location);
                    snake_locations.Remove(movement.Dequeue());
                }
                
                else
                {
                    movement.Enqueue(location);
                    movement.Dequeue();
                }
            }

            return score;
        }

        public bool isValid(int a, int b)
        {
            if (a >= 0 && a < b)
                return true;
            return false;
        }
    }
}
