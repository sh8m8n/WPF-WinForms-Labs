using System;

namespace ConsoleView.ViewModels
{
    public class MainWindowViewModel
    {
        /// <summary>
        /// Таблица студентов
        /// </summary>
        public string StudentSheet { get; set; }

        /// <summary>
        /// Гистограмма распределения студентов по специальностям
        /// </summary>
        public string StudentHistogram { get; set; }
        public ConsoleColor HistogramColor { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="data">Данные которые необходимо отобразить</param>
        public MainWindowViewModel(string studentSheet, string studentHistogram, ConsoleColor histogramColor)
        {
            StudentSheet = studentSheet;
            StudentHistogram = studentHistogram;
            HistogramColor = histogramColor;
        }
    }
}
