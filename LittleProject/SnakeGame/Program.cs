using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LittleProject.SnakeGame
{
    class Program
    {
        private class Posisi
        {
            public int left;
            public int top;
        }

        private static List<Posisi> point = new List<Posisi>();
        private static int _length = 3;
        private static int _score = 0;
        private static DateTime nextUpdate = DateTime.MinValue;
        private static Posisi _foodPosition = null;
        private static Random _rnd = new Random();
        static ConsoleKeyInfo? _lastKey;
        private static bool _inPlay = true;


        static void Main()
        {
            Console.CursorVisible = false;
            DrawScreen();
            while (_inPlay)
            {
                if (AcceptInput() || UpdateGame())
                    DrawScreen();
            }
        }

        private static void DrawScreen()
        {
            Console.Clear();
            foreach (var poin in point)
            {
                Console.SetCursorPosition(poin.left, poin.top);
                Console.Write("*");
            }

            if (_foodPosition != null)
            {
                Console.SetCursorPosition(_foodPosition.left, _foodPosition.top);
                Console.Write("X");
            }

            Console.WriteLine(_score);
        }

        private static bool AcceptInput()
        {
            if (!Console.KeyAvailable)
                return false;

            _lastKey = Console.ReadKey();

            return true;
        }

        private static void Move(ConsoleKeyInfo key)
        {
            Posisi currentPosisi;

            if (point.Count != 0)
                currentPosisi = new Posisi() { left = point.Last().left, top = point.Last().top };
            else
                currentPosisi = GetStartPosition();

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currentPosisi.left--;
                    break;
                case ConsoleKey.RightArrow:
                    currentPosisi.left++;
                    break;
                case ConsoleKey.UpArrow:
                    currentPosisi.top--;
                    break;
                case ConsoleKey.DownArrow:
                    currentPosisi.top++;
                    break;

            }

            DetectCollision(currentPosisi);

            point.Add(currentPosisi);
            CleanUp();
        }

        private static void GameOver()
        {
            _inPlay = false;
            Console.Clear();
            Console.WriteLine("Game Over");
        }

        private static Posisi GetStartPosition()
        {
            return new Posisi()
            {
                left = 0,
                top = 0
            };
        }


        private static void CleanUp()
        {
            while (point.Count > _length)
            {
                point.Remove(point.First());
            }
        }

        private static bool UpdateGame()
        {
            if (DateTime.Now < nextUpdate) return false;

            if (_foodPosition == null)
            {
                _foodPosition = new Posisi()
                {
                    left = _rnd.Next(Console.WindowWidth),
                    top = _rnd.Next(Console.WindowHeight)
                };
            }

            if (_lastKey.HasValue)
            {
                Move(_lastKey.Value);
            }

            nextUpdate = DateTime.Now.AddMilliseconds(500 / (_score + 1));
            return true;
        }

        private static void DetectCollision(Posisi currentPosisi)
        {
            // Cek apakah kita offscreen (menabrak dinding)
            if (currentPosisi.top < 0 || currentPosisi.top > Console.WindowHeight
               || currentPosisi.left < 0 || currentPosisi.left > Console.WindowWidth)
            {
                GameOver();
            }
            // cek apakah kita menabrak buntut ular sendiri
            if (point.Any(x => x.left == currentPosisi.left && x.top == currentPosisi.top))
                GameOver();

            // cek apakah kita memakan food
            if(_foodPosition.left == currentPosisi.left && _foodPosition.top == currentPosisi.top)
            {
                _length++;
                _score++;
                _foodPosition = null;
            }
        }
    }
}
