using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services
{
    public class ScoreTableService
    {
        private Game _model;

        public ScoreTableService()
        {
            new ScoreTableService()
            {
                _model = new Game()
                {
                    Period = GamePeriod.First,
                    Home = new Team()
                    {
                        Name = "Home",
                        Score = 0,
                    },
                    Host = new Team()
                    {
                        Name = "Host",
                        Score = 0,
                    },
                    CurrentTime = new TimeSpan(0, 15, 0),
                    DefaultTime = new TimeSpan(0, 15, 0),
                    Title = String.Empty,
                }
            };
        }
    }
}
