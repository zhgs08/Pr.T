using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    [Serializable]
    class Food : Drawer
    {
        public Food()
        {
            color = ConsoleColor.Green;
            sign = 'o';

        }
        public void SetNewPosition()
        {
            body.Clear();
            Game.food.body.Add(new Point (new Random().Next(1, 49), new Random().Next(6, 29) ));
        }
        public static bool FoodinSnake() //проверить местонахождение еды в внутри змейки
        {
            for(int i=0; i<Game.snake.body.Count; i++)
                if (Game.food.body[0].x == Game.snake.body[i].x && Game.food.body[0].y == Game.snake.body[i].y)
                    return true;
            return false;
        }
    }
}
