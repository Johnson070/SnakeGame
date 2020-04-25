using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SnakeGame
{
    class snakeLevelGame
    {
        public structLevelGame game;

        public void checkPos(snake _game)
        {
            foreach (int[] point in game.table)
            {
                if (point[2] == 0 && point[0] == _game.snakeBody[_game.snakeBody.Count - 1][0] && point[1] == _game.snakeBody[_game.snakeBody.Count - 1][1])
                {
                    _game.gameOver = true;
                }
                else if (point[2] == 1 && _game.stata.score < point[3] && point[0] == _game.snakeBody[_game.snakeBody.Count - 1][0] && point[1] == _game.snakeBody[_game.snakeBody.Count - 1][1])
                {
                    _game.gameOver = true;
                }
                else if (point[2] == 3 && _game.stata.score >= game.scoreWin && point[0] == _game.snakeBody[_game.snakeBody.Count - 1][0] && point[1] == _game.snakeBody[_game.snakeBody.Count - 1][1])
                {
                    _game.winGame = true;
                }
            }
        }

        public void drawLevel(Graphics table, snake.stats snakeStats)
        {
            if (game != null)
            {
                for (int i = 0; i < game.table.Count; i++)
                {
                    int[] point = game.table[i];

                    switch (point[2])
                    {
                        case 0:
                            table.FillRectangle(Brushes.Black, 1 + point[0] * game.cellSize, 1 + point[1] * game.cellSize, game.cellSize - 1, game.cellSize - 1);
                            break;
                        case 1:
                            if (point[3] > snakeStats.score) table.FillRectangle(Brushes.Red, 1 + point[0] * game.cellSize, 1 + point[1] * game.cellSize, game.cellSize - 1, game.cellSize - 1);
                            else
                            {
                                table.FillRectangle(Brushes.White, 1 + point[0] * game.cellSize, 1 + point[1] * game.cellSize, game.cellSize - 1, game.cellSize - 1);
                                for (int j = 0; j < game.table.Count; j++)
                                {
                                    if (game.table[j] == point)
                                    {
                                        game.table.RemoveAt(j);
                                        break;
                                    }
                                }
                            }
                            break;
                        case 3:
                            if (game.scoreWin <= snakeStats.score) table.FillRectangle(Brushes.LightGreen, 1 + point[0] * game.cellSize, 1 + point[1] * game.cellSize, game.cellSize - 1, game.cellSize - 1);
                            //else table.FillRectangle(Brushes.White, 1 + point[0] * game.cellSize, 1 + point[1] * game.cellSize, game.cellSize - 1, game.cellSize - 1);
                            break;

                    }
                }
            }
        }

        public string loadLevel()
        {
            OpenFileDialog loadLevelDialog = new OpenFileDialog();

            loadLevelDialog.Filter = "json Файл (*.json)|*.json|txt Файл (*.txt)|*.txt";
            loadLevelDialog.RestoreDirectory = true;

            string json;

            if (loadLevelDialog.ShowDialog() == DialogResult.OK)
            {
                string fname = loadLevelDialog.FileName;
                json = File.ReadAllText(fname);

                try
                {
                    game = JsonConvert.DeserializeObject<structLevelGame>(json);
                    return json;
                    MessageBox.Show("Уровень загружен!\nЧтобы пройти уровень нам нужно набрать " + game.scoreWin + " очков!\n" + (game.timeLeft > 0 ? ("Время на прохождения уровня: "+(game.timeLeft / 60) + " мин " + (game.timeLeft - (((game.timeLeft / 60) * 60))) + " сек") : ""), "Файл был успешно прочитан", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Уровень не был загружен.\nФайл не корректный.", "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }

            return null;
        }

        public void saveLevel(string json)
        {
            Stream saveStream;

            SaveFileDialog saveLevelDialog = new SaveFileDialog();

            saveLevelDialog.Filter = "json Файл (*.json)|*.json|txt Файл (*.txt)|*.txt";
            saveLevelDialog.RestoreDirectory = true;

            if (saveLevelDialog.ShowDialog() == DialogResult.OK)
            {
                if ((saveStream = saveLevelDialog.OpenFile()) != null)
                {
                    StreamWriter myWriter = new StreamWriter(saveStream);
                    try
                    {
                        myWriter.Write(json);
                    }
                    catch { }
                    finally
                    {
                        myWriter.Close();
                    }
                    saveStream.Close();

                    MessageBox.Show("Уровень сохранён!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

            }
        }
    }
}
