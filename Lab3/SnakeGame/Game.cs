using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Game
    {
        // создание экземпляров классов
        public static Food food = new Food(); 
        public static Snake snake = new Snake();
        public static bool GameOver = false;
        public static int level = 1;
        public Game ()
        {
            Init();
            Play();
        }
        public void Init()
        {
            Console.SetWindowSize(51,31);
            food.SetNewPosition(); //  появление еды в случайном месте
            while( Food.FoodinSnake() == true)
            {
                food.SetNewPosition();
            }
        }
        


        public void Play()
        {
            while (!GameOver) // пока змейка не столкнулась 
            {
                Draw(); // нарисовать змейку, еду и лабиринт
                ConsoleKeyInfo button = Console.ReadKey(); // считывание клавишей движения
               
                    if (button.Key == ConsoleKey.UpArrow)
                        snake.move(0, -1);
                    if (button.Key == ConsoleKey.DownArrow)
                        snake.move(0, 1);
                    if (button.Key == ConsoleKey.LeftArrow)
                        snake.move(-1, 0);
                    if (button.Key == ConsoleKey.RightArrow)
                        snake.move(1, 0);
                    if (button.Key == ConsoleKey.F2)
                        Save();
                    if (button.Key == ConsoleKey.F3)
                        Resume();
              
                }

            
            }
        public static void  EndGame() 
        {
            Console.Clear();// очищение консоля
            Console.SetCursorPosition(16, 13);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Game Over :)");// вывод надписи
            Console.SetCursorPosition(16, 14);
            Console.WriteLine("Try again ;)");// вывод надписи
            snake.body.Clear();
            Snake.SnakeNewPosition();
            Console.ReadKey();

        }
        public static void Draw()
        {
            Console.Clear();
            Display.display();
            snake.Draw();
            food.Draw();
        }
        public void Save()
        {
            snake.Save();
            food.Save();
        }
        public void Resume()
        {
            snake.Resume();
            food.Resume();
        }
    }
}
