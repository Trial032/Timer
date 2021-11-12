using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Game
    {
        public Team Home { get; set; }
        public Team Host { get; set; }
        public GamePeriod Period { get; set; }
        public TimeSpan CurrentTime { get; set; }
        public TimeSpan DefaultTime { get; set; }
        public string Title { get; set; }
    }
    public enum GamePeriod
    {
        First,
        Second,
        Third,
        Fourth,
        Overtime
    }
}
