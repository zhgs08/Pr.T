using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    [Serializable]
    class Snake: Drawer
    {
        
        public static int score = 0;// создать переменную для подсчитывания очков
        public Snake()
        {
            color = ConsoleColor.White;
            sign = '*';
            body.Add(new Point(10, 10));
           
        }
 
    
        public void move(int dx, int dy)// функция, которая позволяет двигаться змейке
        {
            for (int i = body.Count - 1; i > 0; i--)
            { 
                body[i].x = body[i - 1].x;// каждый следующий элемент будет наследовать информацию от предыдущего
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;// голова получает направление по координатам
            body[0].y += dy;

            if (body[0].x == -1) Game.EndGame(); // игра заканчивается, если змейка выходит за пределы поля
            if (body[0].y == 3) Game.EndGame();
            if (body[0].x == 50) Game.EndGame();
            if (body[0].y == 30) Game.EndGame();
        
            if (SnakeinSnake() == true)// игра заканчивается, если змейка сталкивается сама с собой
            {
                Game.EndGame();
            }
            if (body[0].x == Game.food.body[0].x &&// проверить, съедает ли змейка еду
                body[0].y == Game.food.body[0].y)
            {
                body.Add(new Point(0, 0));// если съедает, змейка перемещается на новое место
                

                Game.food.SetNewPosition();
                while(Food.FoodinSnake() == true)
                {
                    Game.food.SetNewPosition();
                }
                score++; // прибавляются очки 

                if (score % 4 == 0)// через каждые 4 очка змейка переходит на новый уровень
                {
                    Game.level++;
                    Game.snake.body.Clear(); // змейка становится первоначальной
                    SnakeNewPosition();
                }

            }
        }
        public static void SnakeNewPosition() // новое место для появлении змейки
        {
            Game.snake.body.Clear();
            Random r = new Random();
            Game.snake.body.Add(new Point(r.Next(3, 49), r.Next(6, 29)));

        }
        public static bool SnakeinSnake()    //проверка на появлении еды для змейке
        {
            for( int i=1; i<Game.snake.body.Count; i++)
            {
                if (Game.snake.body[0].x == Game.snake.body[i].x && Game.snake.body[0].y == Game.snake.body[i].y)
                    return true;               
            }
            return false;
        }   
    }
}
