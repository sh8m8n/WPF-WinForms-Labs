using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace ConsoleHistogram
{   // │ █ 
    // ┤ █ 
    // ┴─┼─
    //   └

    public class Histogram
    {
        /// <summary>
        /// Максимальная высота столбца
        /// </summary>
        public int Height { get; set; } = 20;
        /// <summary>
        /// Количество символов на которое описание может выпирать за правую часть диаграммы
        /// </summary>
        public int SummaryBulgingLength = 10;

        #region константы
        private const char dataSymbol = '█';
        private const char verticalLine = '│';
        private const char verticaAndlLeftLine = '┤';
        private const char horizontalAndTopLine = '┴';
        private const char corner = '└';
        private const char cross = '┼';
        private const char horizontalLine = '─';
        #endregion

        private char[,] matrix;
        private Dictionary<string, int> data;
        private int scaleValue = 1;//Количество единиц на клетку столбца

        private int maxValueStringLength;
        /// <summary>
        /// (y, x)
        /// </summary>
        private (int, int) cornerCoords; 

        public string GetHistogram(Dictionary<string, int> data)
        {
            maxValueStringLength = data.Values.Max().ToString().Length;
            this.data = data;

            matrix = new char[Height + 2 + data.Count,
                    data.Count * 2 + 4 + maxValueStringLength + SummaryBulgingLength];

            //Вычисление цены деления
            int maxValue = data.Values.Max();
            if (maxValue > Height)
            {
                if (maxValue % Height == 0)
                    scaleValue = maxValue / Height;
                else
                    scaleValue = maxValue / Height + 1;
            }

            DrawHistogram();

            return MatrixToString(matrix);
        }

        private void DrawHistogram()
        {
            //ось y
            for (int y = 0; y < Height + 1; y++)
            {
                matrix[y, maxValueStringLength + 1] = verticalLine;
            }

            //Начало координат
            cornerCoords = (Height + 1, maxValueStringLength + 1);
            matrix[Height + 1, maxValueStringLength + 1] = horizontalAndTopLine;
            matrix[Height + 1, data.Values.Max().ToString().Length] = '0';
            
            //ось x
            for(int x = 0; x < data.Count * 2 + 1; x++)
            {
                if(x % 2 != 0)
                {
                    matrix[Height + 1, maxValueStringLength + 2 + x] = cross;
                }
                else
                {
                    matrix[Height + 1, maxValueStringLength + 2 + x] = horizontalLine;
                }
            }

            //Данные
            int xData = cornerCoords.Item2 + 2;
            int counter = 1;
            foreach(var pair in data)
            {
                string name = pair.Key;
                int value = pair.Value;

                //Столбцы
                for(int y = cornerCoords.Item1 - 1; y > cornerCoords.Item1 - 1 - (value/scaleValue); y-- )
                {
                    matrix[y, xData] = dataSymbol;
                }

                //Значение параметра
                string stringValue = value.ToString();
                for (int i = 0; i < stringValue.Length; i++)
                {
                    matrix[cornerCoords.Item1 - (value / scaleValue),
                        cornerCoords.Item2 - stringValue.Length + i] = stringValue[i];
                }
                matrix[cornerCoords.Item1 - (value / scaleValue), cornerCoords.Item2] = verticaAndlLeftLine;


                //Описание
                for(int y = cornerCoords.Item1 + 1; y < cornerCoords.Item1 + 1 + data.Count - counter; y++)
                {
                    matrix[y, xData] = verticalLine;
                }
                matrix[cornerCoords.Item1 + 1 + data.Count - counter, xData] = corner;

                for(int i = 0; i < name.Length; i++)
                {
                    if(xData + i + 1 < matrix.GetLength(1))
                    {
                        matrix[cornerCoords.Item1 + 1 + data.Count - counter, xData + i + 1] = name[i];
                    }
                }

                xData += 2;
                counter++;
            }
        }

        private string MatrixToString(char[,] matrix)
        {
            StringBuilder sb = new StringBuilder((matrix.Length+1) * 2);
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for(int x = 0; x < matrix.GetLength(1); x++)
                {
                    sb.Append(matrix[y, x]);
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
