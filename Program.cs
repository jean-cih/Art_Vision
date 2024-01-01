using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace ConsolePicture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Type The Name of The Picture - ");
                    string imagePath = "D:/" + Console.ReadLine();
                    Console.Write("\n § - 1    ‡ - 2    ♠ - 3    ♣ - 4 \n ♥ - 5    ♦ - 6    ↔ - 7    $ - 8 \n @ - 9    * - 10   o - 11   ¤ - 12 \nAny different number will set default settings\n");
                    Console.Write("\nWhat Number of Symbol to draw the Picture with - ");
                    int number = Convert.ToInt16(Console.ReadLine());

                    char character = ' ';

                    switch (number)
                    {
                        case 1:
                            character = '§';
                            break;
                        case 2:
                            character = '‡';
                            break;
                        case 3:
                            character = '♠';
                            break;
                        case 4:
                            character = '♣';
                            break;
                        case 5:
                            character = '♥';
                            break;
                        case 6:
                            character = '♦';
                            break;
                        case 7:
                            character = '↔';
                            break;
                        case 8:
                            character = '$';
                            break;
                        case 9:
                            character = '@';
                            break;
                        case 10:
                            character = '*';
                            break;
                        case 11:
                            character = 'o';
                            break;
                        case 12:
                            character = '¤';
                            break;
                        default:
                            break;
                    }

                    Bitmap bitmap = new Bitmap(imagePath);
   
                    if ((float)bitmap.Width / bitmap.Height >= 1.5 && (float)bitmap.Width / bitmap.Height <= 2)
                    {
                        Console.SetWindowSize(160, 40);

                    }
                    else if ((float)bitmap.Width / bitmap.Height > 2)
                    {
                        Console.SetWindowSize(200, 40);
                    }
                    else if ((float)bitmap.Width / bitmap.Height >= 1 && (float)bitmap.Width / bitmap.Height < 1.5)
                    {
                        Console.SetWindowSize(130, 40);
                    }
                    else
                    {
                        Console.SetWindowSize(90, 40);
                    }
                    Console.SetBufferSize(201, 41);

                    int consoleWidth = Console.WindowWidth - 1;
                    int consoleHeight = Console.WindowHeight - 1;

                    int blockWidth = bitmap.Width / consoleWidth;
                    int blockHeight = bitmap.Height / consoleHeight;

                    Stopwatch time = new Stopwatch();
                    time.Start();

                    for (int y = 0; y < bitmap.Height - 2; y += blockHeight)
                    {
                        for (int x = 0; x < bitmap.Width; x += blockWidth)
                        {
                            int totalIntensity = 0;
                            int pixelCount = 0;
                            for (int j = 0; j < blockHeight; j++)
                            {
                                for (int i = 0; i < blockWidth; i++)
                                {
                                    int px = x + i;
                                    int py = y + j;
                                    if (px >= bitmap.Width)
                                    {
                                        px = bitmap.Width - 1;
                                    }
                                    if (py >= bitmap.Height)
                                    {
                                        py = bitmap.Height - 1;
                                    }
                                    Color color = bitmap.GetPixel(px, py);
                                    int intensity = (color.R + color.G + color.B) / 3;
                                    totalIntensity += intensity;
                                    pixelCount++;
                                }
                            }
                            int averageIntensity = totalIntensity / pixelCount;

                            ConsoleColor consoleColor;

                            if (averageIntensity < 15)
                            {
                                if(number > 12)
                                {
                                    character = '@';
                                }
                                consoleColor = ConsoleColor.DarkGray;
                            }
                            else if (averageIntensity < 30)
                            {
                                if (number > 12)
                                {
                                    character = '#';
                                }
                                consoleColor = ConsoleColor.Gray;
                            }
                            else if (averageIntensity < 45)
                            {
                                if (number > 12)
                                {
                                    character = '$';
                                }
                                consoleColor = ConsoleColor.DarkBlue;
                            }
                            else if (averageIntensity < 60)
                            {
                                if (number > 12)
                                {
                                    character = '&';
                                }
                                consoleColor = ConsoleColor.Blue;
                            }
                            else if (averageIntensity < 75)
                            {
                                if (number > 12)
                                {
                                    character = '%';
                                }
                                consoleColor = ConsoleColor.DarkCyan;
                            }
                            else if (averageIntensity < 90)
                            {
                                if (number > 12)
                                {
                                    character = '?';
                                }
                                consoleColor = ConsoleColor.Cyan;
                            }
                            else if (averageIntensity < 105)
                            {
                                if (number > 12)
                                {
                                    character = '8';
                                }
                                consoleColor = ConsoleColor.DarkRed;
                            }
                            else if (averageIntensity < 120)
                            {
                                if (number > 12)
                                {
                                    character = '?';
                                }
                                consoleColor = ConsoleColor.Red;
                            }
                            else if (averageIntensity < 135)
                            {
                                if (number > 12)
                                {
                                    character = '№';
                                }
                                consoleColor = ConsoleColor.DarkGreen;
                            }
                            else if (averageIntensity < 150)
                            {
                                if (number > 12)
                                {
                                    character = 'o';
                                }
                                consoleColor = ConsoleColor.Green;
                            }
                            else if (averageIntensity < 165)
                            {
                                if (number > 12)
                                {
                                    character = '^';
                                }
                                consoleColor = ConsoleColor.DarkYellow;
                            }
                            else if (averageIntensity < 180)
                            {
                                if (number > 12)
                                {
                                    character = ':';
                                }
                                consoleColor = ConsoleColor.Yellow;
                            }
                            else if (averageIntensity < 195)
                            {
                                if (number > 12)
                                {
                                    character = '+';
                                }
                                consoleColor = ConsoleColor.DarkMagenta;
                            }
                            else if (averageIntensity < 210)
                            {
                                if (number > 12)
                                {
                                    character = '-';
                                }
                                consoleColor = ConsoleColor.Magenta;
                            }
                            else if (averageIntensity < 225)
                            {
                                if (number > 12)
                                {
                                    character = '.';
                                }
                                consoleColor = ConsoleColor.White;
                            }
                            else
                            {
                                consoleColor = ConsoleColor.Black;
                            }

                            Console.ForegroundColor = consoleColor;

                            Console.Write(character);
                        }
                        Console.WriteLine();
                    }
                    time.Stop();
                    Console.SetWindowSize(210, 50);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(consoleWidth / 2 - 10, consoleHeight + 1);
                    Console.Write($"Program's time - {time.ElapsedMilliseconds}ms");
                    Console.SetCursorPosition(0, 0);
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nIncorrect Name of the Picture\n {ex}");
                }
            }
        }
    }
}
