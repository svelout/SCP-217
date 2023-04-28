using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP_217
{
    public class Config : IConfig
    {
        [Description("Включение/Выключение плагина")]
        public bool IsEnabled { get; set; } = true;
        [Description("Включение/Выключение Дебаг")]
        public bool Debug { get; set; } = false;
        [Description("Шанс инфекции")]
        public double InfectionChance { get; set; } = 40.50;

        [Description("Время до начала действия SCP-273(в минутах)")]
        public int MinutesToDie { get; set; } = 10;

        [Description("Процент здоровья которое отнимется в секунду")]
        public int healthp { get; set; } = 15;
    }
}
