﻿using MoreLinq;

namespace DesignPatterns.Structural.Proxy;

public static class CompositeArrayBackedProxy
{
    public class MasonrySettings
    {
        //public bool Pillars { get; set; }
        //public bool Walls { get; set; }
        //public bool Floors { get; set; }
        //public bool? All
        //{
        //    get
        //    {
        //        if (Pillars == Walls && Walls == Floors) return Pillars;
        //        return null;
        //    }
        //    set
        //    {
        //        if (!value.HasValue) return;
        //        Pillars = value.Value;
        //        Walls = value.Value;
        //        Floors = value.Value;
        //    }
        //}

        private bool? All
        {
            get
            {
                if (_flags.Skip(1).All(f => f == _flags[0]))
                {
                    return _flags[0];
                }
                return null;
            }
            set
            {
                if (!value.HasValue) return;
                _flags.ForEach(x => x = value.Value);
            }
        }
        private readonly bool[] _flags = new bool[3];
        public bool Pillars
        {
            get => _flags[0];
            set => _flags[0] = value;
        }
        public bool Walls
        {
            get => _flags[1];
            set => _flags[1] = value;
        }
        public bool Floors
        {
            get => _flags[2];
            set => _flags[2] = value;
        }

    }

    public static void Render()
    {

    }
}
