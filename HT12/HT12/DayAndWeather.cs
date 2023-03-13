using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT12
{
    public class DayAndWeather
    {
        public event WeatherHandler? Weather = delegate (string todayWeather)
        {
            Console.WriteLine(todayWeather);
        };
        public string[] todayWeather = {"Облачно", "Ясно", "Дождь", "Снег", "Изморось", "Гроза", "Ветрено"};
        public int countDay;
        public int dateDay;
        private int CountDay 
        {
            get 
            { 
                return countDay; 
            }
            set 
            { 
                if (value > 7) 
                    countDay = 1;
                else 
                    countDay = value;
            }
        }
        private int DateDay
        {
            get
            {
                return dateDay;
            }
            set
            {
                if (value > 31)
                    dateDay = 1;
                else
                    dateDay = value;
            }
        }
        public DayAndWeather() 
        { 
            CountDay= 1;
            DateDay = 1;
        }

        public void WhatToday() 
        {
            Random random = new Random();
            switch(CountDay)
            {
                case 1:
                    Console.Write($"день {DateDay}: Понедельник - погода: ");
                    Weather($"{todayWeather[random.Next(0,6)]}\n");
                    CountDay++;
                    DateDay++;
                    break;
                case 2:
                    Console.Write($"день {DateDay}: Вторник - погода: ");
                    Weather($"{todayWeather[random.Next(0, 6)]}\n");
                    CountDay++;
                    DateDay++;
                    break;
                case 3:
                    Console.Write($"день {DateDay}: Среда - погода: ");
                    Weather($"{todayWeather[random.Next(0, 6)]}\n");
                    CountDay++;
                    DateDay++;
                    break;
                case 4:
                    Console.Write($"день {DateDay}: Четверг - погода: ");
                    Weather($"{todayWeather[random.Next(0, 6)]}\n");
                    CountDay++;
                    DateDay++;
                    break;
                case 5:
                    Console.Write($"день {DateDay}: Пятница - погода: ");
                    Weather($"{todayWeather[random.Next(0, 6)]}\n");
                    CountDay++;
                    DateDay++;
                    break;
                case 6:
                    Console.Write($"день {DateDay}: Суббота - погода: ");
                    Weather($"{todayWeather[random.Next(0, 6)]}\n");
                    CountDay++;
                    DateDay++;
                    break;
                case 7:
                    Console.Write($"день {DateDay}: Воскресенье - погода: ");
                    Weather($"{todayWeather[random.Next(0, 6)]}\n");
                    CountDay++;
                    DateDay++;
                    break;
            }
        }        

    }
}
