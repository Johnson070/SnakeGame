using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    class snake
    {
        public byte eatFoodTrigger { get; set; }
        public int[] numCells { get; set; } = new int[2];
        public int cellSize { get; set; }
        public int direction { get; set; }
        public Graphics snakeTable { get; set; }
        private int[] snakeEat { get; set; } = new int[2];
        private int[] snakeEatMass { get; set; } = new int[2];
        public List<int[]> snakeBody { get; set; } = new List<int[]>();
        private bool delSnakePart { get; set; }
        public bool gameOver { get; set; }
        private bool foodGen { get; set; }
        public bool barrier { get; set; }
        public bool winGame { get; set; }
        private List<int[]> foodTable { get; set; }

        public stats stata { get; set; }

        public class stats
        {
            public int foodEat;
            public int foodEatMass;
            public int time;
            public int score;
            public int length;
        }

        public void resize(Graphics _snakeTable)
        {
            snakeTable = _snakeTable;
        }

        public void foodMap(structLevelGame levelGame)
        {
            int[,] tableFill = new int[numCells[0], numCells[1]];

            List<int[]> foodPos = new List<int[]>();

            foreach (int[] block in levelGame.table)
            {
                if (block[2] == 0)
                {
                    tableFill[block[0], block[1]] = 1;
                }
                else if (block[2] == 1)
                {
                    tableFill[block[0], block[1]] = block[3];
                }

                if (block[2] == 2)
                {
                    foodPos.Add(new int[] { block[0], block[1] });
                }
            }

            for (int i = 0; i < foodPos.Count; i++)
            {
                int[] point = foodPos[i];

                if (point[0] - 1 >= 0 && (tableFill[point[0] - 1, point[1]] == 0 || (tableFill[point[0] - 1, point[1]] > 1 && stata.score > tableFill[point[0] - 1, point[1]])))
                {
                    foodPos.Add(new int[] { point[0] - 1, point[1] });
                    tableFill[point[0] - 1, point[1]] = -1;
                }
                if (point[0] + 1 < numCells[0] && (tableFill[point[0] + 1, point[1]] == 0 || (tableFill[point[0] + 1, point[1]] > 1 && stata.score > tableFill[point[0] + 1, point[1]])))
                {
                    foodPos.Add(new int[] { point[0] + 1, point[1] });
                    tableFill[point[0] + 1, point[1]] = -1;
                }
                if (point[1] - 1 >= 0 && (tableFill[point[0], point[1] - 1] == 0 || (tableFill[point[0], point[1] - 1] > 1 && stata.score > tableFill[point[0], point[1] - 1])))
                {
                    foodPos.Add(new int[] { point[0], point[1] - 1 });
                    tableFill[point[0], point[1] - 1] = -1;
                }
                if (point[1] + 1 < numCells[1] && (tableFill[point[0], point[1] + 1] == 0 || (tableFill[point[0], point[1] + 1] > 1 && stata.score > tableFill[point[0], point[1] + 1])))
                {
                    foodPos.Add(new int[] { point[0], point[1] + 1 });
                    tableFill[point[0], point[1] + 1] = -1;
                }
            }

            //foreach (int[] point in foodPos)
            //{
            //    snakeTable.FillRectangle(Brushes.Red, 1 + point[0] * cellSize, 1 + point[1] * cellSize, cellSize - 1, cellSize - 1);
            //}

            foodTable = foodPos;
        }

        public void foodFactory(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            double massFood = rnd.NextDouble();

            int x, y;

            if (foodTable != null)
            {
                int pos = rnd.Next(0, foodTable.Count - 1);

                x = foodTable[pos][0];
                y = foodTable[pos][1];
            }
            else
            {
                x = rnd.Next(0, numCells[0]);
                y = rnd.Next(0, numCells[1]);
            }

            while (true)
            {
                bool match = false;

                foreach (int[] body in snakeBody)
                {
                    if (body[0] == x && body[1] == y)
                    {
                        match = true;
                        break;
                    }
                }

                if (!match) goto next;
                else
                {
                    if (foodTable != null)
                    {
                        int pos = rnd.Next(0, foodTable.Count - 1);

                        x = foodTable[pos][0];
                        y = foodTable[pos][1];
                    }
                    else
                    {
                        x = rnd.Next(0, numCells[0]);
                        y = rnd.Next(0, numCells[1]);
                    }
                }
            }

            next:

            if (foodGen)
            {
                foodGen = false;

                if (massFood >= 0 && massFood <= 0.1)
                {
                    snakeEatMass = new int[] { x, y };
                    snakeTable.FillEllipse(Brushes.IndianRed, x * cellSize, y * cellSize, cellSize, cellSize);
                }
                else
                {
                    snakeEat = new int[] { x, y };
                    snakeTable.FillEllipse(Brushes.OrangeRed, x * cellSize + cellSize / 4, y * cellSize + cellSize / 4, cellSize / 2, cellSize / 2);
                }

                
            }
        }

        public void eatFood()
        {
            if (snakeBody[snakeBody.Count - 1][0] == snakeEat[0] && snakeBody[snakeBody.Count - 1][1] == snakeEat[1])
            {
                stata.foodEat += 1;
                stata.length += 1;
                stata.score += 1;

                eatFoodTrigger = 1;
                foodGen = true;

                snakeEat = new int[] { -1, -1 };
            }
            else if (snakeBody[snakeBody.Count - 1][0] == snakeEatMass[0] && snakeBody[snakeBody.Count - 1][1] == snakeEatMass[1])
            {
                stata.foodEatMass += 1;
                stata.length += 2;
                stata.score += 10;

                eatFoodTrigger = 2;
                foodGen = true;

                snakeEatMass = new int[] { -1, -1 };
            }
        }

        public void drawLines()
        {
            clearTable();

            if (barrier)
            {
                snakeTable.DrawLine(new Pen(Color.Black), 0, 0, 0, numCells[1] * cellSize);
                snakeTable.DrawLine(new Pen(Color.Black), 0, 0, numCells[0] * cellSize, 0);
                snakeTable.DrawLine(new Pen(Color.Black), numCells[0] * cellSize, numCells[1] * cellSize, 0, numCells[1] * cellSize);
                snakeTable.DrawLine(new Pen(Color.Black), numCells[0] * cellSize, numCells[1] * cellSize, numCells[0] * cellSize, 0);
            }
        }

        public void clearTable()
        {
            snakeTable.Clear(Color.LightGray);

            for (int i = 0; i < numCells[0]; i++)
            {
                for (int j = 0; j < numCells[1]; j++)
                {
                    snakeTable.FillRectangle(Brushes.White, 1 + i * cellSize, 1 + j * cellSize, cellSize - 1, cellSize - 1);
                }
            }
        }

        public void snakeDirection(int _direction)
        {
            int pastDirection = direction;

            int incX = 0;
            int incY = 0;

            if (Math.Abs(_direction - pastDirection) == 2)
            {
                _direction = pastDirection;
            }

            switch (_direction)
            {
                case 1: incY = -1; break;
                case 2: incX = 1; break;
                case 3: incY = 1; break;
                case 4: incX = -1; break;
                default: break;
            }

            foreach (int[] pos in snakeBody)
            {
                if ((snakeBody[snakeBody.Count - 1][0] + incX == pos[0] && snakeBody[snakeBody.Count - 1][1] + incY == pos[1]))
                {
                    gameOver = true;
                }
            }

            int headBoxX = snakeBody[snakeBody.Count - 1][0];
            int headBoxY = snakeBody[snakeBody.Count - 1][1];


            if ((headBoxX + incX >= 0 && headBoxX + incX < numCells[0] && headBoxY + incY >= 0 && headBoxY + incY < numCells[1]) || !barrier)
            {
                incX += barrierSnake(snakeBody[snakeBody.Count - 1][0], incX, numCells[0]);
                incY += barrierSnake(snakeBody[snakeBody.Count - 1][1], incY, numCells[1]);

                snakeBody.Add(new int[] { snakeBody[snakeBody.Count - 1][0] + incX, snakeBody[snakeBody.Count - 1][1] + incY });
                if (eatFoodTrigger > 0)
                {
                    eatFoodTrigger -= 1;
                    delSnakePart = false;
                }
                else delSnakePart = true;
            }
            else
            {
                delSnakePart = false;
                gameOver = true;
            }

            eatFood();

            direction = _direction;
        }

        private int barrierSnake(int a, int xy, int _numCells)
        {
            if (a + xy >= _numCells)
            {
                return -_numCells;
            }
            else if (a + xy < 0)
            {
                return _numCells;
            }
            else return 0;
        }

        public void snakeDraw()
        {
            snakeTable.FillRectangle(Brushes.Green, 1 + snakeBody[snakeBody.Count - 1][0] * cellSize, 1 + snakeBody[snakeBody.Count - 1][1] * cellSize, cellSize - 1, cellSize - 1);

            if (delSnakePart)
            {
                snakeTable.FillRectangle(Brushes.White, 1 + snakeBody[0][0] * cellSize, 1 + snakeBody[0][1] * cellSize, cellSize - 1, cellSize - 1);
                snakeBody.RemoveAt(0);

                delSnakePart = false;
            }

            if (snakeEat != new int[] { -1, -1})
            {
                snakeTable.FillEllipse(Brushes.OrangeRed, snakeEat[0] * cellSize + cellSize / 4, snakeEat[1] * cellSize + cellSize / 4, cellSize / 2, cellSize / 2);
            }
            else if (snakeEatMass != new int[] { -1, -1 })
            {
                snakeTable.FillEllipse(Brushes.IndianRed, snakeEatMass[0] * cellSize, snakeEatMass[1] * cellSize, cellSize, cellSize);
            }
        }

        public snake(int _numCellsX, int _numCellsY, int _cellSize, int _direction, Graphics _snakeTable, bool _barrier, int[] _snakeBody)
        {
            numCells[0] = _numCellsX;
            numCells[1] = _numCellsY;
            cellSize = _cellSize;
            direction = _direction;
            snakeTable = _snakeTable;
            barrier = _barrier;
            snakeEat = new int[] { -1, -1 };
            snakeEatMass = new int[] { -1, -1 };
            foodGen = true;
            snakeBody.Add(_snakeBody);
            stata = new stats();
        }
    }
}
