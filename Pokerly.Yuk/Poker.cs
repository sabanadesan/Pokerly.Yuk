using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pokerly.Yuk
{
    public class Poker
    {
        public bool Draw()
        {
            System.Console.WriteLine("Playing");
            return true;
        }
    }

    public class TexasHoldemPoker : Poker
    {

    }

    public class Pot
    {
        private ArrayList _actions;

        public Pot()
        {
            Reset();
        }

        public void Reset()
        {
            _actions = new ArrayList();
        }

        public void Append(double bet, Player player)
        {
            _actions.Add(new KeyValuePair<Player, double>(player, bet));
        }

        public double Value()
        {
            double sum = 0;
            foreach(KeyValuePair<Player, double> act in _actions)
            {
                sum += act.Value;
            }

            return sum;
        }
    }

    public class Community
    {
        private ArrayList _cards;

        public Community()
        {
            Reset();
        }

        public void Reset()
        {
            _cards = new ArrayList();
        }

        public void Append(Card card)
        {
            _cards.Add(card);
        }
    }



    public class Table
    {
        private int _maxPlayers;
        private ArrayList _players;

        public Table(int maxPlayers)
        {
            _maxPlayers = maxPlayers;
            Reset();
        }

        public Player Pop(int index)
        {
            if (index < 0 || index >= Size())
            {
                throw new IndexOutOfRangeException();
            }

            Player player = (Player)_players[index];
            _players.RemoveAt(index);

            return player;
        }

        public void Set(int index, Player player)
        {
            if (index < 0 || index >= Size())
            {
                throw new IndexOutOfRangeException();
            }

            _players[index] = player;
        }

        public int Size()
        {
            return _players.Count;
        }

        public Player Value(int index)
        {
            if (index < 0 || index >= Size())
            {
                throw new IndexOutOfRangeException();
            }

            return (Player) _players[index];
        }

        public void Reset()
        {
            _players = new ArrayList();
        }

        public void Shuffle()
        {
            var rng = new Random();
            rng.Shuffle<Player>(_players);
        }
    }
}
