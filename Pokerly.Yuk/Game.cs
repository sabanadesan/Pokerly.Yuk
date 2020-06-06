using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pokerly.Yuk
{
    public class Game
    {
        private bool _alive;
        private Poker _poker;
        private int _frame;
        private int _heartbeat;

        public Game(Poker poker)
        {
            _alive = true;
            _frame = 0;
            _heartbeat = 1000;

            _poker = poker;
        }

        private void Close()
        {
            _alive = false;
        }

        private bool Render()
        {
            if (!Draw())
            {
                return false;
            }

            Thread.Sleep(_heartbeat);
            _frame++;

            return true;
        }

        private bool Draw()
        {
            return _poker.Draw();
        }

        public void Run()
        {
            while (_alive)
            {
                if (!Render())
                {
                    Close();
                }
            }
        }
    }
}
