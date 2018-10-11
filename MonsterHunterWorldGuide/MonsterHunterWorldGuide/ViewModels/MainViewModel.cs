using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterHunterWorldGuide.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public List<Monster> Monsters
        {
            get;
            set;
        }

        public MainViewModel()
        {
            Monsters = new List<Monster>();
        }
    }

    public class Monster
    {

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
